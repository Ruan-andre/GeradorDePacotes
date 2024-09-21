using System.IO.Compression;
using ReaLTaiizor.Controls;

namespace GeradorDePacotes.Classes
{
    public static class Zip
    {
        public async static Task CreateZipFileAsync(string rootFolder, string pathZipFile, ParrotCircleProgressBar progressBar, CancellationToken token)
        {
            
                string[] allFiles = Directory.GetFiles(rootFolder, "*.*", SearchOption.AllDirectories);
                int totalFiles = allFiles.Length;
                int currentFile = 0;
                object lockObject = new object(); 

                using (FileStream zipToCreate = new FileStream(pathZipFile, FileMode.Create))
                using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                {
                    byte[] buffer = new byte[81920]; 

                    await Task.Run(() =>
                    {
                        Parallel.ForEach(allFiles, file =>
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

                                lock (lockObject)
                                {
                                    currentFile++;
                                    var percentage = (double)currentFile / totalFiles * 100.0;

                                    if (currentFile % 100 == 0 || currentFile == totalFiles)
                                    {
                                        progressBar.Invoke(() =>
                                        {
                                            progressBar.percentage = (int)percentage;
                                            progressBar.Refresh();
                                        });
                                    }
                                }
                            }
                        });
                    });

                    progressBar.Invoke(() =>
                    {
                        progressBar.percentage = 100;
                        progressBar.Refresh();
                    });
                }


            }
            
        }
    }
