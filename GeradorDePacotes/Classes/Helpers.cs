using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePacotes.Classes
{
    public static class Helpers
    {
        public static void CenterPanelSideBar(Control frmParent, Control sideBar, Control ctrlContent, bool expandedBar)
        {
            int x;
            int y = (frmParent.Height - ctrlContent.Height) / 2;

            if (expandedBar)
            {
                x = (frmParent.Width - sideBar.Width - ctrlContent.Width) / 2 + sideBar.Width;
            }
            else
            {
                x = (frmParent.Width - sideBar.Width - ctrlContent.Width) / 2 + sideBar.Width;
            }

            ctrlContent.Location = new Point(x, y);
        }
        public static void CenterPanel(Control ctrlParent, Control ctrlChild)
        {
            int x = (ctrlParent.Width - ctrlChild.Width) / 2;
            int y = (ctrlParent.Height - ctrlChild.Height) / 2;
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

    }
}
