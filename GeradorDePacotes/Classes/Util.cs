
namespace ExcluirArquivosPublicacao.Services
{
    public static class Util
    {
        static int paciencia = 3;
        public static string NomeDoZIP { get; set; }
        public static string CaminhoDaPasta { get; set; }
        public static string PathConfigurationFile { get; set; }
        public static string[] PastasParaExcluir { get; set; }
        public static string[] ArquivosParaExcluir { get; set; }
        public static string[] PastasParaVerificar { get; set; }
        public static string[] ArquivosParaVerificar { get; set; }
        private static string[] _linhasConfig { get; set; }

        public static void WriteLineC(string texto, ConsoleColor cor)
        {
            // Salva a cor atual da fonte
            ConsoleColor corOriginal = Console.ForegroundColor;

            // Define a nova cor da fonte
            Console.ForegroundColor = cor;

            // Escreve a linha com a nova cor
            Console.WriteLine(texto);

            // Restaura a cor original da fonte
            Console.ForegroundColor = corOriginal;
        }

        public static void WriteC(string texto, ConsoleColor cor)
        {
            // Salva a cor atual da fonte
            ConsoleColor corOriginal = Console.ForegroundColor;

            // Define a nova cor da fonte
            Console.ForegroundColor = cor;

            // Escreve a linha com a nova cor
            Console.Write(texto);

            // Restaura a cor original da fonte
            Console.ForegroundColor = corOriginal;
        }

        public static void ConfigurationFile()
        {
            var mainDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var fileConfigName = "config(GeradorDePacotes).txt";
            var configFile = Path.Combine(mainDirectory, fileConfigName);
            string[] lines = { };
           if (File.Exists(configFile))
            {
                lines = File.ReadAllLines(configFile);
            }
            

            if (!File.Exists(configFile) || lines.Length < 26 )
            {
                SolicitaCaminho();
                CreateConfigFile(configFile, CaminhoDaPasta);
                WriteLineC("\n    O arquivo de configuração foi criado com sucesso no caminho:", ConsoleColor.Yellow);
                WriteLineC($"\n    {configFile}", ConsoleColor.Green);
                AtribuiPropriedades(configFile);
            }
            else
            {
                AtribuiPropriedades(configFile);
                _linhasConfig = File.ReadAllLines(configFile);
                var arquivozip = _linhasConfig[0].Substring(0, 20);

                if (_linhasConfig.Length <= 1 || _linhasConfig[0].Substring(0, 20) != "Nome_Do_Arquivo_ZIP=")
                {
                    throw new Exception("Arquivo de configuração está incorreto, por favor corrija-o ou apague e execute o programa novamente.");

                }
                if (_linhasConfig[2].Length < 30 || _linhasConfig[2].Substring(0, 31) != "Caminho_Da_Pasta_De_Publicacao=")
                {
                    throw new Exception("Arquivo de configuração está incorreto, por favor corrija-o ou apague e execute o programa novamente.");

                }
                if (String.IsNullOrEmpty(_linhasConfig[4].Substring(0, 20)))
                {
                    throw new Exception("Arquivo de configuração está incorreto, por favor corrija-o ou apague e execute o programa novamente.");
                }
                if (String.IsNullOrEmpty(_linhasConfig[6].Substring(0, 22)))
                {
                    throw new Exception("Arquivo de configuração está incorreto, por favor corrija-o ou apague e execute o programa novamente.");
                }

                if (String.IsNullOrWhiteSpace(NomeDoZIP))
                {
                    throw new Exception("Arquivo de configuração está incorreto, por favor corrija-o ou apague e execute o programa novamente.");
                }
                if (String.IsNullOrWhiteSpace(CaminhoDaPasta))
                {
                    throw new Exception("Arquivo de configuração está incorreto, por favor corrija-o ou apague e execute o programa novamente.");
                }
            }
        }


        public static void SolicitaCaminho()
        {
            string pastaAlvo = "";
            Util.WriteC("\n\n    A sua pasta de publicação está no diretório ", ConsoleColor.Yellow);
            Util.WriteC(@"'C:\Publish' ?", ConsoleColor.Green);
            Util.WriteC(" (S / N) ", ConsoleColor.Yellow);
            string resp = Console.ReadLine();

            if (resp.ToUpper() == "S")
            {
                pastaAlvo = @"C:\Publish";
                if (!Directory.Exists(pastaAlvo))
                {
                    WriteLineC($"\n\n    O diretório {pastaAlvo} não existe, crie-o, ou informe um diretório existente\n    para a pasta de publicação.", ConsoleColor.Red);
                }
                CaminhoDaPasta = pastaAlvo;
            }
            else if (resp.ToUpper() == "N")
            {
                Util.WriteLineC("\n\n    Por favor, informe o local da sua pasta: ", ConsoleColor.Yellow);
                CaminhoDaPasta = Console.ReadLine();
            }
            else
            {
                paciencia--;

                if (paciencia == 0)
                {
                    throw new Exception("   Erro: O usuário tá de gracinha.");
                }
                Util.WriteLineC("\n\n    Opção incorreta, digite somente S ou N, por favor.", ConsoleColor.Red);
                SolicitaCaminho();

            }
        }

        public static void CreateConfigFile(string path, string pathPastaPublicacao)
        {
            var createConfigFile = File.Create(path);
            createConfigFile.Dispose();

            var defaultText = File.CreateText(path);
            defaultText.WriteLine("Nome_Do_Arquivo_ZIP=camaramodelonovo\n");
            defaultText.WriteLine($"Caminho_Da_Pasta_De_Publicacao={pathPastaPublicacao}\n");
            defaultText.WriteLine("Pastas_Para_Excluir=packages/Arquivo/img\n");
            defaultText.WriteLine("Arquivos_Para_Excluir=AppSettings.config.example/*.sln/packages.config/robots.txt/web.config/web.config.example/*.zip/*.rar\n");
            defaultText.WriteLine("Pastas_Para_Verificar=api/autenticidade/auxiliares/bin/bootflat/ckeditor/css/dio/" +
                "Email/Error/estatistica/ideia-legislativa/js/legislacao/legislativo-cidadao/legislativo-digital/" +
                "pdfjs/plenario-digital/portal/portal-assinatura/portal-generico/sessao-online/Sistema/spe/spl/stats\n");
            defaultText.WriteLine("Arquivos_Para_Verificar=PrecompiledApp.config\n");

            defaultText.WriteLine($"\n\n\n\n ***OBSERVAÇÃO***");
            defaultText.WriteLine($"O arquivo sempre deverá conter as linhas de configuração nesta ordem:");
            defaultText.WriteLine($"'NomeDoArquivoZIP=' na primeira linha\n'CaminhoDaPastaDePublicacao=' na segunda terceira\n" +
                $"'Pastas_Para_Excluir=' na quinta linha\n'Arquivos_Para_Excluir=' na sétima linha\n'Pastas_Para_Verificar=' na nona linha" +
                $"\n'Arquivos_Para_Verificar=' na décima linha");
            defaultText.Write($"\nEu poderia ter deixado ambos em qualquer ordem, mas fiquei com preguiça, é isso.");
            defaultText.Dispose();
        }
        private static void AtribuiPropriedades(string pathConfigFile)
        {
            _linhasConfig = File.ReadAllLines(pathConfigFile);

            PathConfigurationFile = pathConfigFile;
            NomeDoZIP = _linhasConfig[0].Substring(_linhasConfig[0].IndexOf('=') + 1);
            CaminhoDaPasta = _linhasConfig[2].Substring(_linhasConfig[2].IndexOf('=') + 1);
            PastasParaExcluir = _linhasConfig[4].Substring(20).Split('/');
            ArquivosParaExcluir = _linhasConfig[6].Substring(22).Split('/');
            PastasParaVerificar = _linhasConfig[8].Substring(22).Split('/');
            ArquivosParaVerificar = _linhasConfig[10].Substring(24).Split('/');
        }
    }
    
}
