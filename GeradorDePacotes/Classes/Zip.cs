using ExcluirArquivosPublicacao.Services;
using System.IO.Compression;


namespace ExcluirArquivosPublicacao.Entities
{
    public static class Zip
    {

        public static void CriaArquivoZip(string pastaOrigem, string arquivoZIP)
        {

            try
            {
                string[] verificarPastas = Util.PastasParaVerificar;
                string[] verificarArquivos = Util.ArquivosParaVerificar;

                foreach (string pasta in verificarPastas)
                {
                    string pastaTemp = Path.Combine(pastaOrigem, pasta);
                    //Remove da verificação a pasta sessao-online por conta do projeto SQL SERVER
                    if (!Directory.Exists(pastaTemp) && pastaTemp.Substring(pastaTemp.LastIndexOf("\\") + 1) != "sessao-online")
                    {
                        int lastIndex = pastaTemp.LastIndexOf("\\");
                        string lastPart = pastaTemp.Substring(lastIndex);
                        throw new Exception($"Pasta '{lastPart}' não encontrada no projeto");
                    }
                }

                foreach (string arquivo in verificarArquivos)
                {
                    string arquivoTemp = Path.Combine(pastaOrigem, arquivo);

                    if (!File.Exists(arquivoTemp))
                    {
                        int lastIndex = arquivoTemp.LastIndexOf("\\");
                        string lastPart = arquivoTemp.Substring(lastIndex + 1);
                        throw new Exception($"Arquivo '{lastPart}' não encontrada no projeto");
                    }

                }

                //using (var progressBar = new ProgressBar())
                //{
                //    Console.WriteLine();
                //    progressBar.Update(0); // Inicia a barra de progresso

                //    // Cria um novo arquivo ZIP
                //    using (FileStream zipToCreate = new FileStream(arquivoZIP, FileMode.Create))
                //    {
                //        using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                //        {
                //            // Obtém a lista de arquivos e pastas
                //            string[] allFiles = Directory.GetFiles(pastaOrigem, "*.*", SearchOption.AllDirectories);
                //            int totalFiles = allFiles.Length;
                //            int currentFile = 0;

                //            // Adiciona os arquivos ao arquivo ZIP
                //            foreach (string file in allFiles)
                //            {

                //                if (file != arquivoZIP)
                //                {
                //                    string entryName = file.Replace(pastaOrigem, "").TrimStart(Path.DirectorySeparatorChar);
                //                    archive.CreateEntryFromFile(file, entryName);

                //                    currentFile++;
                //                    double progressPercentage = (double)currentFile / totalFiles * 100;
                //                    progressBar.Update((int)progressPercentage); // Atualiza a barra de progresso

                //                }
                //            }
                //        }
                //    }

                //    progressBar.Update(100); // Completa a barra de progresso
                //}

                // Armazena a quantidade de itens que serão armazenados no ZIP
                string[] pastaAdicionadas = Directory.GetDirectories(pastaOrigem);
                string[] arquivosAdicionados = Directory.GetFiles(pastaOrigem);
                int totalArquivosAdicionados = pastaAdicionadas.Length + arquivosAdicionados.Length - 1;
                if (totalArquivosAdicionados == 27)
                {
                    Util.WriteLineC("\n\n    Pacote gerado com sucesso: " + arquivoZIP, ConsoleColor.Green);
                }
                else
                {
                    Util.WriteLineC("\n    ATENÇÃO!!!\n", ConsoleColor.Red);
                    Util.WriteC($"    O total de itens adicionados no ZIP foi ", ConsoleColor.Yellow);
                    Util.WriteC($"{totalArquivosAdicionados}", ConsoleColor.Cyan);
                    Util.WriteC(". Esperava-se adicionar 27 itens ao ZIP.\n\n    Verifique se os itens estão corretos antes" +
                        " de atualizar o cliente.", ConsoleColor.Yellow);
                }

                string pastaSessaoOnline = Path.Combine(pastaOrigem, "sessao-online");
                if (!Directory.Exists(pastaSessaoOnline))
                {
                    Util.WriteC($"\n    A pasta {pastaSessaoOnline} não foi localizada no projeto, se você estiver gerando" +
                        $"\n    um pacote do SQLServer, apenas ignore. Se for do MySQL, favor revisar os itens de publicação!!! ", ConsoleColor.Yellow);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"    Erro ao criar arquivo ZIP: {e.Message}");
            }
        }
    }
}
