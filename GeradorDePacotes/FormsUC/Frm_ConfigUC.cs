using GeradorDePacotes.FormsUC;
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
    public partial class Frm_ConfigUC : UserControl
    {
        public Frm_ConfigUC()
        {
            InitializeComponent();
            Cmb_Formatos.SelectedIndex = 0;
        }

        private void Btn_ExploreFolders_Click(object sender, EventArgs e)
        {
            Fbd_Config.ShowDialog();
            Txt_TargetFolder.Text = Fbd_Config.SelectedPath;
        }

    }
}
