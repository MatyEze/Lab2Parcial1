using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin login = new FormLogin();
            FormPrincipal formPrincipal = new FormPrincipal();

            do
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    formPrincipal.DniEmpleado = login.Clave;
                    formPrincipal.ShowDialog(); //cierra sesion
                }
                else
                {
                    formPrincipal.DialogResult = DialogResult.Cancel;
                }
            } while (formPrincipal.DialogResult==DialogResult.Retry);

            //Application.Run(new FormPrincipal());

            
        }
    }
}
