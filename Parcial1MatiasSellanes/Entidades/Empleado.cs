using System;
using System.Collections.Generic;
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
    }
}
