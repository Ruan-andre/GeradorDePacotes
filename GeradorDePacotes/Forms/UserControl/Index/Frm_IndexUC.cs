using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using System.Text;

namespace GeradorDePacotes
{
    public partial class Frm_IndexUC : UserControl
    {
        private readonly ApplicationDbContext _context;

        private CancellationTokenSource? _cancellationTokenSource;

        private Color _btnStartColor;

        private string _btnStartText;

        public static string? ElapsedTime { get; private set; }

        public Frm_IndexUC()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
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
            if (!CheckConfig())
                return;

            if (Pnl_ContentUC.Height >= 383)
                Pnl_ContentUC.Height -= 100;
            else if(Pnl_ContentUC.Height < 352)
                Pnl_ContentUC.Height += 69;

            Btn_Start.Visible = false;
            Btn_Stop.Visible = true;
            Chk_AutoInitialize.Visible = false;
            Btn_Report.Visible = false;
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
            catch (AggregateException ex)
            {
                Lbl_ProgressMsg.ForeColor = Color.DarkRed;
                Btn_Start.Text = "Reiniciar";
                Btn_Start.BaseColor = Color.Blue;
                Btn_Start.Visible = true;

                if (ex.InnerExceptions.OfType<OperationCanceledException>().Any())
                {
                    Lbl_ProgressMsg.Text = "Operação cancelada pelo usuário.";
                    SystemSounds.Hand.Play();
                    return;
                }
                else
                {
                    Lbl_ProgressMsg.Text = "Ocorreu um erro durante a operação.";
                    MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Btn_Start.Text = _btnStartText;
            Btn_Start.BaseColor = _btnStartColor;

            Btn_Start.Visible = true;
            Btn_Stop.Visible = false;
            Pic_LoadingGIF.Visible = false;
            Lkl_OpenFolder.Visible = true;
            Chk_AutoInitialize.Visible = true;
            sw.Stop();
            Btn_Report.Visible = true;
            Pnl_ContentUC.Height += 100;

            ElapsedTime = $"{sw.Elapsed.TotalMinutes.ToString("F2", CultureInfo.InvariantCulture)} minutos";
            SystemSounds.Exclamation.Play();
            ((Frm_Index)ParentForm!).PiscarNaBarraDeTarefas();
        }

        private bool CheckConfig()
        {
            var sb = new StringBuilder();
            var TargetFolder = UtilDb.GetParValueAsync(_context, "target_folder");
            var SameOutputFolder = UtilDb.GetParValueAsync(_context, "same_output_folder");
            var OutputFolder = UtilDb.GetParValueAsync(_context, "output_folder");
            Task.WhenAll(TargetFolder, SameOutputFolder, OutputFolder);


            if (string.IsNullOrEmpty(TargetFolder.Result))
                sb.AppendLine("O diretório da pasta alvo não está preenchido!");

            if (!string.IsNullOrEmpty(SameOutputFolder.Result))
            {
                var isChecked = Convert.ToBoolean(SameOutputFolder.Result);

                if (!isChecked && string.IsNullOrEmpty(OutputFolder.Result))
                    sb.Append("O diretório da pasta saída não está preenchido!");
            }

            if (sb.Length > 0)
            {
                sb.AppendLine("\n\nAcesse a aba CONFIGURAÇÕES para resolver os problemas citados acima.");
                MessageBox.Show(sb.ToString(), "Importante!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            var frm = new Frm_Report();
            frm.ShowDialog();
        }

        private async void Lkl_OpenFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var folder = await UtilDb.GetParValueAsync(_context, "output_folder");
            Process.Start(new ProcessStartInfo
            {
                FileName = folder,
                UseShellExecute = true
            });
        }

        private void Chk_AutoInitialize_Click(object sender, EventArgs e)
        {
            if (!CheckConfig())
            {
                Chk_AutoInitialize.Checked = false;
                return;
            }
        }
    }
}
