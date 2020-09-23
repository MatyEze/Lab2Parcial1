using System;
using System.Collections.Generic;
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

        static public List<Producto> Inventario
        {
            get { return inventario; }
        }

        static public int UltimoNroCompras
        {
            get { return ultimoNroCompras+1; }
        }

        static Administracion()
        {
            inventario = new List<Producto>();
            empleados = new List<Empleado>();
            clientes = new List<Cliente>();
            ventas = new List<Compra>();
            ultimaIdProducto = 0;
            ultimoNroCompras = 0;
        }

        public static bool Add(Producto producto)
        {
            bool valorRetorno=false;
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
            if (ventas + compra)
            {
                if (ultimoNroCompras < compra.NumeroDeCompra)
                {
                    ultimoNroCompras = compra.NumeroDeCompra;
                }
                foreach (ItemCompra item in compra.ListaItemsCompra)
                {
                    if (!item.ElProducto.RemoverStock(item.Cantidad))
                    {
                        return valorRetorno;
                    }
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
    }
}
