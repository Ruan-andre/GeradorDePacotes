using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GeradorDePacotes
{
    public partial class Frm_Index : Form
    {
        bool sideBarExpand = true;
        bool arrowExpand = true;

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
            Pnl_Principal.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Pnl_Principal.Controls.Add(userControl);
        }

        private void Pic_ExpandirMenu_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
            Pic_ExpandirMenu.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Pic_ExpandirMenu.Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Gerar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                if (Flp_sidebar.Width == 52)
                    Flp_sidebar.Width -= 8;
                else
                    Flp_sidebar.Width -= 10;

                if (Flp_sidebar.Width <= 44)
                {
                    Pic_Logo.Visible = false;
                    sideBarExpand = false;
                    SidebarTransition.Stop();
                }
            }
            else
            {
                if (Flp_sidebar.Width == 224)
                    Flp_sidebar.Width += 8;
                else
                    Flp_sidebar.Width += 10;

                if (Flp_sidebar.Width >= 232)
                {
                    Pic_Logo.Visible = true;
                    sideBarExpand = true;
                    SidebarTransition.Stop();
                }
            }

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

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Frm_IndexUC());
        }
    }
}
