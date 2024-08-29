
using GeradorDePacotes.Classes;
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;

namespace GeradorDePacotes
{
    public partial class Frm_ConfigUC : UserControl
    {
        private ApplicationDbContext _context;
        private bool _initializing = true;
        public Frm_ConfigUC()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        //Events

        private void Frm_ConfigUC_Load(object sender, EventArgs e)
        {
            FillOwnControls();
            ExpandOrContractGrpsConfig(Chb_SameOutputFolder.Checked);
            _initializing = false;
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
                Utils.AddOrUpdateParKeys(_context, "file_format", Cmb_Formatos.SelectedItem.ToString()!);
            }
        }

        private void Chb_AddDateHourToName_CheckedChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            if (Cmb_Formatos.SelectedItem != null)
            {
                Utils.AddOrUpdateParKeys(_context, "add_hour_and_date_to_name", Chb_AddDateHourToName.Checked.ToString()!);
            }
        }



        private void Chb_SameOutputFolder_CheckedChanged(object sender, EventArgs e)
        {
            ExpandOrContractGrpsConfig(Chb_SameOutputFolder.Checked);

            if (_initializing) return;

            Utils.AddOrUpdateParKeys(_context, "same_output_folder", Chb_SameOutputFolder.Checked.ToString());


        }
        private void Txt_OutputFolder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_OutputFolder.Text)) return;
            AddPathFolder(Txt_OutputFolder, "output_folder");
        }
        private void Btn_ExploreTargetFolders_Click(object sender, EventArgs e)
        {
            if (Txt_TargetFolder.Text != null)
                Fbd_TargetFolder.InitialDirectory = Txt_TargetFolder.Text;

            if (Fbd_TargetFolder.ShowDialog() == DialogResult.Cancel || !Helpers.IsDirectoryValid(Fbd_TargetFolder.SelectedPath))
                return;

            Txt_TargetFolder.Text = Fbd_TargetFolder.SelectedPath;
            AddPathFolder(Txt_TargetFolder, "target_folder");
        }
        private void Btn_ExploreOutputFolder_Click(object sender, EventArgs e)
        {
            if (Txt_OutputFolder.Text != null)
                Fbd_OutputFolder.InitialDirectory = Txt_OutputFolder.Text;

            if (Fbd_OutputFolder.ShowDialog() == DialogResult.Cancel || !Helpers.IsDirectoryValid(Fbd_OutputFolder.SelectedPath))
                return;

            Txt_OutputFolder.Text = Fbd_OutputFolder.SelectedPath;
            AddPathFolder(Txt_OutputFolder, "output_folder");
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

                Grp_FoldersToDelete.Location = new Point(0, 188);
                Grp_FilesToDelete.Location = new Point(346, 188);
                Grp_FoldersToVerify.Location = new Point(0, 429);
                Grp_FilesToVerify.Location = new Point(346, 429);

                Chb_AddDateHourToName.Location = new Point(13, 104);
                Cmb_Formatos.Location = new Point(10, 135);
                Txt_OutputFolder.Visible = true;
                Btn_ExploreOutputFolder.Visible = true;
            }
            else
            {
                Grp_OutputFile.Height = 130;
                Grp_TargetFolder.Height = 130;

                Grp_FoldersToDelete.Location = new Point(0, 156);
                Grp_FilesToDelete.Location = new Point(346, 156);
                Grp_FoldersToVerify.Location = new Point(0, 405);
                Grp_FilesToVerify.Location = new Point(346, 405);

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

            var chbAddDateHour = Utils.GetParValue(_context, "add_hour_and_date_to_name");
            if (!string.IsNullOrWhiteSpace(chbAddDateHour))
                Chb_AddDateHourToName.Checked = Convert.ToBoolean(chbAddDateHour);

            var cmbFileFormat = Utils.GetParValue(_context, "file_format");
            if (!string.IsNullOrWhiteSpace(cmbFileFormat))
                Cmb_Formatos.SelectedItem = cmbFileFormat;

            #endregion

            #region["Grp_TargetFolder"]

            var txtTargetFolder = Utils.GetParValue(_context, "target_folder");
            if (!string.IsNullOrWhiteSpace(txtTargetFolder))
                Txt_TargetFolder.Text = txtTargetFolder;

            var chbSameFolder = Utils.GetParValue(_context, "same_output_folder");
            if (!string.IsNullOrWhiteSpace(chbSameFolder))
                Chb_SameOutputFolder.Checked = Convert.ToBoolean(chbSameFolder);

            var txtOutputFolder = Utils.GetParValue(_context, "output_folder");
            if (!string.IsNullOrWhiteSpace(txtOutputFolder))
                Txt_OutputFolder.Text = txtOutputFolder;

            #endregion
        }

        private void AddPathFolder(TextBox ctrl, string parName)
        {
            if (!Helpers.IsDirectoryValid(ctrl))
                return;

            Utils.AddOrUpdateParKeys(_context, parName, ctrl.Text);
        }

    }
}
