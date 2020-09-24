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
            HardCode();
            carritoDeCompras = new List<ItemCompra>();
            this.txbEmpleadoNombre.Text = $"{Administracion.Empleados[0].Nombre} {Administracion.Empleados[0].Apellido}";
            this.txbEmpleadoDni.Text = $"{Administracion.Empleados[0].Dni}";
            CargarAllDataGrid();

        }
        private void HardCode()
        {
            Administracion.Add(new Producto(5230, "galletas", TipoProducto.Seco, 250, 45));
            Administracion.Add(new Producto(5233, "chocolate", TipoProducto.Seco, 300, 50));
            Administracion.Add(new Producto(5235, "duraznos laterraza", TipoProducto.Enlatado, 80, 150));

            Administracion.Add(new Empleado("Matias", "Sellanes", 123456789));

            Administracion.Add(new Cliente("Anonimo", "Anonimo", 0));
            Administracion.Add(new Cliente("Homero", "Simpson", 12341234));
            Administracion.Add(new Cliente("Marge", "Simpson", 12348234));
            Administracion.Add(new Cliente("Bart", "Simpson", 122151234));
            Administracion.Add(new Cliente("Detart", "Filatro", 122833234));
            Administracion.Add(new Cliente("Marcelo", "Parezco", 456833234));
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
            if (this.dtgvPrincipal.SelectedRows.Count > 0)
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
                Compra compra = new Compra(Administracion.UltimoNroCompras, carritoDeCompras);
                if (Administracion.Add(compra))
                {
                    if (Administracion.FindClienteIndexByDni(Validaciones.StringToInt(this.txbDniCliente.Text)) == -1 || (Validaciones.StringToInt(this.txbDniCliente.Text) == 0))
                    {
                        //preguntar si crear nuevo cliente o no (si no agregarlo a anonimo)
                    }
                    else
                    {
                        Administracion.Clientes[Administracion.FindClienteIndexByDni(Validaciones.StringToInt(this.txbDniCliente.Text))].AgregarCompra(compra); //agrego compra a un cliente existente mediante su dni
                    }
                    Administracion.Empleados[Administracion.FindEmpleadoIndexByDni(Validaciones.StringToInt(this.txbEmpleadoDni.Text))].AgregarCompra(compra); //agergo compra al empleado actual
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
            if (this.dtgvPrincipal.SelectedRows.Count > 0)
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

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarLista mostrarLista = new FormMostrarLista();
            mostrarLista.ListaDtgv.DataSource = Administracion.Empleados;
            if (mostrarLista.ShowDialog()==DialogResult.Yes)
            {
                listaToolStripMenuItem_Click(sender, e);
            }
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarLista mostrarLista = new FormMostrarLista();
            mostrarLista.ListaDtgv.DataSource = Administracion.Clientes;
            if (mostrarLista.ShowDialog() == DialogResult.Yes)
            {
                listaToolStripMenuItem_Click(sender, e);
            }
        }

        private void dtgvCarrito_DataSourceChanged(object sender, EventArgs e)
        {
            this.btnResetearCarro.Enabled = false;
            this.btnRealizarVenta.Enabled = false;
            if (dtgvCarrito.Rows.Count > 0)
            {
                this.btnResetearCarro.Enabled = true;
                this.btnRealizarVenta.Enabled = true;
            }
        }
    }
}
