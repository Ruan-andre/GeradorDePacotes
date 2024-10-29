using GeradorDePacotes.Database;
using ReaLTaiizor.Controls;
using System.Text;

namespace GeradorDePacotes.Classes
{
    internal class Package
    {
        private StringBuilder Sb { get; set; }
        private string? FileName { get; set; }
        private string? TargetFolder { get; set; }
        private string? OutputFolder { get; set; }
        public static Dictionary<string, DateTime> DeletedFoldersReport { get; private set; }
        public static Dictionary<string, DateTime> DeletedFilesReport { get; private set; }
        public static int DeletedItemsCount { get; private set; }
        private Control LabelStatus { get; }
        private ParrotCircleProgressBar ProgressBarCount { get; }
        private readonly CancellationToken Token;
        public static string? LogError { get; private set; } // Novo log de erros

        public Package(Control labelStatus, ParrotCircleProgressBar progressBar, CancellationToken token)
        {
            DeletedFoldersReport = new Dictionary<string, DateTime>();
            DeletedFilesReport = new Dictionary<string, DateTime>();
            Sb = new StringBuilder();
            LabelStatus = labelStatus;
            ProgressBarCount = progressBar;
            Token = token;
            FillOwnFieldsOrProperties().ConfigureAwait(false);
        }

        public async Task GeneratePackage()
        {
            try
            {
                var msgError = await VerifyFilesAndFoldersAsync();
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                await DeleteFilesAndFoldersAsync();
                var pathZip = Path.Combine(OutputFolder!, FileName + ".zip");
                UpdateStatus("Criando arquivo zip, aguarde...");
                await Zip.CreateZipFileAsync(TargetFolder!, pathZip, ProgressBarCount, Token);
            }
            catch (OperationCanceledException)
            {
                LogError = "Operação cancelada pelo usuário.";
            }
            catch (Exception ex)
            {
                LogError = $"Erro durante a geração do pacote: {ex.Message}";
                throw; 
            }
        }


        private async Task FillOwnFieldsOrProperties()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var name = await UtilDb.GetLastSelectedFileNameAsync(context);
                    var parValueAddDateTime = await UtilDb.GetParValueAsync(context, "add_date_and_time_to_name");
                    var addDateAndTime = !string.IsNullOrWhiteSpace(parValueAddDateTime) && Convert.ToBoolean(parValueAddDateTime);
                    var date = addDateAndTime ? DateTime.Now.ToString("yyyyMMddHHmmss") : string.Empty;
                    var parValueSameFolder = await UtilDb.GetParValueAsync(context, "same_output_folder");
                    var sameOutputFolder = !string.IsNullOrWhiteSpace(parValueSameFolder) && Convert.ToBoolean(parValueSameFolder);

                    FileName = !string.IsNullOrWhiteSpace(name) ? $"{name}({date})" : $"Package({DateTime.Now.ToString("yyyyMMddHHmmss")})";
                    TargetFolder = await GetTargetFolderAsync(context);
                    OutputFolder = sameOutputFolder ? TargetFolder : await UtilDb.GetParValueAsync(context, "output_folder") ?? TargetFolder;
                }
            }
            catch (Exception ex)
            {
                LogError = $"Erro ao preencher propriedades: {ex.Message}";
                throw;
            }
        }

        private async Task<string> GetTargetFolderAsync(ApplicationDbContext context)
        {
            var directory = await UtilDb.GetParValueAsync(context, "target_folder");
            if (string.IsNullOrWhiteSpace(directory))
            {
                throw new Exception("Não foi possível localizar a pasta alvo. Acesse CONFIGURAÇÕES e preencha o CAMINHO DA PASTA ALVO.");
            }
            return directory;
        }

        private async Task<string> VerifyFilesAndFoldersAsync()
        {
            await Task.Run(() =>
            {
                try
                {
                    UpdateStatus("Verificando pastas e arquivos, aguarde...");

                    using (var context = new ApplicationDbContext())
                    {
                        var foldersToVerify = context.FoldersToVerify.ToList();
                        var filesToVerify = context.FilesToVerify.ToList();

                        Sb.AppendLine("Pastas não encontradas:");
                        foreach (var folder in foldersToVerify)
                        {
                            Token.ThrowIfCancellationRequested();
                            if (!folder.Disconsider && !Directory.Exists(Path.Combine(TargetFolder!, folder.NameFolder)))
                            {
                                Sb.AppendLine(folder.NameFolder);
                            }
                        }

                        Sb.AppendLine("\nArquivos não encontrados:");
                        foreach (var file in filesToVerify)
                        {
                            Token.ThrowIfCancellationRequested();
                            if (!file.Disconsider && !File.Exists(Path.Combine(TargetFolder!, file.NameFile)))
                            {
                                Sb.AppendLine(file.NameFile);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    LogError = $"Erro ao verificar arquivos e pastas: {ex.Message}";
                    throw;
                }
            });

            var linhas = Sb.ToString().Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (linhas.Length > 2)
            {
                return Sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        private async Task DeleteFilesAndFoldersAsync()
        {
            await Task.Run(() =>
            {
                try
                {
                    UpdateStatus("Deletando pastas e arquivos, aguarde...");

                    using (var context = new ApplicationDbContext())
                    {
                        var foldersToDelete = context.FoldersToDelete.ToList();
                        var filesToDelete = context.FilesToDelete.ToList();

                        foreach (var folder in foldersToDelete)
                        {
                            Token.ThrowIfCancellationRequested();
                            DeleteFolder(folder.NameFolder);
                        }

                        foreach (var file in filesToDelete)
                        {
                            Token.ThrowIfCancellationRequested();
                            DeleteFile(file.NameFile);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogError = $"Erro ao deletar arquivos e pastas: {ex.Message}";
                    throw;
                }
            });

            using (var context = new ApplicationDbContext())
            {
                await UtilDb.AddToGridDeletedFolders(context, DeletedFoldersReport);
                await UtilDb.AddToGridDeletedFiles(context, DeletedFilesReport);
            }
        }

        private void DeleteFolder(string folderName)
        {
            try
            {
                var path = Path.Combine(TargetFolder!, folderName);
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    DeletedFoldersReport.Add(folderName, DateTime.Now);
                    DeletedItemsCount++;
                }
                else
                {
                    DeletedFoldersReport.Add($"{folderName} (não encontrada)", DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                DeletedFoldersReport.Add($"{folderName} (Erro ao excluir: {ex.Message})", DateTime.Now);
            }
        }

        private void DeleteFile(string fileName)
        {
            try
            {
                var path = Path.Combine(TargetFolder!, fileName);
                if (File.Exists(path))
                {
                    File.Delete(path);
                    DeletedFilesReport.Add(fileName, DateTime.Now);
                    DeletedItemsCount++;
                }
                else if (fileName.StartsWith('*'))
                {
                    var filesWithPattern = Directory.GetFiles(TargetFolder!, fileName);
                    foreach (var file in filesWithPattern)
                    {
                        File.Delete(file);
                        DeletedFilesReport.Add(fileName, DateTime.Now);
                        DeletedItemsCount++;
                    }
                }
                else
                {
                    DeletedFilesReport.Add($"{fileName} (não encontrado)", DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                DeletedFilesReport.Add($"{fileName} (Erro ao excluir: {ex.Message})", DateTime.Now);
            }
        }

        private void UpdateStatus(string message)
        {
            LabelStatus.Invoke(() => { LabelStatus.Text = message; });
        }
    }
}
