using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class ItemCompra
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        Producto elProducto;
        int cantidad;
        double precioUnidadVenta;
        double precioTotal;

        #region Propiedades
        public Producto ElProducto
        {
            get
            {
                return elProducto;
            }
        }
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                this.cantidad = value;
                this.precioTotal = precioUnidadVenta * cantidad; // como se llame al set se recalcula el total para evitar problemas
            }
        }
        public double PrecioUnidadVenta
        {
            get
            {
                return precioUnidadVenta;
            }
        }
        public double PrecioTotal
        {
            get
            {
                return precioTotal;
            }
        }
        #endregion

        public ItemCompra(Producto producto, int cantidad)
        {
            this.elProducto = producto;
            this.cantidad = cantidad;
            this.precioUnidadVenta = producto.PrecioUnidad;
            this.precioTotal = precioUnidadVenta * cantidad;
        }

        public static bool operator +(List<ItemCompra> listaItemsDeCompra, ItemCompra itemCompra)
        {
            bool valorRetorno = false;
            if (listaItemsDeCompra != itemCompra)
            {
                listaItemsDeCompra.Add(itemCompra);
                valorRetorno = true;
            }
            else
            {
                foreach (ItemCompra item in listaItemsDeCompra)
                {
                    if (item.elProducto.IdProducto == itemCompra.elProducto.IdProducto)
                    {
                        item.Cantidad += itemCompra.Cantidad;
                        break;
                    }
                }
            }
            return valorRetorno;
        }

        public static bool operator ==(List<ItemCompra> listaItemsDeCompra, ItemCompra itemCompra)
        {
            bool valorRetorno = false;
            foreach (ItemCompra item in listaItemsDeCompra)
            {
                if (item.ElProducto.IdProducto == itemCompra.ElProducto.IdProducto)
                {
                    valorRetorno = true;
                }
            }
            return valorRetorno;
        }

        public static bool operator !=(List<ItemCompra> listaItemsDeCompra, ItemCompra itemCompra)
        {
            return !(listaItemsDeCompra == itemCompra);
        }

    }
}
