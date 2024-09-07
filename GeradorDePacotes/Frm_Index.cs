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

        private Control _fixedUserControl;

        private Control firstControl;

        private ApplicationDbContext _context;
        public Frm_Index()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            ShowUserControl(new Frm_IndexUC(_context));
            _currentUserControl = 0;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ShowUserControl(Control userControl)
        {

            if (firstControl == null)
            {
                firstControl = userControl;
                userControl.Dock = DockStyle.Fill;
                Pnl_Principal.Controls.Add(userControl);
                return;
            }

            if (Pnl_Principal.Controls.ContainsKey(userControl.Name) && userControl.Name.Equals(firstControl.Name))
            {
                foreach (Control control in Pnl_Principal.Controls)
                {
                    control.Hide();
                }
                firstControl.Show();
                firstControl.BringToFront();
                return;
            }

            foreach (Control control in Pnl_Principal.Controls)
            {
                if (!userControl.Name.Equals(control.Name))
                    control.Hide();
            }

            userControl.Dock = DockStyle.Fill;
            var ctrlInPnl = Pnl_Principal.Controls.Find(userControl.Name, true).FirstOrDefault();

            if (ctrlInPnl == null)
            {
                Pnl_Principal.Controls.Add(userControl);
                userControl.Show();
            }
            else
            {
                ctrlInPnl.Show();
            }
            
        }

        private void HideAllControls()
        {
            foreach (Control control in Pnl_Principal.Controls)
            {
                control.Hide();
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

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_IndexUC(_context));
            _currentUserControl = 0;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Configuracoes_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_ConfigUC(_context, this));
            _currentUserControl = 1;
        }

        private void Btn_Sobre_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_AboutUC());
            _currentUserControl = 2;
        }

        private void Pnl_Principal_ControlAdded(object sender, ControlEventArgs e)
        {
            var controls = Pnl_Principal.Controls[_currentUserControl].Controls;
            var content = GetMainPanel(controls);
            Helpers.CenterPanelSideBar(this, Flp_Sidebar, Pnl_Top, content!, expandedBar: true);
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
