using ExcluirArquivosPublicacao.Services;


namespace ExcluirArquivosPublicacao.Entities
{
    internal static class ExcluirArquivos
    {
        public static List<string> ArquivosExcluidos = new List<string>();
        public static List<string> PastasExcluidas = new List<string>();

        public static void Excluir(string diretorio)
        {
            var lines = File.ReadAllLines(Util.PathConfigurationFile);
            string[] pastasExcluir = Util.PastasParaExcluir;
            string[] arquivosExcluir = Util.ArquivosParaExcluir;

            try
            {
                foreach (string pasta in pastasExcluir)
                {
                    string pastaExcluirPath = Path.Combine(diretorio, pasta);
                    if (Directory.Exists(pastaExcluirPath))
                    {
                        Directory.Delete(pastaExcluirPath, true); // Exclui a pasta e seu conteúdo
                        PastasExcluidas.Add(pasta);
                    }
                }

                foreach (string padrao in arquivosExcluir)
                {
                    //Pega os arquivos do diretório para considerar os que possuem padrão de busca como por exemplo o *.sln
                    string[] arquivos = Directory.GetFiles(diretorio, padrao);

                    foreach (string arquivo in arquivos)
                    {
                        if (File.Exists(arquivo))
                        {
                            File.Delete(arquivo); // Exclui o arquivo
                            ArquivosExcluidos.Add(arquivo);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Util.WriteLineC("Erro: " + e.Message, ConsoleColor.Red);
                return;
            }

        }

        public static void ExibirExcluidos()
        {
            int itens = 0;
            if (PastasExcluidas.Count() != 0)
            {
                Util.WriteLineC("\n    PASTAS EXCLUÍDAS:\n", ConsoleColor.Cyan);
                Console.WriteLine("    -----------------------------");
                foreach (var pasta in PastasExcluidas)
                {
                    Console.WriteLine(@"    |   \" + pasta);
                    itens++;
                }
                Console.WriteLine("    -----------------------------");
            }

            if (ArquivosExcluidos.Count() != 0)
            {
                string[] temp = { };

                Util.WriteLineC("\n\n    ARQUIVOS EXCLUÍDOS:", ConsoleColor.Cyan);
                Console.WriteLine("    -----------------------------------------");
                foreach (string arquivo in ArquivosExcluidos)
                {
                    int lastIndex = arquivo.LastIndexOf('\\');
                    string lastPart = arquivo.Substring(lastIndex + 1);
                    Console.WriteLine(@"    |   " + lastPart);
                    itens++;
                }
                Console.WriteLine("    -----------------------------------------");

            }
            if (itens == 9)
            {
                Console.Write($"\n    Total de itens excluídos: ");
                Util.WriteLineC(itens.ToString() + "\n", ConsoleColor.Cyan);

            }
            else
            {
                Util.WriteC("\n\n    OBSERVAÇÃO: O total de itens excluídos foi ", ConsoleColor.Yellow);
                Util.WriteC($"{itens}", ConsoleColor.Cyan);
                Util.WriteC("\n\n    VERIFIQUE SE O PACOTE ESTÁ CORRETO ANTES DE ATUALIZAR O CLIENTE\n", ConsoleColor.Yellow);

            }
        }
    }
}
