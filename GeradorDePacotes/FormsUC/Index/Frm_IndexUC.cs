using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using System.Diagnostics;
using System.Media;

namespace GeradorDePacotes
{
    public partial class Frm_IndexUC : UserControl
    {
        private readonly ApplicationDbContext _context;

        private CancellationTokenSource? _cancellationTokenSource;

        private Color _btnStartColor;

        private string _btnStartText;

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

            Btn_Start.Visible = false;
            Btn_Stop.Visible = true;
            Chk_AutoInitialize.Visible = false;
            Prg_Bar.Visible = true;
            if (!Btn_Start.Text.StartsWith("R"))
            {
                _btnStartColor = Btn_Start.BaseColor;
                _btnStartText = Btn_Start.Text;
            }
            Lbl_ProgressMsg.Visible = true;
            Lbl_ProgressMsg.ForeColor = default;
            Lbl_ProgressMsg.Text = "Gerando pacote, aguarde...";
            Pic_LoadingGIF.Visible = true;
            Lbl_ProgressMsg.Refresh();
            Thread.Sleep(500);

            _cancellationTokenSource = new CancellationTokenSource();
            Package package = new Package(Lbl_ProgressMsg, Prg_Bar, _cancellationTokenSource.Token);
            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                await Task.Run(package.GeneratePackage);
                Lbl_ProgressMsg.ForeColor = Color.DarkGreen;
                Lbl_ProgressMsg.Text = "Pacote gerado com sucesso!";
            }
            catch (AggregateException)
            {
                Lbl_ProgressMsg.ForeColor = Color.DarkRed;
                Lbl_ProgressMsg.Text = "Operação cancelada";
                Btn_Start.Text = "Reiniciar";
                Btn_Start.BaseColor = Color.Blue;
                Btn_Start.Visible = true;
                SystemSounds.Hand.Play();
                return;
            }

            Btn_Start.Text = _btnStartText;
            Btn_Start.BaseColor = _btnStartColor;

            Btn_Start.Visible = true;
            Btn_Stop.Visible = false;
            Pic_LoadingGIF.Visible = false;
            Chk_AutoInitialize.Visible = true;
            sw.Stop();
            var timeElapsed = $"Tempo gasto: {sw.ElapsedMilliseconds / 1000}";
            SystemSounds.Exclamation.Play();
            var parentFrm = ParentForm as Frm_Index;
            parentFrm?.PiscarNaBarraDeTarefas();
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

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

    }
}
