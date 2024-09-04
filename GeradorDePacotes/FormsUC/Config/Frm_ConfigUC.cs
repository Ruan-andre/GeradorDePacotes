
using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;
using GeradorDePacotes.FormsUC.Config;

namespace GeradorDePacotes
{
    public partial class Frm_ConfigUC : UserControl
    {
        private ApplicationDbContext _context;

        private bool _initializing = true;

        private Frm_Index _parentForm;

        private object _cachedName;

        public static string PathTargetFolder { get; private set; }

        public Frm_ConfigUC(Frm_Index parentForm)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _parentForm = parentForm;
        }

        //Events

        private void Frm_ConfigUC_Load(object sender, EventArgs e)
        {
            FillOwnControls();
            ExpandOrContractGrpsConfig(Chb_SameOutputFolder.Checked);
            _initializing = false;
            if (_parentForm != null && Frm_Index.sideBarExpanded)
                _parentForm.Pic_ExpandirMenu_Click(this, EventArgs.Empty);

            PathTargetFolder = Txt_TargetFolder.Text;
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
                return;
            }

            AddPathFolder(Txt_TargetFolder, "target_folder");
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
            ExpandOrContractGrpsConfig(Chb_SameOutputFolder.Checked);

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

        private async void Btn_AddFolderToDelete_Click(object sender, EventArgs e)
        {
            Fbd_ConfigUC.Description = "Selecione a pasta que será adicionada à lista de exclusões";
            Fbd_ConfigUC.UseDescriptionForTitle = true;
            
            if (!VerifyPathTargetFolder()) return;

            Fbd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFoldersToDeleteAsync(_context, Fbd_ConfigUC.SelectedPath, Txt_TargetFolder.Text);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FoldersToDelete);
        }

        private async void Btn_AddFileToDelete_Click(object sender, EventArgs e)
        {

            if (!VerifyPathTargetFolder()) return;

            Fd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            Fd_ConfigUC.Title = "Selecione o(s) arquivo(s) para serem adicionado(s) à lista de exclusões";
            if (Fd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFilesToDeleteAsync(_context, Fd_ConfigUC.FileNames);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FilesToDelete);
        }

        private async void Btn_AddFolderToVerify_Click(object sender, EventArgs e)
        {

            if (!VerifyPathTargetFolder()) return;

            Fbd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            Fbd_ConfigUC.Description = "Selecione a pasta que será adicionada à lista de verificação";
            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            await UtilDb.AddOrUpdateToGridFoldersToVerifyAsync(_context, Fbd_ConfigUC.SelectedPath);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FoldersToVerify);
        }

        private async void Btn_AddFileToVerify_Click(object sender, EventArgs e)
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
        private void ExpandOrContractGrpsConfig(bool check)
        {

            if (!check)
            {
                Grp_OutputFile.Height = 174;
                Grp_TargetFolder.Height = 174;

                Grp_FoldersToDelete.Location = new Point(0, 187);
                Grp_FilesToDelete.Location = new Point(411, 187);
                Grp_FoldersToVerify.Location = new Point(0, 442);
                Grp_FilesToVerify.Location = new Point(411, 442);

                Chb_AddDateHourToName.Location = new Point(13, 90);

                Cmb_Formatos.Location = new Point(10, 120);

                Txt_OutputFolder.Visible = true;
                Txt_OutputFolder.Location = new Point(8, 120);
                Txt_OutputFolder.Width = 327;

                Btn_ExploreOutputFolder.Visible = true;
                Btn_ExploreOutputFolder.Location = new Point(335, 120);

                Btn_ClearTables.Location = new Point(292, 692);
                Pnl_ContentConfig.Height += 40;
            }
            else
            {
                Grp_OutputFile.Height = 130;
                Grp_TargetFolder.Height = 130;

                Grp_FoldersToDelete.Location = new Point(0, 147);
                Grp_FilesToDelete.Location = new Point(411, 147);
                Grp_FoldersToVerify.Location = new Point(0, 402);
                Grp_FilesToVerify.Location = new Point(411, 402);

                Chb_AddDateHourToName.Location = new Point(13, 90);
                Cmb_Formatos.Location = new Point(316, 84);
                Txt_OutputFolder.Visible = false;
                Btn_ExploreOutputFolder.Visible = false;

                Btn_ClearTables.Location = new Point(292, 652);
                Pnl_ContentConfig.Height = 689;
            }

        }
        private async void FillOwnControls()
        {
            #region["Grp_OutputFile"]

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

            #region["Grp_TargetFolder"]

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

    }
}
