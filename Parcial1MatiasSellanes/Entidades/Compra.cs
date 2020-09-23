using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Compra
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        int numeroDeCompra;
        List<ItemCompra> listaItemsCompra;
        double total;

        #region Propiedades
        public int NumeroDeCompra
        {
            get
            {
                return this.numeroDeCompra;
            }
        }
        public List<ItemCompra> ListaItemsCompra
        {
            get
            {
                return this.listaItemsCompra;
            }
        }
        public double Total
        {
            get
            {
                return this.total;
            }
        }
        #endregion

        public Compra(int numeroDeCompra, List<ItemCompra> listaItemsCompra)
        {
            this.numeroDeCompra = numeroDeCompra;
            this.listaItemsCompra = listaItemsCompra;
            this.total = CalcularTotalDeCompra(listaItemsCompra);

        }

        static public double CalcularTotalDeCompra(List<ItemCompra> listaItemsCompra)
        {
            double total = 0;
            foreach (ItemCompra item in listaItemsCompra)
            {
                total += item.PrecioTotal;
            }
            return total;
        }

        public static bool operator +(List<Compra> listaCompras, Compra compra)
        {
            bool valorRetorno = false;
            if (listaCompras != compra)
            {
                listaCompras.Add(compra);
                valorRetorno = true;
            }
            return valorRetorno;
        }

        public static bool operator ==(List<Compra> listaCompras, Compra compra)
        {
            bool valorRetorno = false;
            foreach (Compra item in listaCompras)
            {
                if (item.numeroDeCompra == compra.numeroDeCompra)
                {
                    valorRetorno = true;
                }
            }
            return valorRetorno;
        }

        public static bool operator !=(List<Compra> listaCompras, Compra compra)
        {
            return !(listaCompras == compra);
        }
    }
}
