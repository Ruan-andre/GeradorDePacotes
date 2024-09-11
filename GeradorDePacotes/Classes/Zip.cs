using ReaLTaiizor.Controls;
using System.IO.Compression;


namespace ExcluirArquivosPublicacao.Entities
{
    public static class Zip
    {

        public static void CreateZipFile(string rootFolder, string pathZipFile, ParrotCircleProgressBar progressBar)
        {
            try
            {

                // Cria um novo arquivo ZIP
                using (FileStream zipToCreate = new FileStream(pathZipFile, FileMode.Create))
                {
                    using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                    {
                        // Obtém a lista de arquivos e pastas
                        string[] allFiles = Directory.GetFiles(rootFolder, "*.*", SearchOption.AllDirectories);
                        int totalFiles = allFiles.Length;
                        int currentFile = 0;

                        // Adiciona os arquivos ao arquivo ZIP
                        foreach (string file in allFiles)

                            if (file != pathZipFile)
                            {
                                string entryName = file.Replace(rootFolder, "").TrimStart(Path.DirectorySeparatorChar);
                                archive.CreateEntryFromFile(file, entryName);

                                currentFile++;
                                progressBar.percentage += currentFile / totalFiles * 60;

                            }
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
        }
    }

}
