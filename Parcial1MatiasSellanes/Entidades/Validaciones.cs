using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
