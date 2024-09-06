using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcluirArquivosPublicacao.Services
{
    class ProgressBar : IDisposable
    {
        private const int ProgressBarWidth = 50;
        private const char ProgressBarCharacter = '■';
        private const char SpaceCharacter = ' ';

        public void Update(int progressPercentage)
        {
            double percentage = progressPercentage / 100.0;
            int completed = (int)(percentage * ProgressBarWidth);

            Console.Write("\r                              [");
            Console.Write(new string(ProgressBarCharacter, completed));
            Console.Write(new string(SpaceCharacter, ProgressBarWidth - completed));
            Console.Write($"] {progressPercentage}%");
        }

        public void Dispose()
        {
            Console.WriteLine();
        }
    }
}
