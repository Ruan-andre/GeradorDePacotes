
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
