using System.Data;
using System.Runtime.InteropServices;
using GeradorDePacotes.Classes;

namespace GeradorDePacotes
{
    public partial class Frm_Index : Form
    {
        public static bool sideBarExpanded { get; set; } = true;
        public static int sideBarWidth { get; set; }

        List<string> tempTextButtons = new List<string>();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Frm_Index()
        {
            InitializeComponent();
            ShowUserControl(new Frm_IndexUC());
        }

        private void Pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ShowUserControl(UserControl userControl)
        {
            foreach (Control item in Pnl_Principal.Controls)
                if (item.Name == userControl.Name)
                    return;

            if (Pnl_Principal.Controls.Count > 0)
                Pnl_Principal.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            Pnl_Principal.Controls.Add(userControl);
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
            var content = Pnl_Principal.Controls[0].Controls[0];


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

        void RemoveTextButtons()
        {

        }

      
        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_IndexUC());
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Configuracoes_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_ConfigUC(this));
        }

        private void Btn_Sobre_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_AboutUC());
        }

        private void Pnl_Principal_ControlAdded(object sender, ControlEventArgs e)
        {
            var content = Pnl_Principal.Controls[0].Controls[0];
            Helpers.CenterPanelSideBar(this, Flp_Sidebar, Pnl_Top, content, expandedBar: true);
        }
    }
}
