

using ExcluirArquivosPublicacao.Entities;
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
        public Control LabelStatus { get; }
        public ParrotCircleProgressBar ProgressBarCount { get; }

        public Package(ApplicationDbContext ctx, Control labelStatus, ParrotCircleProgressBar progressBar)
        {
            Context = ctx;
            DeletedFolders = new List<string>();
            DeletedFiles = new List<string>();
            Sb = new StringBuilder();
            LabelStatus = labelStatus;
            ProgressBarCount = progressBar;
            FillOwnFieldsOrProperties();
        }
        public void GeneratePackage()
        {
            VerifyFilesAndFolders();
            DeleteFilesAndFolders();
            var pathZip = Path.Combine(OutputFolder, FileName + ".zip");
            Zip.CreateZipFile(TargetFolder, pathZip, ProgressBarCount);
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
        private void VerifyFilesAndFolders()
        {
            LabelStatus.Text = "Verificando pastas e arquivos, aguarde...";
            var foldersToVerify = Context.FoldersToVerify.AsQueryable();
            var filesToVerify = Context.FilesToVerify.AsQueryable();

            Sb.AppendLine("Pastas não encontradas: ");
            foreach (var folder in foldersToVerify)
            {
                if (folder.Disconsider != true && !Directory.Exists(Path.Combine(TargetFolder!, folder.NameFolder)))
                    Sb.AppendLine(folder.NameFolder);

            }
            ProgressBarCount.Percentage += 10;

            Sb.AppendLine("\nArquivos não encontrados: ");
            foreach (var file in filesToVerify)
            {
                if (file.Disconsider != true && !File.Exists(Path.Combine(TargetFolder!, file.NameFile)))
                    Sb.AppendLine(file.NameFile);
            }

            var sbLength = Sb.ToString().Split("\n").Length;
            if (sbLength > 4)
            {
                LabelStatus.Text = "Erro";
                throw new Exception(Sb.ToString());
            }

            ProgressBarCount.Percentage += 10;
        }
        private void DeleteFilesAndFolders()
        {
            LabelStatus.Text = "Deletando pastas e arquivos, aguarde...";

            var foldersToDelete = Context.FoldersToDelete.AsQueryable();
            var filesToDelete = Context.FilesToDelete.AsQueryable();
            var _sb = new StringBuilder();

            foreach (var folder in foldersToDelete)
            {
                try
                {
                    if (folder.Disconsider != true && Directory.Exists(Path.Combine(TargetFolder!, folder.NameFolder)))
                    {
                        Directory.Delete(Path.Combine(TargetFolder!, folder.NameFolder));
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
            ProgressBarCount.Percentage += 10;


            foreach (var file in filesToDelete)
            {
                try
                {
                    if (file.Disconsider != true && Directory.Exists(Path.Combine(TargetFolder!, file.NameFile)))
                    {
                        Directory.Delete(Path.Combine(TargetFolder!, file.NameFile));
                        DeletedFolders.Add(file.NameFile);
                    }
                    else
                    {
                        DeletedFolders.Add($"{file.NameFile} (não encontrado)");
                    }

                }
                catch (Exception)
                {
                    DeletedFolders.Add($"{file.NameFile} (Erro ao excluir)");
                }
            }
            ProgressBarCount.Percentage += 10;
        }
    }
}
