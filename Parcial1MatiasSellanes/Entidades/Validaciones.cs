using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    static public class Validaciones
    {
        public static int StringToInt(string strNumero)
        {
            int valor;
            int.TryParse(strNumero, out valor);
            return valor;
        }
        public static double StringToDouble(string strNumero)
        {
            double valor;
            double.TryParse(strNumero, out valor);
            return valor;
        }
        public static int ValidarInt(int entero, int valorMinimo)
        {
            int valorRetrono = valorMinimo;
            if (entero >= valorMinimo)
            {
                valorRetrono = entero;
            }
            return valorRetrono;
        }
        public static int ValidarInt(string strEntero, int valorMinimo)
        {
            int valorRetorno = valorMinimo;
            int entero = Validaciones.StringToInt(strEntero);
            return Validaciones.ValidarInt(entero, valorMinimo);
        }
        /// <summary>
        /// verifica que el string ingesado en en un textbox contenga solo letras y formatea el string de forma que quede asi
        /// ej:(Nombre Nombre Nombre)
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>Devulve false si el texto contiene caracteres que no sean letras o si el string es menor a 2 cacaracteres</returns>
        public static bool ValidarNombreTextBox(object sender)
        {
            bool valorRetorno = false;
            if (Validaciones.VerificarLetras(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
                ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();
                if (((TextBox)sender).Text.Length >= 2)
                {
                    valorRetorno = true;
                    ((TextBox)sender).Text = char.ToUpper(((TextBox)sender).Text[0]) + ((TextBox)sender).Text.Substring(1);

                    int posicion = 1;
                    while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                    {
                        posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                        ((TextBox)sender).Text = String.Concat(
                            //Ana
                            ((TextBox)sender).Text.Substring(0, posicion + 1),
                            //M
                            Char.ToUpper(((TextBox)sender).Text[posicion + 1]),
                            //aria
                            ((TextBox)sender).Text.Substring(posicion + 2));

                        posicion++;
                    }
                }
            }
            return valorRetorno;
        }
        /// <summary>
        /// verifica que el string pasado conenga solo letras y espacios
        /// </summary>
        /// <param name="strng"></param>
        /// <returns>devuelve false si contiene caracteres que no sean letras o espacios</returns>
        public static bool VerificarLetras(string strng)
        {
            bool valorRetorno = true;
            for (int i = 0; i < strng.Length; i++)
            {
                if (!(Char.IsLetter(strng[i]) || strng[i] == ' '))
                {
                    valorRetorno = false;
                    break;
                }
            }
            return valorRetorno;
        }
        /// <summary>
        /// verifica que el string pasado solo contenga numeros y espacios
        /// </summary>
        /// <param name="strng"></param>
        /// <returns>devuelve falso si el string contiene caracteres que no sean numeros o espacios</returns>
        public static bool VerificarNumeros(string strng)
        {
            bool valorRetorno = true;
            for (int i = 0; i < strng.Length; i++)
            {
                if (!(Char.IsDigit(strng[i]) || strng[i] == ' '))
                {
                    valorRetorno = false;
                    break;
                }
            }
            return valorRetorno;
        }
    }
}

