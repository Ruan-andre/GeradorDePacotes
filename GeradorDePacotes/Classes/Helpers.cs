using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePacotes.Classes
{
    public static class Helpers
    {
        public static void CenterPanelSideBar(Control frmParent, Control sideBar, Control panelTop, Control ctrlContent, bool expandedBar)
        {
            int x;
            int y = (frmParent.ClientSize.Height - panelTop.ClientSize.Height - ctrlContent.ClientSize.Height) / 2 + panelTop.Height;

            if (expandedBar)
            {
                x = (frmParent.ClientSize.Width - sideBar.ClientSize.Width - ctrlContent.ClientSize.Width) / 2 + sideBar.ClientSize.Width;
            }
            else
            {
                x = (frmParent.ClientSize.Width - sideBar.ClientSize.Width - ctrlContent.ClientSize.Width) / 2 + sideBar.ClientSize.Width;
            }

            ctrlContent.Location = new Point(x, y);
        }
        public static void CenterPanel(Control ctrlParent, Control ctrlChild)
        {
            int x = (ctrlParent.ClientSize.Width - ctrlChild.ClientSize.Width) / 2;
            int y = (ctrlParent.ClientSize.Height - ctrlChild.ClientSize.Height) / 2;
            ctrlChild.Location = new Point(x, y);
        }

        public static bool IsDirectoryValid(TextBox ctrl)
        {
            if (!Directory.Exists(ctrl.Text))
            {
                MessageBox.Show("O diretório informado não existe, ou é inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrl.Text = string.Empty;
                ctrl.Focus();
                return false;
            }

            return true;
        }

        public static bool IsDirectoryValid(Control ctrl, string path, bool focus = true)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("O diretório informado não existe, ou é inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrl.Text = string.Empty;
                ctrl.Focus();
                return false;
            }
            return true;
        }
        public static bool IsDirectoryValid(string path)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("O diretório informado não existe, ou é inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string GetNameWithoutPath(string path)
        {
            char charSeparator = Path.DirectorySeparatorChar;
            var lastIndex = path.LastIndexOf(charSeparator);
            var nameFolderWithoutPath = path.Substring(lastIndex + 1);
            return nameFolderWithoutPath;
        }

        public static string GetNameWithoutPathForTargetFolder(string path, string pathTargetFolder)
        {
            if (path.Equals(pathTargetFolder))
            {
                char charSeparatorTarget = Path.DirectorySeparatorChar;
                var index = pathTargetFolder.LastIndexOf(charSeparatorTarget);
                return pathTargetFolder.Substring(index + 1);
            }
            char charSeparator = Path.DirectorySeparatorChar;
            var lastIndexCharSeparator = pathTargetFolder.LastIndexOf(charSeparator);
            var nameTargetFolderWithoutPath = pathTargetFolder.Substring(lastIndexCharSeparator + 1);
            var lastIndex = path.IndexOf(nameTargetFolderWithoutPath);
            var pathAfterTargetFolder = path.Substring(lastIndex + nameTargetFolderWithoutPath.Length + 1);
            return pathAfterTargetFolder;
        }

        public static IEnumerable<T> GetAllControlsOfType<T>(Control parent) where T : Control
        {
            var controls = parent.Controls.OfType<T>();

            return controls.Concat(parent.Controls.OfType<Control>()
                                        .SelectMany(ctrl => GetAllControlsOfType<T>(ctrl)));
        }
    }
}
