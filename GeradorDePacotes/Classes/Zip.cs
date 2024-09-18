using ReaLTaiizor.Controls;
using ReaLTaiizor.Util;
using System.IO.Compression;


namespace ExcluirArquivosPublicacao.Entities
{
    public static class Zip
    {
        public async static Task CreateZipFileAsync(string rootFolder, string pathZipFile, ParrotCircleProgressBar progressBar)
        {
            await Task.Run(() =>
             {
                 try
                 {
                     using (FileStream zipToCreate = new FileStream(pathZipFile, FileMode.Create))
                     {
                         using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                         {
                             string[] allFiles = Directory.GetFiles(rootFolder, "*.*", SearchOption.AllDirectories);
                             int totalFiles = allFiles.Length;
                             int currentFile = 0;
                             int refresher = 0;

                             // Adiciona os arquivos ao arquivo ZIP
                             foreach (string file in allFiles)
                             {
                                 if (file != pathZipFile)
                                 {
                                     string entryName = file.Replace(rootFolder, "").TrimStart(Path.DirectorySeparatorChar);
                                     archive.CreateEntryFromFile(file, entryName);

                                     currentFile++;
                                     var percentage = (((double)currentFile / (double)totalFiles) * 100.00);

                                     progressBar.Invoke(() =>
                                     {
                                         progressBar.percentage = (int)percentage;
                                         refresher++;
                                         if (refresher >= 100)
                                         {
                                             progressBar.Refresh();
                                             refresher = 0;
                                         }
                                     });
                                 }
                             }
                             // Para finalizar com 100%, pode ser que pare em 99%
                             progressBar.Invoke(() =>
                             {
                                 if (progressBar.percentage < 100)
                                 {
                                     progressBar.percentage = 100;
                                     progressBar.Refresh();
                                 }
                             });
                         }
                     }


                     //string[] pastaAdicionadas = Directory.GetDirectories(rootFolder);
                     //string[] arquivosAdicionados = Directory.GetFiles(rootFolder);
                     //int totalArquivosAdicionados = pastaAdicionadas.Length + arquivosAdicionados.Length - 1;
                 }
                 catch (Exception ex)
                 {
                     string message = $"Erro ao criar arquivo ZIP: {ex.Message}";
                     throw new Exception(message, ex);
                 }
             });
        }
    }

}
