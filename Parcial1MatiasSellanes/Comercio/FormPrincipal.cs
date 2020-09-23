using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FormPrincipal : Form
    {
        List<ItemCompra> carritoDeCompras;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto formAltaPorducto = new FormProducto();
            if (formAltaPorducto.ShowDialog() == DialogResult.OK)
            {
                Administracion.Add(formAltaPorducto.Producto);
                CargarDataGrid(Administracion.Inventario);
            }
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            HardCodeProductos();
            carritoDeCompras = new List<ItemCompra>();
            CargarAllDataGrid();
            
        }
        private void HardCodeProductos()
        {
            Administracion.Add(new Producto(5230, "galletas", TipoProducto.Seco, 20, 100));
        }
        
        public void CargarDataGrid(List<Producto> listaProductos)
        {
            this.dtgvPrincipal.DataSource = null;
            this.dtgvPrincipal.DataSource = listaProductos;
        }
        public void CargarDataGrid(List<ItemCompra> listaItemsCompra)
        {
            this.dtgvCarrito.DataSource = null;
            this.dtgvCarrito.DataSource = listaItemsCompra;
        }
        public void CargarAllDataGrid()
        {
            CargarDataGrid(Administracion.Inventario);
            CargarDataGrid(this.carritoDeCompras);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtgvPrincipal.AreAllCellsSelected(true))
            {
                FormProducto formProducto = new FormProducto();
                formProducto.Producto = (Producto)this.dtgvPrincipal.SelectedRows[0].DataBoundItem;
                formProducto.TxbIdProducto.Enabled = false;
                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    Administracion.Remplazar(formProducto.Producto);
                    CargarDataGrid(Administracion.Inventario);
                }
            }



        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (carritoDeCompras.Count > 0)
            {
                if (Administracion.Add(new Compra(Administracion.UltimoNroCompras, carritoDeCompras)))
                {
                    carritoDeCompras.Clear();
                    CargarAllDataGrid();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la compra!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAgregarAlCarro_Click(object sender, EventArgs e)
        {
            if (this.dtgvPrincipal.AreAllCellsSelected(true))
            {
                carritoDeCompras.Add(new ItemCompra((Producto)this.dtgvPrincipal.SelectedRows[0].DataBoundItem, Validaciones.ValidarInt(this.txbCantidad.Text, 1)));
                CargarDataGrid(carritoDeCompras);
            }
        }

        private void btnResetearCarro_Click(object sender, EventArgs e)
        {
            carritoDeCompras.Clear();
            CargarDataGrid(carritoDeCompras);
        }
    }
}
