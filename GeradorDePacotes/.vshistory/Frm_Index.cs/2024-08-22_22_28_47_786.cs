using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDePacotes
{
    public partial class Frm_Index : Form
    {
        bool sideBarExpand = true;
        public Frm_Index()
        {
            InitializeComponent();
            //Pic_ExpandirMenu.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void Pic_ExpandirMenu_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
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
                Flp_sidebar.Width -= 15;
                if (Flp_sidebar.Width <= 44)
                {
                    Pic_Logo.Visible = false;
                    sideBarExpand = false;
                    SidebarTransition.Stop();
                }
            }
            else
            {
                Flp_sidebar.Width += 10;
                if (Flp_sidebar.Width >= 232)
                {
                    Pic_Logo.Visible = true;
                    sideBarExpand = true;
                    SidebarTransition.Stop();
                }
            }

        }
    }
}
