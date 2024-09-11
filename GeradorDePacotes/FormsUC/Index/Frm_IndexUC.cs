using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using System.Diagnostics;

namespace GeradorDePacotes
{
    public partial class Frm_IndexUC : UserControl
    {
        private readonly ApplicationDbContext _context;

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

            Btn_Start.Visible = false;
            Btn_Stop.Visible = true;
            Chk_AutoInitialize.Visible = false;
            Prg_Bar.Visible = true;

            Lbl_ProgressMsg.Visible = true;
            Lbl_ProgressMsg.Text = "Gerando pacote, aguarde...";
            Lbl_ProgressMsg.Refresh();
            Thread.Sleep(500);

            Package package = new Package(_context, Lbl_ProgressMsg, Prg_Bar);
            Stopwatch sw = Stopwatch.StartNew();
            package.GeneratePackage();

            Btn_Start.Visible = true;
            Btn_Stop.Visible = false;
            Chk_AutoInitialize.Visible = true;
            sw.Stop();
            TimeSpan tempoTotal = sw.Elapsed;
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

        private void Lbl_ProgressMsg_TextChanged(object sender, EventArgs e)
        {
            if (Lbl_ProgressMsg.Equals("Erro"))
                Lbl_ProgressMsg.ForeColor = Color.Red;

            Lbl_ProgressMsg.Refresh();
        }

        private void Prg_Bar_PercentageChanged(object sender, EventArgs e)
        {
            Prg_Bar.Refresh();
        }
    }
}
