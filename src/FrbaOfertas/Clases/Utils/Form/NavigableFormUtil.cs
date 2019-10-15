using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Clases.Utils.Form
{
    class NavigableFormUtil
    {
        public static void ForwardTo(System.Windows.Forms.Form from, System.Windows.Forms.Form to)
        {
            from.Hide();
            to.Show();
        }

        public static void BackwardTo(System.Windows.Forms.Form from, System.Windows.Forms.Form backTo)
        {
            from.Dispose();
            from.Close();

            backTo.Show();
        }

        public static void ForwardToDifferentWindow(System.Windows.Forms.Form from, System.Windows.Forms.Form to)
        {
            to.ShowDialog();
        }

        public static void BackwardToDifferentWindow(System.Windows.Forms.Form from, System.Windows.Forms.Form backTo)
        {
            from.Dispose();
        }
    }
}
