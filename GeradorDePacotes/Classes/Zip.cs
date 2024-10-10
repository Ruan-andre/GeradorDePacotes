using System.IO.Compression;
using ReaLTaiizor.Controls;
using System.Threading.Tasks;
using System.Text;

namespace GeradorDePacotes.Classes
{
    public static class Zip
    {
        public static int AddedItemsCount { get; private set; }

        private static readonly object logLock = new object();
        public static string? LogError { get; private set; }

        public async static Task CreateZipFileAsync(string rootFolder, string pathZipFile, ParrotCircleProgressBar progressBar, CancellationToken token)
        {
            string[] allFiles = Directory.GetFiles(rootFolder, "*.*", SearchOption.AllDirectories);
            int totalFilesCount = allFiles.Length;
            int processedFilesCount = 0;
            object lockObject = new object();

            using (FileStream zipToCreate = new FileStream(pathZipFile, FileMode.Create))
            using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
            {
                byte[] buffer = new byte[81920];

                await Task.Run(() =>
                {
                    if (totalFilesCount > 500)
                    {
                        Parallel.ForEach(allFiles, file =>
                        {
                            ProcessFile(file, rootFolder, pathZipFile, archive, progressBar, buffer, lockObject, token, ref processedFilesCount, totalFilesCount);
                        });
                    }
                    else
                    {
                        foreach (var file in allFiles)
                        {
                            ProcessFile(file, rootFolder, pathZipFile, archive, progressBar, buffer, lockObject, token, ref processedFilesCount, totalFilesCount);
                        }
                    }
                }).ConfigureAwait(false);

                progressBar.Invoke(() =>
                {
                    progressBar.percentage = 100;
                    progressBar.Refresh();
                });
            }

            AddedItemsCount = processedFilesCount;
        }

        private static void ProcessFile(string file, string rootFolder, string pathZipFile, ZipArchive archive, ParrotCircleProgressBar progressBar, byte[] buffer, object lockObject, CancellationToken token, ref int processedFilesCount, int totalFilesCount)
        {
            var sb = new StringBuilder();
            try
            {
                token.ThrowIfCancellationRequested();

                if (file != pathZipFile)
                {
                    string entryName = file.Replace(rootFolder, "").TrimStart(Path.DirectorySeparatorChar);

                    lock (lockObject)
                    {
                        ZipArchiveEntry entry = archive.CreateEntry(entryName, CompressionLevel.Fastest);
                        using (var entryStream = entry.Open())
                        using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, buffer.Length, true))
                        {
                            fileStream.CopyTo(entryStream);
                        }
                    }

                    int progressValue = Interlocked.Increment(ref processedFilesCount);
                    double percentage = (double)progressValue / totalFilesCount * 100.0;

                    if (progressValue % (totalFilesCount / 100) == 0 || progressValue == totalFilesCount)
                    {
                        progressBar.Invoke(() =>
                        {
                            progressBar.percentage = (int)percentage;
                            progressBar.Refresh();
                        });
                    }
                }
            }
            catch (OperationCanceledException)
            {
                AppendError($"Operação cancelada ao processar o arquivo {file}.");
                throw;
            }
            catch (IOException ioEx)
            {
                AppendError($"Erro de I/O ao processar o arquivo {file}: {ioEx.Message}");
            }
            catch (UnauthorizedAccessException authEx)
            {
                AppendError($"Permissão negada para o arquivo {file}: {authEx.Message}");
            }
            catch (Exception ex)
            {
                AppendError($"Erro ao processar o arquivo {file}: {ex.Message}");
            }
        }


        private static void AppendError(string error)
        {
            lock (logLock)
            {
                LogError += error + Environment.NewLine;
            }
        }
    }
}
