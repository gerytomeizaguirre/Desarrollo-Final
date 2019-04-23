using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUMOT
{
    class validaciones
    {
        public static void SoloLetras(KeyPressEventArgs V)
        {
            if (char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSymbol(V.KeyChar))
            {
                V.Handled = true;
                MessageBox.Show("No se permiten Simbolos.");
            }

            else
            {
                V.Handled = true;
                MessageBox.Show("No se permiten numeros.");
            }
        }

        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = true;
                MessageBox.Show("No se permiten espacios.");
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("No se permiten letras ni simbolos.");
            }

        }

        public static string Clamp(string text, int max)
        {
            if (String.IsNullOrWhiteSpace(text))
                return text;

            int val = Convert.ToInt16(text);

            if (val > max)
                val = max;

            return val.ToString();
        }

        public static void SoloDecimales(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
            }

        }

        public static void SoloLetrasConEspacios(KeyPressEventArgs V)
        {
            if (char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("No se permiten numeros.");

            }
        }

        public static void SoloNumerosConEspacios(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("No se permiten letras ni simbolos.");
            }

        }
    }
}
