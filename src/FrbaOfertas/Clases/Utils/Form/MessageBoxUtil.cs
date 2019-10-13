using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Clases.Utils.Form
{
    class MessageBoxUtil
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Info", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
