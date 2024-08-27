using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDePacotes.Classes
{
    public static class Helpers
    {
        public static void CenterPanel(Control frmParent, Control sideBar, Control ctrlContent, bool expandedBar)
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

    }
}
