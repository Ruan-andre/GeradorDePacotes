using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;

namespace GeradorDePacotes
{
    public partial class Frm_IndexUC : UserControl
    {
        private ApplicationDbContext _context;
        public Frm_IndexUC()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void Chk_Inicializar_CheckedChanged(object sender, EventArgs e)
        {

            var chk_initialize = _context.ParKeys
                .AsEnumerable()
                .FirstOrDefault(x => x.ParName.Equals("chk_initialize", StringComparison.OrdinalIgnoreCase));

            if (chk_initialize == null)
            {
                var new_chk_initialize = new ParKey() { ParName = "chk_initialize", ParValue = Chk_Inicializar.Checked.ToString() };
                _context.ParKeys.Add(new_chk_initialize);
            }
            else
            {
                chk_initialize.ParValue = Chk_Inicializar.Checked.ToString();
            }
            _context.SaveChanges();

        }

        private void Frm_IndexUC_Load(object sender, EventArgs e)
        {
            Helpers.CenterPanel(Pnl_Content_IndexUC, Pnl_BtnGerar);
            UpdateChkInitialize();
        }

        private void UpdateChkInitialize()
        {
            var chk_initialize = _context.ParKeys.FirstOrDefault(x => x.ParName.Equals("chk_initialize"));
            if (!string.IsNullOrEmpty(chk_initialize?.ParValue))
            {
                Chk_Inicializar.Checked = Convert.ToBoolean(chk_initialize.ParValue);
            }
        }

        private void Btn_GerarPacote_Click(object sender, EventArgs e)
        {
            Btn_GerarPacote.Visible = false;
            Chk_Inicializar.Visible = false;
            Prg_Bar.Visible = true;
            
            int contador = 0;
            while (true)
            {
                if (contador < 50)
                {
                    Prg_Bar.Percentage++;
                    Prg_Bar.Refresh();
                    contador++;
                    Lbl_Progresso.Visible = true;
                    Lbl_Progresso.Text = "Gerando pacote, aguarde...";
                    Lbl_Progresso.Refresh();


                    if (contador < 50)
                        Thread.Sleep(50);

                    continue;
                }
                break;
            }
        }
    }
}
