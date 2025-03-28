﻿
using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;
using System.Windows.Forms;

namespace GeradorDePacotes
{
    public partial class Frm_ConfigUC : UserControl
    {
        private readonly ApplicationDbContext _context;

        private bool _initializing = true;

        private readonly Frm_Index _parentForm;

        private object? _cachedName;

        private Point BtnClearTablesInitialPosition { get; set; }

        private List<float> TlpContentRowStylesHeight { get; set; } = [];
        private int TlpContentHeight { get; set; }
        private int PnlContentConfigHeight { get; set; }
        private int PicMsgFieldsPointY { get; set; }
        private DataGridView[] DataGrids { get; set; }


        public static string? PathTargetFolder { get; private set; }

        public Frm_ConfigUC(Frm_Index parentForm)
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _parentForm = parentForm;
            BtnClearTablesInitialPosition = Btn_ClearTables.Location;
            TlpContentHeight = Tlp_Content.Height;
            PnlContentConfigHeight = Pnl_ContentConfig.Height;
            PicMsgFieldsPointY = Pic_Msg_Fields.Location.Y;

            DataGrids = Helpers.GetAllControlsOfType<DataGridView>(Pnl_ContentConfig).ToArray();

            foreach (RowStyle item in Tlp_Content.RowStyles)
            {
                TlpContentRowStylesHeight.Add(item.Height);
            }
        }

        //Personalized
        private void ExpandOrContractPnlsConfig(bool check)
        {
            if (!check)
            {
                Tlp_Content.RowStyles[0].Height += 100;
                Tlp_Content.Height += 40;
                Txt_OutputFolder.Visible = true;
                Btn_ExploreOutputFolder.Visible = true;
                Btn_ClearTables.Top += 40;
                Pnl_ContentConfig.Height += 40;
            }
            else
            {
                foreach (RowStyle item in Tlp_Content.RowStyles)
                {
                    foreach (var originalHeight in TlpContentRowStylesHeight)
                    {
                        item.Height = originalHeight;
                        break;
                    }
                }

                Txt_OutputFolder.Visible = false;
                Btn_ExploreOutputFolder.Visible = false;
                Tlp_Content.Height = TlpContentHeight;
                Btn_ClearTables.Location = BtnClearTablesInitialPosition;
                Pnl_ContentConfig.Height = PnlContentConfigHeight;
            }

        }
        private async void FillOwnControls()
        {
            #region["Pnl_OutputFile"]

            var lastFileName = await UtilDb.GetLastSelectedFileNameAsync(_context);

            if (!string.IsNullOrWhiteSpace(lastFileName))
                Txt_OutputFile.Text = lastFileName;

            var listLogsFileName = await UtilDb.GetListFileNameAsync(_context);
            if (listLogsFileName != null && listLogsFileName.Length > 0)
            {
                AutoCompleteStringCollection source = [.. listLogsFileName];

                Txt_OutputFile.AutoCompleteSource = AutoCompleteSource.CustomSource;
                Txt_OutputFile.AutoCompleteCustomSource = source;
                Txt_OutputFile.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }



            var chbAddDateHour = await UtilDb.GetParValueAsync(_context, "add_date_and_time_to_name");
            if (!string.IsNullOrWhiteSpace(chbAddDateHour))
                Chb_AddDateHourToName.Checked = Convert.ToBoolean(chbAddDateHour);
            else
                UtilDb.AddOrUpdateTableParKeysAsync(_context, "add_date_and_time_to_name", "true");

            //IMPLEMENTAR FUTURAMENTE SE NECESSÁRIO
            //var cmbFileFormat = await UtilDb.GetParValueAsync(_context, "file_format");
            //if (!string.IsNullOrWhiteSpace(cmbFileFormat))

            Cmb_Formatos.SelectedIndex = default;

            #endregion

            #region["Pnl_TargetFolder"]

            var txtTargetFolder = await UtilDb.GetParValueAsync(_context, "target_folder");
            if (!string.IsNullOrWhiteSpace(txtTargetFolder))
                Txt_TargetFolder.Text = txtTargetFolder;

            var chbSameFolder = await UtilDb.GetParValueAsync(_context, "same_output_folder");
            if (!string.IsNullOrWhiteSpace(chbSameFolder))
                Chb_SameOutputFolder.Checked = Convert.ToBoolean(chbSameFolder);
            else
                _ = UtilDb.AddOrUpdateTableParKeysAsync(_context, "same_output_folder", "true");

            var txtOutputFolder = await UtilDb.GetParValueAsync(_context, "output_folder");
            if (!string.IsNullOrWhiteSpace(txtOutputFolder))
                Txt_OutputFolder.Text = txtOutputFolder;
            #endregion

            ShowOrHideImgMsg();

            await Helpers.DataBindDataGridsAsync(_context, ctrl: this);
        }
        private async void AddPathFolder(TextBox ctrl, string parName)
        {
            if (!Helpers.IsDirectoryValid(ctrl))
                return;

            await UtilDb.AddOrUpdateTableParKeysAsync(_context, parName, ctrl.Text);
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
        private async void SwitchDtDeleteRows(DataGridViewCellEventArgs e, DataGridView dt)
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


        //Events
        private void Frm_ConfigUC_Load(object sender, EventArgs e)
        {

            FillOwnControls();
            _initializing = false;
            if (_parentForm != null && Frm_Index.sideBarExpanded)
                _parentForm.Pic_ExpandirMenu_Click(this, EventArgs.Empty);

            PathTargetFolder = Txt_TargetFolder.Text;
        }

        private void ShowOrHideImgMsg()
        {
            var visible = (string.IsNullOrWhiteSpace(Txt_TargetFolder.Text)
                           && Chb_SameOutputFolder.Checked)
                           || (!Chb_SameOutputFolder.Checked
                                && (string.IsNullOrWhiteSpace(Txt_TargetFolder.Text)
                                    || string.IsNullOrWhiteSpace(Txt_OutputFolder.Text))) ? true : false;

            if (visible)
            {
                Tlp_Content.RowStyles[1].Height = 0;
                Tlp_Content.RowStyles[2].Height = 0;
                Tlp_Content.Height = Chb_SameOutputFolder.Checked ? (int)TlpContentRowStylesHeight[0] : (int)TlpContentRowStylesHeight[0] + 50;
                Pic_Msg_Fields.Top = Chb_SameOutputFolder.Checked ? PicMsgFieldsPointY : Pic_Msg_Fields.Top + 80;
            }
            else
            {
                Tlp_Content.RowStyles[1].Height = TlpContentRowStylesHeight[1];
                Tlp_Content.RowStyles[2].Height = TlpContentRowStylesHeight[2];
                Tlp_Content.Height = Chb_SameOutputFolder.Checked ? TlpContentHeight : TlpContentHeight + 40;
            }

            foreach (Control control in Tlp_Content.Controls)
            {
                int rowIndex = Tlp_Content.GetRow(control);
                if (rowIndex == Tlp_Content.RowStyles.Count - 1 || rowIndex == Tlp_Content.RowStyles.Count - 2)
                {
                    control.Visible = !visible;
                }
            }

            Pic_Msg_Fields.Visible = visible;
            Btn_ClearTables.Visible = !visible;
            if (Pic_Msg_Fields.Visible)
            {
                Pic_Msg_Fields.BringToFront();
                Pic_Msg_Fields.Refresh();
            }

        }

        private void Txt_OutputFile_Leave(object sender, EventArgs e)
        {
            if (Helpers.IsFileNameValid(Txt_OutputFile.Text))
                UtilDb.AddOrUpdateOutputFileNameAsync(_context, Txt_OutputFile.Text);
        }

        private async void Txt_TargetFolder_Leave(object sender, EventArgs e)
        {
            if (sender == null)
                return;

            if (!Helpers.IsDirectoryValid(Txt_TargetFolder.Text))
            {
                Txt_TargetFolder.Text = await UtilDb.GetParValueAsync(_context, "target_folder");
                ShowOrHideImgMsg();
            }
            else
            {
                AddPathFolder(Txt_TargetFolder, "target_folder");
                if (Chb_SameOutputFolder.Checked)
                    AddPathFolder(Txt_TargetFolder, "output_folder");

                PathTargetFolder = Txt_TargetFolder.Text;
                ShowOrHideImgMsg();
            }

        }

        // NÃO NECESSÁRIO PARA O MOMENTO, IMPLEMENTAR FUTURAMENTE

        //private async void Cmb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (_initializing) return;

        //    if (Cmb_Formatos.SelectedItem != null)
        //    {
        //        await UtilDb.AddOrUpdateTableParKeysAsync(_context, "file_format", Cmb_Formatos.SelectedItem.ToString()!);
        //    }
        //}

        private void Chb_AddDateHourToName_CheckedChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            if (Cmb_Formatos.SelectedItem != null)
                UtilDb.AddOrUpdateTableParKeysAsync(_context, "add_date_and_time_to_name", Chb_AddDateHourToName.Checked.ToString());
        }

        private void Chb_SameOutputFolder_CheckedChanged(object sender, EventArgs e)
        {
            ExpandOrContractPnlsConfig(Chb_SameOutputFolder.Checked);
            ShowOrHideImgMsg();

            if (_initializing) return;
                _ = UtilDb.AddOrUpdateTableParKeysAsync(_context, "same_output_folder", Chb_SameOutputFolder.Checked.ToString());
            if (Chb_SameOutputFolder.Checked)
                _ = UtilDb.AddOrUpdateTableParKeysAsync(_context, "output_folder", Txt_TargetFolder.Text);
            else
                _ = UtilDb.AddOrUpdateTableParKeysAsync(_context, "output_folder", Txt_OutputFolder.Text);
        }
        private async void Txt_OutputFolder_Leave(object sender, EventArgs e)
        {
            if (!Helpers.IsDirectoryValid(Txt_OutputFolder.Text))
            {
                Txt_OutputFolder.Text = await UtilDb.GetParValueAsync(_context, "output_folder");
                return;
            }
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
            if (Chb_SameOutputFolder.Checked)
                AddPathFolder(Txt_TargetFolder, "output_folder");
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

            var dr = MessageBox.Show("Você deseja adicionar as subpastas à lista?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            var list = new List<string>();
            if (dr == DialogResult.Yes)
                list.AddRange(Directory.GetDirectories(Fbd_ConfigUC.SelectedPath));
            else
                list.Add(Fbd_ConfigUC.SelectedPath);

            AddFolders(list, Dt_FoldersToDelete.Name);
            await Helpers.DataBindDataGridsAsync(_context, Dt_FoldersToDelete);
        }

        private async void AddFolders(List<string> list, string DataTableName)
        {
            switch (DataTableName)
            {
                case "Dt_FoldersToDelete":
                    foreach (var path in list)
                        await UtilDb.AddOrUpdateToGridFoldersToDeleteAsync(_context, path);
                    break;

                case "Dt_FoldersToVerify":
                    foreach (var path in list)
                        await UtilDb.AddOrUpdateToGridFoldersToVerifyAsync(_context, path);
                    break;
                default:
                    break;
            }
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

            var dr = MessageBox.Show("Você deseja adicionar as subpastas à lista?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            var list = new List<string>();
            if (dr == DialogResult.Yes)
                list.AddRange(Directory.GetDirectories(Fbd_ConfigUC.SelectedPath));
            else
                list.Add(Fbd_ConfigUC.SelectedPath);

            AddFolders(list, Dt_FoldersToVerify.Name);
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
                await Task.Run(() => SwitchDtDeleteRows(e, dt));
                await Helpers.DataBindDataGridsAsync(_context, dt);
            }
        }

        private async void Btn_ClearTables_Click(object sender, EventArgs e)
        {



            if (DataGrids.Any(dt => dt.Rows.Count > 0))
            {
                var dr = MessageBox.Show("Tem certeza que deseja limpar todas as tabelas? Esta ação não é reversível!", "CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                foreach (var item in DataGrids)
                {
                    await UtilDb.ClearTableAsync(_context, item.Name.Replace("Dt_", ""));
                    await Helpers.DataBindDataGridsAsync(_context, item);
                }
                MessageBox.Show("Todas as tabelas foram limpas com sucesso!", "Sucesso");
            }
        }

        private void Txt_TargetFolder_TextChanged(object sender, EventArgs e)
        {
            ShowOrHideImgMsg();
        }

        private void Txt_OutputFolder_TextChanged(object sender, EventArgs e)
        {
            ShowOrHideImgMsg();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
