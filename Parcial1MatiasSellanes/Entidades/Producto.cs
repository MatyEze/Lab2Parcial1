using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Producto
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        int idProducto;
        string descripcion;
        TipoProducto tipo;
        double precioUnidad;
        int stock;

        #region Propiedades
        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
        }
        public string Decripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public TipoProducto Tipo
        {
            get
            {
                return this.tipo;
            }
        }
        public double PrecioUnidad
        {
            get
            {
                return this.precioUnidad;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
        }
        #endregion

        public Producto(int idProducto, string descripcion, TipoProducto tipo, double precioUnidad, int stock)
        {
            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.precioUnidad = precioUnidad;
            this.stock = stock;
        }

        public static bool operator +(List<Producto> listaProductos, Producto producto)
        {
            bool valorRetorno = false;
            if (listaProductos != producto)
            {
                listaProductos.Add(producto);
                valorRetorno = true;
            }
            return valorRetorno;
        }

        public static bool operator ==(List<Producto> listaProductos, Producto producto)
        {
            bool valorRetorno = false;
            foreach (Producto item in listaProductos)
            {
                if (item.idProducto == producto.idProducto)
                {
                    valorRetorno = true;
                }
            }
            return valorRetorno;
        }

        public static bool operator !=(List<Producto> listaProductos, Producto producto)
        {
            return !(listaProductos == producto);
        }

        public bool RemoverStock(int remover)
        {
            bool valorRetorno = false;
            if (this.stock - remover >= 0)
            {
                this.stock -= remover;
                valorRetorno = true;
            }
            return valorRetorno;
        }

        public static List<Producto> SubListPorStock(List<Producto> lista, int min)
        {
            List<Producto> subList = new List<Producto>();
            foreach (Producto item in lista)
            {
                if (item.stock > min)
                {
                    if(subList + item) { }
                }
            }
            return subList;
        }

        public static List<Producto> SubListPorStock(List<Producto> lista, int min, int max)
        {
            List<Producto> subList = new List<Producto>();
            foreach (Producto item in lista)
            {
                if (item.stock >= min && item.stock <= max)
                {
                    if (subList + item) { }
                }
            }
            return subList;
        }
    }
}
