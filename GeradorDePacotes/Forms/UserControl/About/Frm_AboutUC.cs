using System.Diagnostics;

namespace GeradorDePacotes
{
    public partial class Frm_AboutUC : UserControl
    {
        public Frm_AboutUC()
        {
            InitializeComponent();
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkTag = ((LinkLabel)sender).Tag?.ToString();
            string url = string.Empty;
            switch (linkTag)
            {
                case "codigofonte":
                    url = "https://github.com/Ruan-andre/GeradorDePacotes";
                    break;
                case "linkedin":
                    url = "https://linkedin.com/in/andré-ruan-554854250";
                    break;
                case "github":
                    url = "https://github.com/Ruan-andre";
                    break;
                case "portfolio":
                    url = "https://a-ruan-portfolio.vercel.app";
                    break;
                default:
                    break;
            }
            if (!string.IsNullOrWhiteSpace(url))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
    }
}
