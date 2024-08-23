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
    public partial class Frm_IndexUC : UserControl
    {
        public Frm_IndexUC()
        {
            InitializeComponent();
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
    }
}
}
