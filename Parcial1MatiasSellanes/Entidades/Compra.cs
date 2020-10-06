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
        /// <summary>
        /// reduce el total de la compra dependiendo del valor pasado, si el total queda en un valor negativo se setea en 0
        /// </summary>
        /// <param name="reducir"></param>
        public void ReducirTotal(double reducir)
        {
            this.total -= reducir;
            if (this.total < 0)
            {
                this.total = 0;
            }
        }

        public void GenerarTicket(string folderName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string nombreArchivo = $"{this.numeroDeCompra}---{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}---{DateTime.Now.Hour}hs{DateTime.Now.Minute}m";
            if (folderName == null || folderName == string.Empty)
            {
                path += @"\" + nombreArchivo + ".txt";
            }
            else
            {
                path += @"\" + folderName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path += @"\" + nombreArchivo + ".txt";
            }

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"COMPRA {this.numeroDeCompra}");
                    sw.WriteLine($"**********************************************");
                    foreach (ItemCompra item in listaItemsCompra)
                    {
                        sw.WriteLine($"* {item.ElProducto.ToString()} (${item.PrecioUnidadVenta} p/u) x {item.Cantidad} ---------- ${item.PrecioTotal}");
                    }
                    sw.WriteLine($"* TOTAL : ------------------------ ${this.total}");
                    sw.WriteLine($"**********************************************");
                }
            }
        }
    }
}
