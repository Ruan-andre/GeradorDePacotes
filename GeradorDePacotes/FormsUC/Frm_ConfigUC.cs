
using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;
using Microsoft.EntityFrameworkCore;

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

        private void Txt_TargetFolder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_TargetFolder.Text)) return;

            AddPathFolder(Txt_TargetFolder, "target_folder");
        }

        private void Cmb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            if (Cmb_Formatos.SelectedItem != null)
            {
                UtilDb.AddOrUpdateTableParKeys(_context, "file_format", Cmb_Formatos.SelectedItem.ToString()!);
            }
        }

        private void Chb_AddDateHourToName_CheckedChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            if (Cmb_Formatos.SelectedItem != null)
            {
                UtilDb.AddOrUpdateTableParKeys(_context, "add_hour_and_date_to_name", Chb_AddDateHourToName.Checked.ToString()!);
            }
        }



        private void Chb_SameOutputFolder_CheckedChanged(object sender, EventArgs e)
        {
            ExpandOrContractGrpsConfig(Chb_SameOutputFolder.Checked);

            if (_initializing) return;

            UtilDb.AddOrUpdateTableParKeys(_context, "same_output_folder", Chb_SameOutputFolder.Checked.ToString());


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

        private void Btn_AddFolderToDelete_Click(object sender, EventArgs e)
        {
            Fbd_ConfigUC.Description = "Selecione a pasta que será adicionada à lista de exclusões";
            string pathTargetFolder = Txt_TargetFolder.Text;
            if (string.IsNullOrWhiteSpace(pathTargetFolder))
            {
                MessageBox.Show("O caminho da pasta alvo está vázio, por favor, preencha-o", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_TargetFolder.Focus();
                return;
            }

            Fbd_ConfigUC.InitialDirectory = Txt_TargetFolder.Text;
            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            UtilDb.AddOrUpdateToGridFoldersToDelete(_context, Fbd_ConfigUC.SelectedPath, pathTargetFolder);
            DataBindDataGrids(Dt_FoldersToDelete);
        }

        private void Btn_AddFileToDelete_Click(object sender, EventArgs e)
        {
            Fd_ConfigUC.Title = "Selecione o(s) arquivo(s) para serem adicionado(s) à lista de exclusões";
            if (Fd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            UtilDb.AddOrUpdateToGridFilesToDelete(_context, Fd_ConfigUC.FileNames);
            DataBindDataGrids(Dt_FilesToDelete);
        }

        private void Btn_AddFolderToVerify_Click(object sender, EventArgs e)
        {
            Fbd_ConfigUC.Description = "Selecione a pasta que será adicionada à lista de verificação";
            if (Fbd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            UtilDb.AddOrUpdateToGridFoldersToVerify(_context, Fbd_ConfigUC.SelectedPath);
        }

        private void Btn_AddFileToVerify_Click(object sender, EventArgs e)
        {
            Fd_ConfigUC.Title = "Selecione o(s) arquivo(s) para serem adicionado(s) à lista de verificação";
            if (Fd_ConfigUC.ShowDialog() == DialogResult.Cancel) return;

            UtilDb.AddOrUpdateToGridFilesToVerify(_context, Fd_ConfigUC.FileNames);
        }

        private void CellEndEdit(object sender, DataGridViewCellEventArgs e)
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
                    UtilDb.AddOrUpdateTableFoldersToDelete(_context, name.ToString(), id: idItem);
                    break;

                case "FilesToDelete":
                    UtilDb.AddOrUpdateTableFilesToDelete(_context, id: idItem);
                    break;

                case "FoldersToVerify":
                    UtilDb.AddOrUpdateTableFoldersToVerify(_context, id: idItem);
                    break;

                case "FilesToVerify":
                    UtilDb.AddOrUpdateTableFilesToVerify(_context, id: idItem);
                    break;
                default:
                    break;
            }

            //var name = dt.Rows[e.RowIndex].Cells["folderName"].Value;
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
                await SwitchDtDelete(e, dt);
                DataBindDataGrids(dt);
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
                Grp_FilesToDelete.Location = new Point(384, 187);
                Grp_FoldersToVerify.Location = new Point(0, 436);
                Grp_FilesToVerify.Location = new Point(384, 436);

                Chb_AddDateHourToName.Location = new Point(13, 90);

                Cmb_Formatos.Location = new Point(10, 120);

                Txt_OutputFolder.Visible = true;
                Txt_OutputFolder.Location = new Point(8, 120);
                Txt_OutputFolder.Width = 327;

                Btn_ExploreOutputFolder.Visible = true;
                Btn_ExploreOutputFolder.Location = new Point(335, 120);
            }
            else
            {
                Grp_OutputFile.Height = 130;
                Grp_TargetFolder.Height = 130;

                Grp_FoldersToDelete.Location = new Point(0, 147);
                Grp_FilesToDelete.Location = new Point(384, 147);
                Grp_FoldersToVerify.Location = new Point(0, 396);
                Grp_FilesToVerify.Location = new Point(384, 396);

                Chb_AddDateHourToName.Location = new Point(13, 90);
                Cmb_Formatos.Location = new Point(249, 88);
                Txt_OutputFolder.Visible = false;
                Btn_ExploreOutputFolder.Visible = false;
            }

        }
        private void FillOwnControls()
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

            var chbAddDateHour = UtilDb.GetParValue(_context, "add_hour_and_date_to_name");
            if (!string.IsNullOrWhiteSpace(chbAddDateHour))
                Chb_AddDateHourToName.Checked = Convert.ToBoolean(chbAddDateHour);

            var cmbFileFormat = UtilDb.GetParValue(_context, "file_format");
            if (!string.IsNullOrWhiteSpace(cmbFileFormat))
                Cmb_Formatos.SelectedItem = cmbFileFormat;

            #endregion

            #region["Grp_TargetFolder"]

            var txtTargetFolder = UtilDb.GetParValue(_context, "target_folder");
            if (!string.IsNullOrWhiteSpace(txtTargetFolder))
                Txt_TargetFolder.Text = txtTargetFolder;

            var chbSameFolder = UtilDb.GetParValue(_context, "same_output_folder");
            if (!string.IsNullOrWhiteSpace(chbSameFolder))
                Chb_SameOutputFolder.Checked = Convert.ToBoolean(chbSameFolder);

            var txtOutputFolder = UtilDb.GetParValue(_context, "output_folder");
            if (!string.IsNullOrWhiteSpace(txtOutputFolder))
                Txt_OutputFolder.Text = txtOutputFolder;

            #endregion

            DataBindDataGrids();
        }
        private void AddPathFolder(TextBox ctrl, string parName)
        {
            if (!Helpers.IsDirectoryValid(ctrl))
                return;

            UtilDb.AddOrUpdateTableParKeys(_context, parName, ctrl.Text);
            PathTargetFolder = ctrl.Text;
        }
        private async void DataBindDataGrids(DataGridView? dataGrid = null)
        {
            if (dataGrid != null)
            {
                var tableName = dataGrid.Name.Replace("Dt_", "");
                var dbSetProperty = _context.GetType().GetProperty(tableName);
                var dbSet = dbSetProperty.GetValue(_context);
                var query = dbSet as IQueryable<object>;
                var data = await query.ToListAsync();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = data;
                return;
            }
            else
            {
                var Dts = Helpers.GetAllControlsOfType<DataGridView>(this);

                foreach (DataGridView dt in Dts)
                {
                    var tableName = dt.Name.Replace("Dt_", "");
                    var dbSetProperty = _context.GetType().GetProperty(tableName);
                    var dbSet = dbSetProperty.GetValue(_context);
                    var query = dbSet as IQueryable<object>;
                    var data = await query.ToListAsync();
                    dt.AutoGenerateColumns = false;
                    dt.DataSource = data;
                }

            }

        }
        private void SwitchDtCheckBox(DataGridViewCellEventArgs e, DataGridView dt)
        {
            var idItem = (int)dt.Rows[e.RowIndex].Cells[3].Value;
            DataGridViewCell cell = dt[e.ColumnIndex, e.RowIndex];
            bool currentValue = (bool)cell.Value;
            cell.Value = !currentValue;
            var newValue = !currentValue;
            switch (dt.Name.Replace("Dt_", ""))
            {
                case "FoldersToDelete":
                    UtilDb.AddOrUpdateTableFoldersToDelete(_context, disconsider: newValue, id: idItem);
                    break;

                case "FilesToDelete":
                    UtilDb.AddOrUpdateTableFilesToDelete(_context, disconsider: newValue, id: idItem);
                    break;

                case "FoldersToVerify":
                    UtilDb.AddOrUpdateTableFoldersToVerify(_context, disconsider: newValue, id: idItem);
                    break;

                case "FilesToVerify":
                    UtilDb.AddOrUpdateTableFilesToVerify(_context, disconsider: newValue, id: idItem);
                    break;
                default:
                    break;
            }
        }
        private async Task SwitchDtDelete(DataGridViewCellEventArgs e, DataGridView dt)
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
            var cell = dt[e.ColumnIndex, e.RowIndex].Value;
            _cachedName = cell;
        }
    }
}
