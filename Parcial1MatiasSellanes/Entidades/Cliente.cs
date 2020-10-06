using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        DateTime fechaRegitro;

        /*public List<Compra> ListaCompras
        {
            get { return listaCompras; }
        }*/

        public Cliente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            listaCompras = new List<Compra>();
            fechaRegitro = DateTime.Now;
        }

        public void AgregarCompra(Compra compra)
        {
            if (listaCompras + compra) { };
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

        public override void ToFileTxt(string folderName)
        {
            base.ToFileTxt(folderName);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + folderName + $@"\{base.nombre}-{base.apellido}-{base.dni}.txt";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLIENTE REGISTRADO EL {this.fechaRegitro}");

            File.AppendAllText(path, sb.ToString());
        }
    }
}
