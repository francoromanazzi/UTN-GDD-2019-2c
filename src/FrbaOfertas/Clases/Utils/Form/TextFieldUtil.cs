using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Clases.Utils.Form
{
    class TextFieldUtil
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        // Compruebo si los campos TextBox solo tienen digitos
        public static bool CampoNumericoValido(params TextBox[] fields)
        {
            List<TextBox> campos = new List<TextBox>();
            campos.AddRange(fields);

            foreach (var c in campos.FindAll(camp => camp.Text != "")) // Campos que no esten vacios
            {
                if(!c.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Revisar el campo: " + c.Name);
                    return false;
                }
            }
            return true;
        }

        // Compruebo si los campos TextBox solo tienen letras
        public static bool CampoTextoValido(params TextBox[] fields)
        {
            List<TextBox> campos = new List<TextBox>();
            campos.AddRange(fields);

            foreach (var c in campos.FindAll(camp => camp.Text != "")) // Campos que no esten vacios
            {
                if (!c.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Revisar el campo: " + c.Name);
                    return false;
                }
            }
            return true;
        }

    }
}
