using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Administracion
    {
        static int ultimoNroCompras;
        static int ultimaIdProducto;

        static List<Producto> inventario;
        static List<Empleado> empleados;
        static List<Cliente> clientes;
        static List<Compra> ventas;
        static Dictionary<int, string> users;

        static public List<Producto> Inventario
        {
            get { return inventario; }
        }
        static public List<Compra> Ventas
        {
            get { return ventas; }
        }
        static public List<Empleado> Empleados
        {
            get { return empleados; }
        }
        static public List<Cliente> Clientes
        {
            get { return clientes; }
        }
        static public int UltimoNroCompras
        {
            get { return ultimoNroCompras; }
        }
        static public int UltimaIdProducto
        {
            get { return ultimaIdProducto; }
        }
        static public Dictionary<int, string> Users
        {
            get { return users; }
        }

        static Administracion()
        {
            inventario = new List<Producto>();
            empleados = new List<Empleado>();
            clientes = new List<Cliente>();
            ventas = new List<Compra>();
            users = new Dictionary<int, string>();
            ultimaIdProducto = 0;
            ultimoNroCompras = 0;
        }

        public static void GenerateUsers()
        {
            foreach (Empleado item in empleados)
            {
                if (!users.ContainsKey(item.Dni))
                {
                    users.Add(item.Dni, item.Apellido);
                }
            }
        }

        public static bool Add(Producto producto)
        {
            bool valorRetorno = false;
            if (inventario + producto)
            {
                if (ultimaIdProducto < producto.IdProducto)
                {
                    ultimaIdProducto = producto.IdProducto;
                }
                valorRetorno = true;
            }
            return valorRetorno;
        }
        public static bool Add(Empleado empleado)
        {
            bool valorRetorno = false;
            if (empleados + empleado)
                valorRetorno = true;
            return valorRetorno;
        }
        public static bool Add(Cliente cliente)
        {
            bool valorRetorno = false;
            if (clientes + cliente)
                valorRetorno = true;
            return valorRetorno;
        }
        public static bool Add(Compra compra)
        {
            bool valorRetorno = false;

            foreach (ItemCompra item in compra.ListaItemsCompra)
            {
                if (!item.ElProducto.RemoverStock(item.Cantidad))
                {
                    return valorRetorno;
                }
            }

            if (ventas + compra)
            {
                if (ultimoNroCompras < compra.NumeroDeCompra)
                {
                    ultimoNroCompras = compra.NumeroDeCompra;
                }
                valorRetorno = true;
            }
            return valorRetorno;
        }
        public static void Remplazar(Producto producto)
        {
            if (inventario == producto)
            {
                for (int i = 0; i < inventario.Count; i++)
                {
                    if (inventario[i].IdProducto == producto.IdProducto)
                    {
                        inventario[i] = producto;
                    }
                }
            }
        }
        public static int FindClienteIndexByDni(int dni)
        {
            int valorRetorno = -1;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Dni == dni)
                {
                    valorRetorno = i;
                    break;
                }
            }
            return valorRetorno;
        }
        public static int FindEmpleadoIndexByDni(int dni)
        {
            int valorRetorno = -1;
            for (int i = 0; i < empleados.Count; i++)
            {
                if (empleados[i].Dni == dni)
                {
                    valorRetorno = i;
                    break;
                }
            }
            return valorRetorno;
        }
        public static int FindProductoIndexById(int idProducto)
        {
            int valorRetorno = -1;
            for (int i = 0; i < inventario.Count; i++)
            {
                if (inventario[i].IdProducto == idProducto)
                {
                    valorRetorno = i;
                    break;
                }
            }
            return valorRetorno;
        }
        public static void RemoverProductoPorId(int idProducto)
        {
            int index = FindProductoIndexById(idProducto);
            if (index >= 0)
            {
                inventario.RemoveAt(index);
            }
        }
        /// <summary>
        /// hardcodea una compra de un solo producto y lo agraga a la lista de ventas y se la otorga al cliente y empleado correspondientes
        /// </summary>
        /// <param name="nmroCompra"></param>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <param name="dniEmpleado"></param>
        /// <param name="dniCliente"></param>
        public static void HardCodeCompra(int nmroCompra, Producto producto, int cantidad, int dniEmpleado, int dniCliente)
        {
            List<ItemCompra> itemCompras = new List<ItemCompra>();
            itemCompras.Add(new ItemCompra(producto, cantidad));
            Compra compra = new Compra(nmroCompra, itemCompras);
            Administracion.Add(compra);
            Administracion.empleados[Administracion.FindEmpleadoIndexByDni(dniEmpleado)].AgregarCompra(compra);
            Administracion.clientes[Administracion.FindClienteIndexByDni(dniCliente)].AgregarCompra(compra);
        }
    }
}
