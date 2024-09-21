using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;

namespace GeradorDePacotes
{
    public partial class Frm_Index : Form
    {
        public static bool sideBarExpanded { get; set; } = true;
        public static int sideBarWidth { get; set; }

        List<string> tempTextButtons = new List<string>();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        private int _currentUserControl;

        private ApplicationDbContext _context;

        private Dictionary<int, UserControl> _dicUsersControl = new Dictionary<int, UserControl>();
        public Frm_Index()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            ShowUserControl(0, new Frm_IndexUC(_context));
        }

        // PERSONALIZED

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [StructLayout(LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public uint cbSize;        // Tamanho da estrutura
            public IntPtr hwnd;        // Handle da janela
            public uint dwFlags;       // Opções de piscar
            public uint uCount;        // Número de vezes que piscará
            public uint dwTimeout;     // Velocidade do piscar (em milissegundos)
        }

        // Importação da função FlashWindowEx da user32.dll
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        // Flags de controle para o comportamento do FlashWindowEx
        private const uint FLASHW_STOP = 0;      // Para de piscar
        private const uint FLASHW_CAPTION = 1;   // Pisca apenas o título da janela
        private const uint FLASHW_TRAY = 2;      // Pisca apenas a barra de tarefas
        private const uint FLASHW_ALL = 3;       // Pisca tanto o título quanto a barra de tarefas
        private const uint FLASHW_TIMER = 4;     // Pisca até que o usuário traga a janela para frente
        private const uint FLASHW_TIMERNOFG = 12;// Pisca até que a janela receba foco

        // Método para fazer a janela piscar na barra de tarefas
        public void PiscarNaBarraDeTarefas()
        {
            FLASHWINFO fw = new FLASHWINFO();

            fw.cbSize = Convert.ToUInt32(Marshal.SizeOf(fw)); // Tamanho da estrutura
            fw.hwnd = this.Handle;  // Handle da janela (formulário atual)
            fw.dwFlags = FLASHW_TRAY | FLASHW_TIMERNOFG; // Piscar na barra de tarefas até que a janela tenha foco
            fw.uCount = uint.MaxValue; // Piscar indefinidamente
            fw.dwTimeout = 0; // Padrão de tempo de piscada (usa o padrão do sistema)
            FlashWindowEx(ref fw);
        }


        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            // Parar de piscar quando a janela é ativada
            FLASHWINFO fw = new FLASHWINFO();
            fw.cbSize = Convert.ToUInt32(Marshal.SizeOf(fw));
            fw.hwnd = this.Handle;
            fw.dwFlags = FLASHW_STOP; // Para o piscar
            fw.uCount = 0;
            fw.dwTimeout = 0;

            FlashWindowEx(ref fw);
        }


        private static Control? GetMainPanel(Control.ControlCollection controls)
        {
            Control? content = null;
            foreach (Control item in controls)
            {
                var tag = item.Tag?.ToString();
                if (!string.IsNullOrEmpty(tag) && tag.Equals("main", StringComparison.OrdinalIgnoreCase))
                {
                    content = item;
                    break;
                }
            }

            return content;
        }

        private void ChageButtonsText()
        {
            if (tempTextButtons.Count <= 0)
            {
                tempTextButtons.Add(Btn_inicio.Text);
                tempTextButtons.Add(Btn_Configuracoes.Text);
                tempTextButtons.Add(Btn_Sobre.Text);
                tempTextButtons.Add(Btn_Exit.Text);
            }
            if (sideBarExpanded)
            {
                Btn_inicio.Text = tempTextButtons
                    .Where(x => x.Contains("Início", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                Btn_Configuracoes.Text = tempTextButtons
                    .Where(x => x.Contains("Configurações", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                Btn_Sobre.Text = tempTextButtons
                    .Where(x => x.Contains("Sobre", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                Btn_Exit.Text = tempTextButtons
                    .Where(x => x.Contains("Sair", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            else
            {
                Btn_inicio.Text = string.Empty;
                Btn_Configuracoes.Text = string.Empty;
                Btn_Sobre.Text = string.Empty;
                Btn_Exit.Text = string.Empty;
            }

        }

        private void ShowUserControl(int idUC, UserControl uc)
        {
            var exists = _dicUsersControl.ContainsKey(idUC);
            if (!exists)
            {
                HideAllControls();
                _dicUsersControl.Add(idUC, uc);
                uc.Dock = DockStyle.Fill;
                Pnl_Principal.Controls.Add(uc);
                Helpers.CenterPanelSideBar(this, Flp_Sidebar, Pnl_Top, uc.Controls[0], sideBarExpanded);
            }
            else
            {
                UserControl ucDic = _dicUsersControl[_currentUserControl];
                if (uc.Name.Equals(ucDic.Name))
                    return;

                HideAllControls();
                _dicUsersControl[idUC].Show();
                Helpers.CenterPanelSideBar(this, Flp_Sidebar, Pnl_Top, _dicUsersControl[idUC].Controls[0], sideBarExpanded);
            }
        }

        private void HideAllControls()
        {
            foreach (Control control in Pnl_Principal.Controls)
                control.Hide();
        }


        //EVENTS
        private void Pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        internal void Pic_ExpandirMenu_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
            Pic_ExpandirMenu.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Pic_ExpandirMenu.Refresh();
        }

        private void Pic_ExpandirMenu_MouseHover(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;
            pic.BackColor = Color.FromArgb(33, 33, 33, 51);
        }

        private void Pic_ExpandirMenu_MouseLeave(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;
            pic.BackColor = Color.FromArgb(198, 172, 143);
        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            var controls = Pnl_Principal.Controls[_currentUserControl].Controls;
            Control? content = GetMainPanel(controls);


            if (sideBarExpanded)
            {

                if (Flp_Sidebar.Width == 50)
                {
                    Flp_Sidebar.Width -= 6;
                    Pnl_Exit.Width -= 6;
                }
                else
                {
                    Flp_Sidebar.Width -= 10;
                    Pnl_Exit.Width -= 10;
                }
                if (Flp_Sidebar.Width <= 44)
                {
                    Helpers.CenterPanelSideBar(this, Flp_Sidebar, Pnl_Top, content, expandedBar: false);
                    Pic_Logo.Visible = false;
                    sideBarExpanded = false;
                    SidebarTransition.Stop();
                    ChageButtonsText();
                }
            }
            else
            {
                if (Flp_Sidebar.Width == 184)
                {
                    Flp_Sidebar.Width += 6;
                    Pnl_Exit.Width += 6;
                }
                else
                {
                    Flp_Sidebar.Width += 10;
                    Pnl_Exit.Width += 10;
                }
                if (Flp_Sidebar.Width >= 190)
                {
                    Helpers.CenterPanelSideBar(this, Flp_Sidebar, Pnl_Top, content, expandedBar: true);
                    Pic_Logo.Visible = true;
                    sideBarExpanded = true;
                    SidebarTransition.Stop();
                    ChageButtonsText();
                }
            }

        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            ShowUserControl(0, new Frm_IndexUC(_context));
            _currentUserControl = 0;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Configuracoes_Click(object sender, EventArgs e)
        {
            ShowUserControl(1, new Frm_ConfigUC(_context, this));
            _currentUserControl = 1;
        }

        private void Btn_Sobre_Click(object sender, EventArgs e)
        {
            ShowUserControl(2, new Frm_AboutUC());
            _currentUserControl = 2;
        }

        private void Btn_MinimizeApplication_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_CloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Frm_Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            await UtilDb.AddOrUpdateTableParKeysAsync(_context, "first_initializing", "true");
        }

    }
}
