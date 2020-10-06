using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Empleado : Persona
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {

        List<Compra> listaVentas;
        public List<Compra> ListaVentas
        {
            get { return listaVentas; }
        }
        public double TotalVentas
        {
            get
            {
                double valorRetorno = 0;
                foreach (Compra item in listaVentas)
                {
                    valorRetorno += item.Total;
                }
                return valorRetorno;
            }
        }

        public Empleado(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            listaVentas = new List<Compra>();
        }

        public void AgregarCompra(Compra compra)
        {
            if (listaVentas + compra) { };
        }

        public static bool operator +(List<Empleado> listaEmpleados, Empleado empleado)
        {
            bool valorRetorno = false;
            if (listaEmpleados != empleado)
            {
                listaEmpleados.Add(empleado);
                valorRetorno = true;
            }
            return valorRetorno;
        }

        public static bool operator ==(List<Empleado> listaEmpleados, Empleado empleado)
        {
            bool valorRetorno = false;
            foreach (Empleado item in listaEmpleados)
            {
                if (item.dni == empleado.dni)
                {
                    valorRetorno = true;
                }
            }
            return valorRetorno;
        }

        public static bool operator !=(List<Empleado> listaEmpleados, Empleado empleado)
        {
            return !(listaEmpleados == empleado);
        }

        public override void ToFileTxt(string folderName)
        {
            base.ToFileTxt(folderName);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + folderName + $@"\{base.nombre}-{base.apellido}-{base.dni}.txt";
            string newPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + folderName + $@"\(empleado){base.nombre}-{base.apellido}-{base.dni}.txt";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("EMPLEADO");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"TOTAL VENDIDO: ${this.TotalVentas}");
            sb.AppendLine("****************/VENTAS/*****************");
            foreach (Compra item in listaVentas)
            {
                sb.AppendLine($"** N° {item.NumeroDeCompra} ------- ${item.Total}");
            }
            sb.AppendLine($"** [ULTIMA ACTUALIZACION {DateTime.Now}]");
            sb.AppendLine("*****************************************");
            sb.AppendLine("------------------------------------------------------------------------");

            File.AppendAllText(path, sb.ToString());

            File.Delete(newPath); //borro el archivo si es que existe
            File.Move(path, newPath); //muevo el archivo (para cambiar el nombre)
        }
    }
}
