using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using System.Configuration;
using System.Diagnostics;

namespace GeradorDePacotes
{
    public partial class Frm_IndexUC : UserControl
    {
        private ApplicationDbContext _context;

        public Frm_IndexUC(ApplicationDbContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private async void Chk_Inicializar_CheckedChanged(object sender, EventArgs e)
        {
            await UtilDb.AddOrUpdateTableParKeysAsync(_context, "chk_initialize", Chk_AutoInitialize.Checked.ToString());
        }

        private void Frm_IndexUC_Load(object sender, EventArgs e)
        {

            FillChkInitialize();
            CheckInitialize();
        }

        private async void FillChkInitialize()
        {
            var parValue = await UtilDb.GetParValueAsync(_context, "chk_initialize");

            if (!string.IsNullOrEmpty(parValue))
            {
                Chk_AutoInitialize.Checked = Convert.ToBoolean(parValue);
            }
            else
            {
                Chk_AutoInitialize.Checked = false;
            }
        }

        private async void Btn_GerarPacote_Click(object sender, EventArgs e)
        {

            //var configuration = GetConfiguration();

            Stopwatch sw = Stopwatch.StartNew();
            Btn_Start.Visible = false;
            Btn_Stop.Visible = true;
            Chk_AutoInitialize.Visible = false;
            Prg_Bar.Visible = true;

            Lbl_Progress.Visible = true;
            Lbl_Progress.Text = "Gerando pacote, aguarde...";
            Lbl_Progress.Refresh();

            
            Package package = new Package();
            



            Btn_Start.Visible = true;
            Btn_Stop.Visible = false;
            Chk_AutoInitialize.Visible = true;
            sw.Stop();
            TimeSpan tempoTotal = sw.Elapsed;
        }

        private async void GetConfiguration()
        {
            var NameFile = UtilDb.GetParValueAsync(_context, "");
        }

        private void ProcessarPacote()
        {
            int contador = 0;
            Prg_Bar.Percentage = 0;
            Lbl_Progress.ForeColor = default;
            // Simulando o processo com um contador
            while (contador < 100)
            {
                // Atualiza a barra de Progress e faz uma pausa
                this.Invoke(new Action(() =>
                {
                    Prg_Bar.Percentage++;
                    Prg_Bar.Refresh();
                }));

                // Simula o tempo de processamento
                Thread.Sleep(50);
                contador++;
            }

            // Quando o processo terminar, atualizar o label na UI thread
            this.Invoke(new Action(() =>
            {
                Lbl_Progress.Text = "Pacote gerado com sucesso!";
                Lbl_Progress.ForeColor = Color.Green;
            }));
        }

        private async void CheckInitialize()
        {
            var parValue = await UtilDb.GetParValueAsync(_context, "first_initializing");
            bool firstInitializing = true;

            if (parValue != null)
                firstInitializing = Convert.ToBoolean(parValue);
            else
                await UtilDb.AddOrUpdateTableParKeysAsync(_context, "first_initializing", "true");

            if (Chk_AutoInitialize.Checked && firstInitializing)
                Btn_GerarPacote_Click(null!, null!);

            await UtilDb.AddOrUpdateTableParKeysAsync(_context, "first_initializing", "false");
            
        }
    }
}
