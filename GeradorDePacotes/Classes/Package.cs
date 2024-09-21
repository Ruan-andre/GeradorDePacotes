﻿

using GeradorDePacotes.Database;
using ReaLTaiizor.Controls;
using System.Text;

namespace GeradorDePacotes.Classes
{
    internal class Package
    {
        private ApplicationDbContext Context { get; set; }
        private StringBuilder Sb { get; set; }
        private string? FileName { get; set; }
        private string? TargetFolder { get; set; }
        private string? OutputFolder { get; set; }
        public List<string> DeletedFolders { get; }
        public List<string> DeletedFiles { get; }
        private Control LabelStatus { get; }
        private ParrotCircleProgressBar ProgressBarCount { get; }

        private readonly CancellationToken Token;

        public Package(Control labelStatus, ParrotCircleProgressBar progressBar, CancellationToken token)
        {
            Context = new ApplicationDbContext();
            DeletedFolders = new List<string>();
            DeletedFiles = new List<string>();
            Sb = new StringBuilder();
            LabelStatus = labelStatus;
            ProgressBarCount = progressBar;
            Token = token;
            FillOwnFieldsOrProperties();
        }
        public async Task GeneratePackage()
        {
            var taskVerify = VerifyFilesAndFoldersAsync();
            var taskDelete = DeleteFilesAndFoldersAsync();
            var pathZip = Path.Combine(OutputFolder!, FileName + ".zip");
            await Task.WhenAll(taskVerify, taskDelete);
            LabelStatus.Invoke(() =>
            {
                LabelStatus.Text = "Criando arquivo zip, aguarde...";
            });

            await Zip.CreateZipFileAsync(TargetFolder!, pathZip, ProgressBarCount, Token);
        }

        private async void FillOwnFieldsOrProperties()
        {
            var name = await UtilDb.GetLastSelectedFileNameAsync(Context);
            var parValueAddDateTime = await UtilDb.GetParValueAsync(Context, "add_date_and_time_to_name");
            var addDateAndTime = !string.IsNullOrWhiteSpace(parValueAddDateTime) ? Convert.ToBoolean(parValueAddDateTime) : false;
            var date = addDateAndTime ? DateTime.Now.ToString("yyyyMMddHHmm") : string.Empty;
            var parValueSameFolder = await UtilDb.GetParValueAsync(Context, "same_output_folder");
            var sameOutputFolder = !string.IsNullOrWhiteSpace(parValueSameFolder) ? Convert.ToBoolean(parValueSameFolder) : false;


            if (!string.IsNullOrWhiteSpace(name))
                FileName = name + date;
            else
                FileName = "Package" + DateTime.Now.ToString("yyyyMMddHHmm");

            var directory = await UtilDb.GetParValueAsync(Context, "target_folder");

            if (!string.IsNullOrWhiteSpace(directory))
                TargetFolder = directory;
            else
                throw new Exception("Não foi possível localizar a pasta alvo, acesse CONFIGURAÇÕES e preencha o CAMINHO DA PASTA ALVO. ");

            if (!sameOutputFolder)
            {
                var parValueOutputFolder = await UtilDb.GetParValueAsync(Context, "output_folder");
                OutputFolder = !string.IsNullOrWhiteSpace(parValueOutputFolder) ? parValueOutputFolder : TargetFolder;
            }
            else
            {
                OutputFolder = TargetFolder;
            }
        }
        private async Task VerifyFilesAndFoldersAsync()
        {
            await Task.Run(() =>
            {
                using (var Context = new ApplicationDbContext())
                {
                    LabelStatus.Invoke(() => { LabelStatus.Text = "Verificando pastas e arquivos, aguarde..."; });
                    var foldersToVerify = Context.FoldersToVerify.AsQueryable();
                    var filesToVerify = Context.FilesToVerify.AsQueryable();

                    Sb.AppendLine("Pastas não encontradas: ");
                    foreach (var folder in foldersToVerify)
                    {
                        if (folder.Disconsider != true && !Directory.Exists(Path.Combine(TargetFolder!, folder.NameFolder)))
                            Sb.AppendLine(folder.NameFolder);

                    }

                    Sb.AppendLine("\nArquivos não encontrados: ");
                    foreach (var file in filesToVerify)
                    {
                        if (file.Disconsider != true && !File.Exists(Path.Combine(TargetFolder!, file.NameFile)))
                            Sb.AppendLine(file.NameFile);
                    }

                    var sbLength = Sb.ToString().Split("\n").Length;
                    if (sbLength > 4)
                    {
                        LabelStatus.Invoke(() => { LabelStatus.Text = "Erro"; });
                        throw new Exception(Sb.ToString());
                    }
                }
            });
        }
        private async Task DeleteFilesAndFoldersAsync()
        {
            await Task.Run(() =>
            {
                using (var Context = new ApplicationDbContext())
                {
                    LabelStatus.Invoke(() => { LabelStatus.Text = "Deletando pastas e arquivos, aguarde..."; });

                    var foldersToDelete = Context.FoldersToDelete.AsQueryable();
                    var filesToDelete = Context.FilesToDelete.AsQueryable();
                    var _sb = new StringBuilder();

                    foreach (var folder in foldersToDelete)
                    {
                        try
                        {
                            if (folder.Disconsider != true && Directory.Exists(Path.Combine(TargetFolder!, folder.NameFolder)))
                            {
                                Directory.Delete(Path.Combine(TargetFolder!, folder.NameFolder), true);
                                DeletedFolders.Add(folder.NameFolder);
                            }
                            else
                            {
                                DeletedFolders.Add($"{folder.NameFolder} (não encontrada)");
                            }

                        }
                        catch (Exception)
                        {
                            DeletedFolders.Add($"{folder.NameFolder} (Erro ao excluir)");
                        }
                    }


                    foreach (var file in filesToDelete)
                    {
                        try
                        {
                            if (file.Disconsider != true && File.Exists(Path.Combine(TargetFolder!, file.NameFile)))
                            {
                                File.Delete(Path.Combine(TargetFolder!, file.NameFile));
                                DeletedFiles.Add(file.NameFile);
                            }
                            else
                            {
                                DeletedFiles.Add($"{file.NameFile} (não encontrado)");
                            }

                        }
                        catch (Exception)
                        {
                            DeletedFiles.Add($"{file.NameFile} (Erro ao excluir)");
                        }
                    }
                }
            });
        }
    }
}
