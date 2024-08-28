
using GeradorDePacotes.Database;
using GeradorDePacotes.Database.Entities;
using Microsoft.EntityFrameworkCore;
using ReaLTaiizor.Controls;

namespace GeradorDePacotes
{
    public partial class Frm_ConfigUC : UserControl
    {
        private ApplicationDbContext _context;
        public Frm_ConfigUC()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();

        }

        private void Btn_ExploreFolders_Click(object sender, EventArgs e)
        {
            Fbd_Config.ShowDialog();

            if (!IsFolderValid(Fbd_Config.SelectedPath))
                return;

            AddTargetFolder(Fbd_Config.SelectedPath);
            Txt_TargetFolder.Text = Fbd_Config.SelectedPath;
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

        private bool IsFileNameValid(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return false;

            char[] invalidChars = Path.GetInvalidFileNameChars();

            if (fileName.Any(ch => invalidChars.Contains(ch)))
                return false;

            return true;
        }

        private void Txt_TargetFolder_Leave(object sender, EventArgs e)
        {
            var folderPath = Txt_TargetFolder.Text;
            if (string.IsNullOrWhiteSpace(folderPath)) return;

            AddTargetFolder(folderPath);
        }

        private void AddTargetFolder(string folderPath)
        {
            if (!IsFolderValid(folderPath))
            {
                return;
            }


            var parKey = _context.ParKeys.FirstOrDefault(x => x.ParName.Equals("target_folder"));

            if (parKey != null)
            {
                parKey.ParValue = folderPath;
                _context.SaveChanges();
            }
            else
            {
                var newParKey = new ParKey
                {
                    ParName = "target_folder",
                    ParValue = folderPath
                };

                _context.ParKeys.Add(newParKey);
                _context.SaveChanges();
            }
        }

        private bool IsFolderValid(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("O diretório informado não existe, ou é inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_TargetFolder.Text = string.Empty;
                Txt_TargetFolder.Focus();
                return false;
            }

            return true;
        }

        private void Cmb_Formatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var formatParKey = _context.ParKeys.FirstOrDefault(x => x.ParName.Equals("file_format"));
            if (formatParKey != null && Cmb_Formatos.SelectedItem != null)
            {
                formatParKey.ParValue = Cmb_Formatos.SelectedItem.ToString()!;
                _context.SaveChanges();
            }
            else
            {
                var newFormatParKey = new ParKey
                {
                    ParName = "file_format",
                    ParValue = Cmb_Formatos.SelectedText
                };

                _context.ParKeys.Add(newFormatParKey);
                _context.SaveChanges();
            }

        }

        private void Chb_AddDateHourToName_CheckedChanged(object sender, EventArgs e)
        {
            var chb = Chb_AddDateHourToName.Checked;
            var parKeyChb = _context.ParKeys.FirstOrDefault(x => x.ParName.Equals("add_hour_and_date_to_name"));

            if (parKeyChb != null)
            {
                parKeyChb.ParValue = chb.ToString();
                _context.SaveChanges();
            }
            else
            {
                var newChbParKey = new ParKey
                {
                    ParName = "add_hour_and_date_to_name",
                    ParValue = chb.ToString()
                };

                _context.ParKeys.Add(newChbParKey);
            }
        }
    }
}
