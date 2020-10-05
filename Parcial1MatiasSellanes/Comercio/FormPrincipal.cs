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
using System.Runtime.InteropServices;
using System.Media;

namespace Comercio
{
    public partial class FormPrincipal : Form
    {
        List<ItemCompra> carritoDeCompras;
        double descuento;
        int dniEmpleado;
        SoundPlayer sonidoCompra;
        TimeSpan tiempoInactivo;
        public int DniEmpleado
        {
            set { dniEmpleado = value; }
        }

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            HardCode();
            carritoDeCompras = new List<ItemCompra>();
            SelecionarEmpleado(dniEmpleado);
            descuento = 0;
            this.picboxLogo.ImageLocation = @"..\img\kwik-e-mart.jpg";
            this.sonidoCompra = new SoundPlayer(@"..\sound\compra1.wav");
            this.tiempoDeActividad.Start();
            this.tiempoInactivo = TimeSpan.Zero;
            CargarAllDataGrid();
            ConfigurarDataGrids();
        }

        #region INACTIVIDAD
        /*[DllImport("User32.dll")]                                                  si se usa esta cambiar el timertick a 1000
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        internal struct LASTINPUTINFO
        {
            public uint cbSize;

            public uint dwTime;
        }
        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (GetIdleTime() > (1000*60)*2) // cierre sesion despues de 2 min
                this.DialogResult = DialogResult.Retry;
        }*/

        private void timer_Tick(object sender, EventArgs e)
        {
            this.tiempoInactivo += TimeSpan.FromSeconds(1);
            if (tiempoInactivo.TotalMinutes >= 2)   // cierre sesion despues de 2 min
            {
                this.DialogResult = DialogResult.Retry;
            }
            
        }
        private void RestearTiempoInactividad()
        {
            this.tiempoInactivo = TimeSpan.Zero; // reseteo el tiempo de inactividad
        }

        #endregion

        #region MENU_STRIP
        private void mostrarProductosConBajoStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarLista mostrarLista = new FormMostrarLista();
            mostrarLista.ListaDtgv.DataSource = Producto.SubListPorStock(Administracion.Inventario, 0, 10);
            mostrarLista.BotonAgregar.Enabled = false;
            mostrarLista.BotonDetalles.Enabled = false;
            mostrarLista.Text = "PRODUCTOS CON MENOS DE 10 EN STOCK";
            mostrarLista.ShowDialog();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void añadirProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto formAltaPorducto = new FormProducto();
            formAltaPorducto.Text = "AGREGAR PRODUCTO";
            if (formAltaPorducto.ShowDialog() == DialogResult.OK)
            {
                if (!Administracion.Add(formAltaPorducto.Producto))
                {
                    MessageBox.Show("No se pudo agregar el producto");
                }
                CargarDataGrid(Administracion.Inventario);
            }
        }
        private void listaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarLista mostrarLista = new FormMostrarLista();
            mostrarLista.ListaDtgv.DataSource = Administracion.Empleados;
            mostrarLista.BotonAgregar.Enabled = true;
            mostrarLista.BotonDetalles.Enabled = true;
            mostrarLista.Text = "EMPLEADOS";
            if (mostrarLista.ShowDialog() == DialogResult.Yes) // si se apreta el boton agregar
            {
                FormPersona agregarPersona = new FormPersona("Empleado");
                if (agregarPersona.ShowDialog() == DialogResult.OK) //cuando apretan aceptar en el FormPersona
                {
                    listaEmpleadosToolStripMenuItem_Click(sender, e);
                }
            }
            else if (mostrarLista.DialogResult == DialogResult.No) //si apretan el boton detalles
            {
                mostrarLista.ListaDtgv.DataSource = ((Empleado)(mostrarLista.Dato)).ListaVentas;
                mostrarLista.BotonAgregar.Enabled = false;
                mostrarLista.Text = "LISTA DE VENTAS";
                if (mostrarLista.ShowDialog() == DialogResult.OK) //boton salir del FormMostrarLista
                {
                    listaEmpleadosToolStripMenuItem_Click(sender, e);
                }
                else if (mostrarLista.DialogResult == DialogResult.No) //si apreta detalles de compra
                {
                    mostrarLista.ListaDtgv.DataSource = ((Compra)(mostrarLista.Dato)).ListaItemsCompra;
                    mostrarLista.BotonAgregar.Enabled = false;
                    mostrarLista.BotonDetalles.Enabled = false;
                    mostrarLista.Text = "DETALLES DE COMPRA";
                    if (mostrarLista.ShowDialog() == DialogResult.OK) //boton salir del FormMostrarLista
                    {
                        listaEmpleadosToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }
        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarLista mostrarLista = new FormMostrarLista();
            mostrarLista.ListaDtgv.DataSource = Administracion.Clientes;
            mostrarLista.BotonAgregar.Enabled = true;
            mostrarLista.Text = "LISTA CLIENTES";
            if (mostrarLista.ShowDialog() == DialogResult.Yes) //si presiona agregar
            {
                FormPersona agregarPersona = new FormPersona("Cliente");
                if (agregarPersona.ShowDialog() == DialogResult.OK) //aceptar en formPersona
                {
                    listaClientesToolStripMenuItem_Click(sender, e);
                }
            }
        }
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersona agregarPersona = new FormPersona("Cliente");
            agregarPersona.Text = "AGREGAR CLIENTE";
            if (agregarPersona.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cliente agregado correctamente");
            }
        }

        private void agregarEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPersona agregarPersona = new FormPersona("Empleado");
            agregarPersona.Text = "AGREGAR EMPLEADO";
            if (agregarPersona.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Empleado agregado correctamente");
            }
        }
        private void totalEnStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se encuentran {Producto.TotalStockEnLista(Administracion.Inventario)} productos alamacenados");
        }
        private void menuStripPrincipal_MouseEnter(object sender, EventArgs e)
        {
            this.menuStripPrincipal.Visible = true;
            RestearTiempoInactividad();
            BorrarVuelvaProntoss();
        }
        private void menuStripPrincipal_MouseLeave(object sender, EventArgs e)
        {
            this.menuStripPrincipal.Visible = false;
            RestearTiempoInactividad();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        #endregion

        #region DATAGRIDS
        private void dtgvPrincipal_MouseEnter(object sender, EventArgs e)
        {
            BorrarVuelvaProntoss();
            RestearTiempoInactividad();
        }



        private void ConfigurarDataGrids()
        {
            this.dtgvPrincipal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvCarrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.dtgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //this.dtgvCarrito.Enabled = false; //rompe cuando hacen click si el control esta habilitado (FIXED)
        }

        private void dtgvCarrito_DataSourceChanged(object sender, EventArgs e)
        {
            RestearTiempoInactividad();
            this.btnResetearCarro.Enabled = false;
            this.btnRealizarVenta.Enabled = false;
            if (dtgvCarrito.Rows.Count > 0)
            {
                this.btnResetearCarro.Enabled = true;
                this.btnRealizarVenta.Enabled = true;
            }
        }
        public void CargarDataGrid(List<Producto> listaProductos)
        {
            this.dtgvPrincipal.DataSource = null;
            if(listaProductos.Count > 0)
                this.dtgvPrincipal.DataSource = listaProductos;
        }
        public void CargarDataGrid(List<ItemCompra> listaItemsCompra)
        {
            this.dtgvCarrito.DataSource = null;
            if(listaItemsCompra.Count > 0)
                this.dtgvCarrito.DataSource = listaItemsCompra;
        }
        public void CargarAllDataGrid()
        {
            RestearTiempoInactividad();
            CargarDataGrid(Administracion.Inventario);
            CargarDataGrid(this.carritoDeCompras);
        }
        #endregion

        #region BOTONES

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RestearTiempoInactividad();
            if (this.dtgvPrincipal.SelectedRows.Count > 0)
            {
                FormProducto formProducto = new FormProducto();
                formProducto.Producto = (Producto)this.dtgvPrincipal.SelectedRows[0].DataBoundItem;
                formProducto.TxbIdProducto.Enabled = false;
                formProducto.BtnEliminar.Visible = true;
                formProducto.Text = "MODIFICAR PRODUCTO";
                if (formProducto.ShowDialog() == DialogResult.OK)
                {
                    Administracion.Remplazar(formProducto.Producto);
                    CargarDataGrid(Administracion.Inventario);
                }
            }
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            RestearTiempoInactividad();
            if (carritoDeCompras.Count > 0 && this.txbDniCliente.BackColor != Color.Red)
            {
                Compra compra = new Compra((Administracion.UltimoNroCompras) + 1, carritoDeCompras);
                compra.ReducirTotal(compra.Total * descuento);
                if (Administracion.Add(compra))
                {
                    if (Administracion.FindClienteIndexByDni(Validaciones.StringToInt(this.txbDniCliente.Text)) == -1 || (Validaciones.StringToInt(this.txbDniCliente.Text) == 0))
                    {
                        //preguntar si crear nuevo cliente o no (si no agregarlo a anonimo)
                        if (Validaciones.StringToInt(this.txbDniCliente.Text) == 0 || MessageBox.Show("El DNI no se encuantra registrado en clientes desea crear uno nuevo", "CLIENTE NO REGISTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            Administracion.Clientes[Administracion.FindClienteIndexByDni(0)].AgregarCompra(compra); //se agrega la compra al cliente con dni 0 (anonimo)
                        }
                        else
                        {
                            FormPersona formPersona = new FormPersona("Cliente");
                            if (formPersona.ShowDialog() == DialogResult.OK)
                            {
                                MessageBox.Show("Cliente agregado correctamente");
                            }
                        }
                    }
                    else
                    {
                        Administracion.Clientes[Administracion.FindClienteIndexByDni(Validaciones.StringToInt(this.txbDniCliente.Text))].AgregarCompra(compra); //agrego compra a un cliente existente mediante su dni
                    }
                    Administracion.Empleados[Administracion.FindEmpleadoIndexByDni(Validaciones.StringToInt(this.txbEmpleadoDni.Text))].AgregarCompra(compra); //agergo compra al empleado actual
                    this.lblVuelvaProntoss.Visible = true;
                    carritoDeCompras = new List<ItemCompra>(); //limpio el carritoDeCompras
                    sonidoCompra.Play();
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
            if (this.dtgvPrincipal.SelectedRows.Count > 0) //solo agrega un solo producto que es el primer selecionado (cambiar para poder agragar de a muchos)
            {
                //carritoDeCompras.Add(new ItemCompra((Producto)this.dtgvPrincipal.SelectedRows[0].DataBoundItem, Validaciones.ValidarInt(this.txbCantidad.Text, 1)));
                for (int i = 0; i < this.dtgvPrincipal.SelectedRows.Count; i++)
                {
                    if (!(carritoDeCompras + new ItemCompra((Producto)this.dtgvPrincipal.SelectedRows[i].DataBoundItem, Validaciones.ValidarInt(this.txbCantidad.Text, 1)))) { } //agrego itemPorducto a lista
                }
                CargarDataGrid(carritoDeCompras);
            }
        }

        private void btnResetearCarro_Click(object sender, EventArgs e)
        {
            carritoDeCompras.Clear();
            CargarDataGrid(carritoDeCompras);
        }
        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            RestearTiempoInactividad();
            FormMostrarLista formMostrar = new FormMostrarLista();
            formMostrar.ListaDtgv.DataSource = Administracion.Clientes;
            formMostrar.BotonAgregar.Enabled = true;
            formMostrar.Text = "SELECIONE UN CLIENTE Y AGREGELO A LA COMPRA";
            if (formMostrar.ShowDialog() == DialogResult.Yes) //boton agregar
            {
                this.txbDniCliente.Text = (((Cliente)(formMostrar.Dato)).Dni).ToString();
            }
        }

        #endregion

        #region TEXTBOX

        private void txbDniCliente_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            if (!Validaciones.VerificarNumeros(((TextBox)sender).Text))
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }
        private void txbDniCliente_TextChanged(object sender, EventArgs e)
        {
            this.lblElDescuento.Text = "0";
            if (Administracion.FindClienteIndexByDni(Validaciones.StringToInt(this.txbDniCliente.Text)) != -1)
            {
                Cliente cliente = Administracion.Clientes[Administracion.FindClienteIndexByDni(Validaciones.StringToInt(this.txbDniCliente.Text))];
                if ("Simpson" == cliente.Apellido) //chequea si es de apellido Simpson
                {
                    this.lblElDescuento.Text = "13";
                }
            }

            this.descuento = Validaciones.StringToDouble(this.lblElDescuento.Text) / 100;
        }

        #endregion

        private void HardCode()
        {
            //PRODUCTOS
            Administracion.Add(new Producto(5230, "galletas", TipoProducto.Seco, 15, 45));
            Administracion.Add(new Producto(5233, "chocolate", TipoProducto.Seco, 30, 50));
            Administracion.Add(new Producto(5235, "duraznos laterraza (lata 500g)", TipoProducto.Enlatado, 200, 150));
            Administracion.Add(new Producto(5238, "chocolate agila", TipoProducto.Seco, 40, 5));
            Administracion.Add(new Producto(5289, "caramelos sancor", TipoProducto.Seco, 15, 30));
            Administracion.Add(new Producto(5290, "cola springfield", TipoProducto.Bebida, 60, 450));
            Administracion.Add(new Producto(5291, "radioactive cola", TipoProducto.Bebida, 80, 150));
            Administracion.Add(new Producto(5292, "duff beer", TipoProducto.BebidaAlcoholica, 75, 1000));
            Administracion.Add(new Producto(5293, "limpiatodo spring", TipoProducto.Limpieza, 150, 300));
            Administracion.Add(new Producto(5294, "churrasco spidercerdo (bandeja 300g)", TipoProducto.Carne, 200, 50));
            Administracion.Add(new Producto(5295, "churrasco spidercerdo (bandeja 700g)", TipoProducto.Carne, 370, 25));
            Administracion.Add(new Producto(4250, "manzanas springfield", TipoProducto.Vegetal, 20, 150));
            Administracion.Add(new Producto(4252, "queso (bandeja 250g)", TipoProducto.Lacteo, 200, 30));
            ///////////////////////////////////////////////////////////////////////////////////////////
           
            //CLIENTES
            Administracion.Add(new Cliente("Anonimo", "Anonimo", 0));
            Administracion.Add(new Cliente("Homero", "Simpson", 12341234));
            Administracion.Add(new Cliente("Marge", "Simpson", 12348234));
            Administracion.Add(new Cliente("Bart", "Simpson", 122151234));
            Administracion.Add(new Cliente("Detart", "Filatro", 122833234));
            Administracion.Add(new Cliente("Marcelo", "Parezco", 456833234));

            /////////////////////////////////////////////////////////////////////////////
           
            //COMPRAS
            Administracion.HardCodeCompra(100, Administracion.Inventario[1], 3, 123456789, 0);
            Administracion.HardCodeCompra(250, Administracion.Inventario[0], 4, 123456789, 0);
            Administracion.HardCodeCompra(354, Administracion.Inventario[5], 8, 123456789, 0);
            Administracion.HardCodeCompra(355, Administracion.Inventario[6], 20, 222222222, 0);
            Administracion.HardCodeCompra(355, Administracion.Inventario[3], 8, 222222222, 0);
            Administracion.HardCodeCompra(356, Administracion.Inventario[4], 5, 333333333, 0);
            Administracion.HardCodeCompra(357, Administracion.Inventario[8], 3, 333333333, 0);
        }
        private void BorrarVuelvaProntoss()
        {
            if (this.lblVuelvaProntoss.Visible == true)
            {
                this.lblVuelvaProntoss.Visible = false;
            }
        }
        private void SelecionarEmpleado(int dni)
        {
            int index = Administracion.FindEmpleadoIndexByDni(dni);
            if (index == -1)
            {
                index = 0;
            }
            this.txbEmpleadoNombre.Text = $"{Administracion.Empleados[index].Nombre} {Administracion.Empleados[index].Apellido}";
            this.txbEmpleadoDni.Text = $"{Administracion.Empleados[index].Dni}";
        }
    }
}
