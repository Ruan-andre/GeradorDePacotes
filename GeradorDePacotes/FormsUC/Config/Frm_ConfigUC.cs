
using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;
using GeradorDePacotes.FormsUC.Config;
using System.Windows.Forms;

namespace GeradorDePacotes
{
    public partial class Frm_ConfigUC : UserControl
    {
        private ApplicationDbContext _context;

        private bool _initializing = true;

        private Frm_Index _parentForm;

        private object? _cachedName;

        public static string PathTargetFolder { get; private set; }

        public Frm_ConfigUC(ApplicationDbContext ctx, Frm_Index parentForm)
        {
            InitializeComponent();
            _context = ctx;
            _parentForm = parentForm;
        }

        //Events

        private void Frm_ConfigUC_Load(object sender, EventArgs e)
        {
            FillOwnControls();
            ExpandOrContractPnlsConfig(Chb_SameOutputFolder.Checked);
            _initializing = false;
            if (_parentForm != null && Frm_Index.sideBarExpanded)
                _parentForm.Pic_ExpandirMenu_Click(this, EventArgs.Empty);

            PathTargetFolder = Txt_TargetFolder.Text;

            ShowOrHideImgMsg();
        }

        private void ShowOrHideImgMsg()
        {
            var visible = (string.IsNullOrWhiteSpace(Txt_TargetFolder.Text)
                           && Chb_SameOutputFolder.Checked == true)
                           || (Chb_SameOutputFolder.Checked == false
                                && (string.IsNullOrWhiteSpace(Txt_TargetFolder.Text)
                                    || string.IsNullOrWhiteSpace(Txt_OutputFolder.Text))) ? false : true;

            var PnlsToHide = Pnl_ContentConfig.Controls;

            foreach (Control item in PnlsToHide)
            {
                if (item.Tag?.ToString() == "hide")
                {
                    item.Visible = visible;
                }
            }
            Pic_Msg_Fields.Visible = !visible;
        }

        private void Txt_OutputFile_Leave(object sender, EventArgs e)
        {

            if (IsFileNameValid(Txt_OutputFile.Text))
            {
                var fileNameLog = _context.FileNameOutputLogs
                    .AsEnumerable()
                    .FirstOrDefault(x => x.NameFile.Equals(Txt_OutputFile.Text));

                if (fileNameLog != null)
                    return;

                var newFileNameLog = new FileNameOutputLogs
                {
                    NameFile = Txt_OutputFile.Text
                };
                _context.FileNameOutputLogs.Add(newFileNameLog);
                _context.SaveChanges();
            }
        }

        private async void Txt_TargetFolder_Leave(object sender, EventArgs e)
        {
            if (!Helpers.IsDirectoryValid(Txt_TargetFolder.Text))
            {
                Txt_TargetFolder.Text = await UtilDb.GetParValueAsync(_context, "target_folder");
                ShowOrHideImgMsg();
                return;
            }

            AddPathFolder(Txt_TargetFolder, "target_folder");

            ShowOrHideImgMsg();
        }

        private async void Cmb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            if (Cmb_Formatos.SelectedItem != null)
            {
                await UtilDb.AddOrUpdateTableParKeysAsync(_context, "file_format", Cmb_Formatos.SelectedItem.ToString()!);
            }
        }

        private async void Chb_AddDateHourToName_CheckedChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            if (Cmb_Formatos.SelectedItem != null)
            {
                await UtilDb.AddOrUpdateTableParKeysAsync(_context, "add_hour_and_date_to_name", Chb_AddDateHourToName.Checked.ToString()!);
            }
        }



        private async void Chb_SameOutputFolder_CheckedChanged(object sender, EventArgs e)
        {
            ExpandOrContractPnlsConfig(Chb_SameOutputFolder.Checked);

            if (_initializing) return;

            await UtilDb.AddOrUpdateTableParKeysAsync(_context, "same_output_folder", Chb_SameOutputFolder.Checked.ToString());


        }
        private void Txt_OutputFolder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_OutputFolder.Text)) return;
            AddPathFolder(Txt_OutputFolder, "output_folder");
        }
        private void Btn_ExploreTargetFolders_Click(object sender, EventArgs e)
        {
            Fbd_ConfigUC.Description = "Escolha a pasta onde estão os arquivos do seu projeto";
            if (Txt_TargetFolder.Text != null)
                Fbd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;

            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel || !Helpers.IsDirectoryValid(Fbd_ConfigUC.SelectedPath))
                return;

            Txt_TargetFolder.Text = Fbd_ConfigUC.SelectedPath;
            AddPathFolder(Txt_TargetFolder, "target_folder");
            ShowOrHideImgMsg();
        }
        private void Btn_ExploreOutputFolder_Click(object sender, EventArgs e)
        {
            Fbd_ConfigUC.Description = "Escolha a pasta onde será salvo o pacote";
            if (Txt_OutputFolder.Text != null)
                Fbd_ConfigUC.InitialDirectory = Txt_OutputFolder.Text;

            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel || !Helpers.IsDirectoryValid(Fbd_ConfigUC.SelectedPath))
                return;

            Txt_OutputFolder.Text = Fbd_ConfigUC.SelectedPath;
            AddPathFolder(Txt_OutputFolder, "output_folder");
        }

        private async void Pic_AddFolderToDelete_Click(object sender, EventArgs e)
        {
            Fbd_ConfigUC.Description = "Selecione a pasta que será adicionada à lista de exclusões";
            Fbd_ConfigUC.UseDescriptionForTitle = true;

            if (!VerifyPathTargetFolder()) return;

            Fbd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFoldersToDeleteAsync(_context, Fbd_ConfigUC.SelectedPath, Txt_TargetFolder.Text);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FoldersToDelete);
        }

        private async void Pic_AddFileToDelete_Click(object sender, EventArgs e)
        {

            if (!VerifyPathTargetFolder()) return;

            Fd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            Fd_ConfigUC.Title = "Selecione o(s) arquivo(s) para serem adicionado(s) à lista de exclusões";
            if (Fd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFilesToDeleteAsync(_context, Fd_ConfigUC.FileNames);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FilesToDelete);
        }

        private async void Pic_AddFolderToVerify_Click(object sender, EventArgs e)
        {

            if (!VerifyPathTargetFolder()) return;

            Fbd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            Fbd_ConfigUC.Description = "Selecione a pasta que será adicionada à lista de verificação";
            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFoldersToVerifyAsync(_context, Fbd_ConfigUC.SelectedPath);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FoldersToVerify);
        }

        private async void Pic_AddFileToVerify_Click(object sender, EventArgs e)
        {
            if (!VerifyPathTargetFolder()) return;

            Fd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            Fd_ConfigUC.Title = "Selecione o(s) arquivo(s) para serem adicionado(s) à lista de verificação";

            if (Fd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFilesToVerifyAsync(_context, Fd_ConfigUC.FileNames);

            await Helpers.DataBindDataGridsAsync(_context, Dt_FilesToVerify);
        }

        private async void CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            var dt = (DataGridView)sender;
            var idItem = (int)dt.Rows[e.RowIndex].Cells[3].Value;
            var dtName = dt.Name.Replace("Dt_", "");
            var cell = dt[e.ColumnIndex, e.RowIndex];

            var name = dt.Rows[e.RowIndex].Cells[0].Value;

            if (name == null)
            {
                cell.Value = _cachedName;
                return;
            }

            switch (dt.Name.Replace("Dt_", ""))
            {
                case "FoldersToDelete":
                    await UtilDb.AddOrUpdateTableFoldersToDeleteAsync(_context, name.ToString(), idItem);
                    break;

                case "FilesToDelete":
                    await UtilDb.AddOrUpdateTableFilesToDeleteAsync(_context, name.ToString(), idItem);
                    break;

                case "FoldersToVerify":
                    await UtilDb.AddOrUpdateTableFoldersToVerifyAsync(_context, name.ToString(), idItem);
                    break;

                case "FilesToVerify":
                    await UtilDb.AddOrUpdateTableFilesToVerifyAsync(_context, name.ToString(), idItem);
                    break;
                default:
                    break;
            }
        }

        private void CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;
            if (e.ColumnIndex == dt.Columns[2].Index && e.RowIndex >= 0)
                dt.Cursor = Cursors.Hand;
        }

        private void CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;
            if (e.ColumnIndex == dt.Columns[2].Index && e.RowIndex >= 0)
                dt.Cursor = Cursors.Default;
        }
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;

            if (e.ColumnIndex == dt.Columns[1].Index && e.RowIndex >= 0)
            {
                SwitchDtCheckBox(e, dt);
                dt.EndEdit();
            }
        }

        private async void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;

            if (e.ColumnIndex == dt.Columns[2].Index && e.RowIndex >= 0)
            {
                await SwitchDtDeleteRows(e, dt);
                await Helpers.DataBindDataGridsAsync(_context, dt);
            }
        }



        //Personalized
        private bool IsFileNameValid(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return false;

            char[] invalidChars = Path.GetInvalidFileNameChars();

            if (fileName.Any(ch => invalidChars.Contains(ch)))
                return false;

            return true;
        }
        private void ExpandOrContractPnlsConfig(bool check)
        {

            if (!check)
            {
                Tlp_Content.RowStyles[0].Height += 45;
                Tlp_Content.Height += 45;
                Chb_AddDateHourToName.Location = new Point(13, 90);
                Cmb_Formatos.Location = new Point(10, 137);
                Txt_OutputFolder.Visible = true;
                Btn_ExploreOutputFolder.Visible = true;
                Btn_ClearTables.Location = new Point(292, 705);
                Pnl_ContentConfig.Height = 760;
            }
            else
            {
                Tlp_Content.RowStyles[0].Height = 133;
                Tlp_Content.RowStyles[1].Height = 260;
                Tlp_Content.RowStyles[2].Height = 260;

                Chb_AddDateHourToName.Location = new Point(9, 95);
                Cmb_Formatos.Location = new Point(310, 95);
                Txt_OutputFolder.Visible = false;
                Btn_ExploreOutputFolder.Visible = false;
                Tlp_Content.Height = 654;
                Btn_ClearTables.Location = new Point(292, 666);
                Pnl_ContentConfig.Height = 700;
            }

        }
        private async void FillOwnControls()
        {
            #region["Pnl_OutputFile"]

            var lastFileName = _context.FileNameOutputLogs
                                    .AsEnumerable()
                                    .OrderByDescending(x => x.Id)
                                    .Take(1)
                                    .Select(x => x.NameFile)
                                    .FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(lastFileName))
                Txt_OutputFile.Text = lastFileName;

            var chbAddDateHour = await UtilDb.GetParValueAsync(_context, "add_hour_and_date_to_name");
            if (!string.IsNullOrWhiteSpace(chbAddDateHour))
                Chb_AddDateHourToName.Checked = Convert.ToBoolean(chbAddDateHour);

            var cmbFileFormat = await UtilDb.GetParValueAsync(_context, "file_format");
            if (!string.IsNullOrWhiteSpace(cmbFileFormat))
                Cmb_Formatos.SelectedItem = cmbFileFormat;

            #endregion

            #region["Pnl_TargetFolder"]

            var txtTargetFolder = await UtilDb.GetParValueAsync(_context, "target_folder");
            if (!string.IsNullOrWhiteSpace(txtTargetFolder))
                Txt_TargetFolder.Text = txtTargetFolder;

            var chbSameFolder = await UtilDb.GetParValueAsync(_context, "same_output_folder");
            if (!string.IsNullOrWhiteSpace(chbSameFolder))
                Chb_SameOutputFolder.Checked = Convert.ToBoolean(chbSameFolder);

            var txtOutputFolder = await UtilDb.GetParValueAsync(_context, "output_folder");
            if (!string.IsNullOrWhiteSpace(txtOutputFolder))
                Txt_OutputFolder.Text = txtOutputFolder;

            #endregion

            await Helpers.DataBindDataGridsAsync(_context, ctrl: this);
        }
        private async void AddPathFolder(TextBox ctrl, string parName)
        {
            if (!Helpers.IsDirectoryValid(ctrl))
                return;

            await UtilDb.AddOrUpdateTableParKeysAsync(_context, parName, ctrl.Text);
            PathTargetFolder = ctrl.Text;
        }

        private async void SwitchDtCheckBox(DataGridViewCellEventArgs e, DataGridView dt)
        {
            var idItem = (int)dt.Rows[e.RowIndex].Cells[3].Value;
            DataGridViewCell cell = dt[e.ColumnIndex, e.RowIndex];
            bool currentValue = (bool)cell.Value;
            cell.Value = !currentValue;
            var newValue = !currentValue;
            switch (dt.Name.Replace("Dt_", ""))
            {
                case "FoldersToDelete":
                    await UtilDb.AddOrUpdateTableFoldersToDeleteAsync(_context, disconsider: newValue, id: idItem);
                    break;

                case "FilesToDelete":
                    await UtilDb.AddOrUpdateTableFilesToDeleteAsync(_context, disconsider: newValue, id: idItem);
                    break;

                case "FoldersToVerify":
                    await UtilDb.AddOrUpdateTableFoldersToVerifyAsync(_context, disconsider: newValue, id: idItem);
                    break;

                case "FilesToVerify":
                    await UtilDb.AddOrUpdateTableFilesToVerifyAsync(_context, disconsider: newValue, id: idItem);
                    break;
                default:
                    break;
            }
        }
        private async Task SwitchDtDeleteRows(DataGridViewCellEventArgs e, DataGridView dt)
        {
            var id = (int)dt.Rows[e.RowIndex].Cells[3].Value;
            switch (dt.Name.Replace("Dt_", ""))
            {
                case "FoldersToDelete":
                    await UtilDb.DeleteAsync<FoldersToDelete>(_context, "FoldersToDelete", id);
                    break;

                case "FilesToDelete":
                    await UtilDb.DeleteAsync<FilesToDelete>(_context, "FilesToDelete", id);
                    break;

                case "FoldersToVerify":
                    await UtilDb.DeleteAsync<FoldersToVerify>(_context, "FoldersToVerify", id);
                    break;

                case "FilesToVerify":
                    await UtilDb.DeleteAsync<FilesToVerify>(_context, "FilesToVerify", id);
                    break;
                default:
                    break;
            }
        }

        private void CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var dt = (DataGridView)sender;
            var cellContent = dt[e.ColumnIndex, e.RowIndex].Value;
            _cachedName = cellContent;
        }

        private bool VerifyPathTargetFolder()
        {
            if (string.IsNullOrWhiteSpace(Txt_TargetFolder.Text))
            {
                MessageBox.Show("O caminho da pasta alvo está vázio, por favor, preencha-o", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_TargetFolder.Focus();
                return false;
            }
            return true;
        }

        private void Btn_ClearTables_Click(object sender, EventArgs e)
        {
            var dataGrids = Helpers.GetAllControlsOfType<DataGridView>(Pnl_ContentConfig).ToArray();
            Array.Reverse(dataGrids);
            var dialogBox = new Frm_DialogBoxClearDataGrids(_context, dataGrids);
            dialogBox.ShowDialog();

        }

        private void Txt_TargetFolder_TextChanged(object sender, EventArgs e)
        {
            ShowOrHideImgMsg();
        }

        private void Txt_OutputFolder_TextChanged(object sender, EventArgs e)
        {
            ShowOrHideImgMsg();
        }

    }
}
