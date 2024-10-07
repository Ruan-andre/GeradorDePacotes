using GeradorDePacotes.Classes;

namespace GeradorDePacotes.Forms
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }

        private async void Frm_Report_Load(object sender, EventArgs e)
        {
            Helpers.CenterPanel(this, Pnl_Main);
            Helpers.CenterPanel(Pnl_Main, Btn_Close, 'x');
            Helpers.CenterPanel(Pnl_Main, Lbl_MessageAttetion, 'x');
            await Helpers.DataBindDataGridsAsync(new Database.ApplicationDbContext(), ctrl: Pnl_Main);
            Lbl_ItemsDeletedCount.Text += $" {Package.DeletedItemsCount}";
            Lbl_ItemsAddedCount.Text += $" {Zip.AddedItemsCount}";
            Lbl_ElapsedTime.Text += Frm_IndexUC.ElapsedTime;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
