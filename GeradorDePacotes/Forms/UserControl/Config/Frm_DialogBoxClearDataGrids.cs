using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;

namespace GeradorDePacotes.FormsUC.Config
{
    public partial class Frm_DialogBoxClearDataGrids : Form
    {
        private DataGridView[] _dataGridViews;
        private int _currentIndex;
        private Color _originalGridForeColor;
        private ApplicationDbContext _context;

        public Frm_DialogBoxClearDataGrids(ApplicationDbContext context, DataGridView[] Dts)
        {
            InitializeComponent();
            _dataGridViews = Dts;
            _originalGridForeColor = _dataGridViews[_currentIndex].ForeColor;
            _context = context;
        }

        private void Frm_DialogBoxClearDataGrids_Load(object sender, EventArgs e)
        {
            ChangeForeColorDt("next");
        }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        private void ChangeForeColorDt(string tag)
        {
            if (tag.Equals("next"))
            {
                // Next DataGrid
                _dataGridViews[_currentIndex].Parent.ForeColor = Color.Red;

                // Previous DataGrid
                if (_currentIndex == 0)
                    return;

                _dataGridViews[_currentIndex - 1].Parent.ForeColor = _originalGridForeColor;
            }
            else
            {
                // Next DataGrid
                _dataGridViews[_currentIndex].Parent.ForeColor = Color.Red;

                // Previous DataGrid
                if (_currentIndex == 4)
                    return;

                _dataGridViews[_currentIndex + 1].Parent.ForeColor = _originalGridForeColor;
            }
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        private void ChangeButtonsPreviousOrNext()
        {
            if (_currentIndex > 0)
            {
                Btn_PreviousDt.Enabled = true;
                Btn_PreviousDt.ForeColor = Color.White;
                Btn_PreviousDt.BackColor = Color.FromArgb(85, 155, 229);

            }
            else
            {
                Btn_PreviousDt.Enabled = false;
                Btn_PreviousDt.ForeColor = Color.Black;
                Btn_PreviousDt.BackColor = Color.DarkGray;
            }

            if (_currentIndex == _dataGridViews.Length - 1)
            {
                Btn_NextDt.Enabled = false;
                Btn_NextDt.ForeColor = Color.Black;
                Btn_NextDt.BackColor = Color.DarkGray;

            }
            else
            {
                Btn_NextDt.Enabled = true;
                Btn_NextDt.ForeColor = Color.White;
                Btn_NextDt.BackColor = Color.FromArgb(85, 155, 229);
            }
        }

        private void Btn_PreviousOrNextDt_Click(object sender, EventArgs e)
        {
            var btnTag = ((Button)sender)?.Tag?.ToString(); ;

            switch (btnTag)
            {
                case "previous":
                    if (_currentIndex >= 1)
                        _currentIndex--;

                    Lbl_DtName.Text = _dataGridViews[_currentIndex].Tag?.ToString();
                    ChangeButtonsPreviousOrNext();
                    ChangeForeColorDt(btnTag);
                    break;

                case "next":
                    if (_currentIndex < _dataGridViews.Length - 1)
                        _currentIndex++;

                    Lbl_DtName.Text = _dataGridViews[_currentIndex].Tag?.ToString();
                    ChangeButtonsPreviousOrNext();
                    ChangeForeColorDt(btnTag);
                    break;

                default:
                    break;
            }
            Lbl_Message.Visible = false;
        }

        private async void Btn_ClearCurrentDt_Click(object sender, EventArgs e)
        {
            var dtName = _dataGridViews[_currentIndex].Name.Replace("Dt_", "");

            await UtilDb.ClearTableAsync(_context, dtName);
            await Helpers.DataBindDataGridsAsync(_context, _dataGridViews[_currentIndex]);
            Lbl_Message.Visible = true;
        }

        private void Frm_DialogBoxClearDataGrids_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in _dataGridViews)
            {
                item.Parent.ForeColor = _originalGridForeColor;
                item.ForeColor = _originalGridForeColor;
                item.Refresh();
            }
        }

        private async void Btn_ClearAllDt_Click(object sender, EventArgs e)
        {
            foreach (var item in _dataGridViews)
            {
                await UtilDb.ClearTableAsync(_context, item.Name.Replace("Dt_", ""));
                await Helpers.DataBindDataGridsAsync(_context, item);
            }

            Lbl_Message.Visible = true;
            Lbl_Message.Text = "Todas as tabelas foram limpas com sucesso!";
        }
    }
}
