using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FormProducto : Form
    {
        private Producto producto;
        public TextBox TxbIdProducto
        {
            get { return this.txbIdProducto; }
        }
        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public Button BtnEliminar
        {
            get { return this.btnEliminar; }
        }

        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            this.cmbTipoProducto.DataSource = Enum.GetValues(typeof(TipoProducto));
            if (producto != null)
            {
                this.txbIdProducto.Text = producto.IdProducto.ToString();
                this.txbDescripcion.Text = producto.Descripcion;
                this.txbPrecioUnidad.Text = producto.PrecioUnidad.ToString();
                this.txbStock.Text = producto.Stock.ToString();
                this.cmbTipoProducto.SelectedItem = producto.Tipo;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            producto = new Producto(Validaciones.StringToInt(this.txbIdProducto.Text),
                this.txbDescripcion.Text,
                (TipoProducto)this.cmbTipoProducto.SelectedItem,
                Validaciones.StringToDouble(this.txbPrecioUnidad.Text),
                Validaciones.StringToInt(this.txbStock.Text));


            this.DialogResult = DialogResult.OK;
        }

        private void txbIdProducto_Leave(object sender, EventArgs e)
        {
            if (this.txbIdProducto.Text == string.Empty)
            {
                this.txbIdProducto.Text = (Administracion.UltimaIdProducto + 1).ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere eliminar este producto?\nEl cambio sera permanente", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //eliminar producto
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
