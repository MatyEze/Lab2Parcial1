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
                this.txbDescripcion.Text = producto.Decripcion;
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
    }
}
