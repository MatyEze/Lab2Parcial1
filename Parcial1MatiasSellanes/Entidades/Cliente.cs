using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Cliente : Persona
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        List<Compra> listaCompras;

        public Cliente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            listaCompras = new List<Compra>();
        }

        public static bool operator +(List<Cliente> listaClientes, Cliente cliente)
        {
            bool valorRetorno=false;
            if (listaClientes != cliente)
            {
                listaClientes.Add(cliente);
                valorRetorno = true;
            }
            return valorRetorno;
        }

        public static bool operator ==(List<Cliente> listaClientes, Cliente cliente)
        {
            bool valorRetorno = false;
            foreach (Cliente item in listaClientes)
            {
                if (item.dni == cliente.dni)
                {
                    valorRetorno = true;
                }
            }
            return valorRetorno;
        }

        public static bool operator !=(List<Cliente> listaClientes, Cliente cliente)
        {
            return !(listaClientes == cliente);
        }
    }
}
