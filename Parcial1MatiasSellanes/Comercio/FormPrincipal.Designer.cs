namespace Comercio
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProductosConBajoStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalEnStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarAlCarro = new System.Windows.Forms.Button();
            this.dtgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnResetearCarro = new System.Windows.Forms.Button();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbDniCliente = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.txbEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txbEmpleadoDni = new System.Windows.Forms.TextBox();
            this.btnElegirexistente = new System.Windows.Forms.Button();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSignoDescuento = new System.Windows.Forms.Label();
            this.lblElDescuento = new System.Windows.Forms.Label();
            this.lblVuelvaProntoss = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.tiempoDeActividad = new System.Windows.Forms.Timer(this.components);
            this.picBoxMenuStrip = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.cientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.sesionToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1483, 36);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            this.menuStripPrincipal.MouseEnter += new System.EventHandler(this.menuStripPrincipal_MouseEnter);
            this.menuStripPrincipal.MouseLeave += new System.EventHandler(this.menuStripPrincipal_MouseLeave);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.mostrarProductosConBajoStockToolStripMenuItem,
            this.totalEnStockToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(394, 32);
            this.añadirToolStripMenuItem.Text = "Agregar";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirProductoToolStripMenuItem_Click);
            // 
            // mostrarProductosConBajoStockToolStripMenuItem
            // 
            this.mostrarProductosConBajoStockToolStripMenuItem.Name = "mostrarProductosConBajoStockToolStripMenuItem";
            this.mostrarProductosConBajoStockToolStripMenuItem.Size = new System.Drawing.Size(394, 32);
            this.mostrarProductosConBajoStockToolStripMenuItem.Text = "Mostrar productos con bajo stock";
            this.mostrarProductosConBajoStockToolStripMenuItem.Click += new System.EventHandler(this.mostrarProductosConBajoStockToolStripMenuItem_Click);
            // 
            // totalEnStockToolStripMenuItem
            // 
            this.totalEnStockToolStripMenuItem.Name = "totalEnStockToolStripMenuItem";
            this.totalEnStockToolStripMenuItem.Size = new System.Drawing.Size(394, 32);
            this.totalEnStockToolStripMenuItem.Text = "Total en stock";
            this.totalEnStockToolStripMenuItem.Click += new System.EventHandler(this.totalEnStockToolStripMenuItem_Click);
            // 
            // cientesToolStripMenuItem
            // 
            this.cientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.listaClientesToolStripMenuItem});
            this.cientesToolStripMenuItem.Name = "cientesToolStripMenuItem";
            this.cientesToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.cientesToolStripMenuItem.Text = "Cientes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.listaClientesToolStripMenuItem.Text = "Lista clientes";
            this.listaClientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.listaToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(238, 32);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.listaToolStripMenuItem.Text = "Lista empleados";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaEmpleadosToolStripMenuItem_Click);
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(210, 32);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dtgvPrincipal
            // 
            this.dtgvPrincipal.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrincipal.Location = new System.Drawing.Point(15, 177);
            this.dtgvPrincipal.Name = "dtgvPrincipal";
            this.dtgvPrincipal.RowHeadersWidth = 51;
            this.dtgvPrincipal.RowTemplate.Height = 24;
            this.dtgvPrincipal.Size = new System.Drawing.Size(778, 481);
            this.dtgvPrincipal.TabIndex = 1;
            this.dtgvPrincipal.MouseEnter += new System.EventHandler(this.dtgvPrincipal_MouseEnter);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(15, 664);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(192, 53);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarAlCarro
            // 
            this.btnAgregarAlCarro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarAlCarro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarAlCarro.Location = new System.Drawing.Point(231, 664);
            this.btnAgregarAlCarro.Name = "btnAgregarAlCarro";
            this.btnAgregarAlCarro.Size = new System.Drawing.Size(208, 53);
            this.btnAgregarAlCarro.TabIndex = 3;
            this.btnAgregarAlCarro.Text = "AGREGAR AL CARRO";
            this.btnAgregarAlCarro.UseVisualStyleBackColor = false;
            this.btnAgregarAlCarro.Click += new System.EventHandler(this.btnAgregarAlCarro_Click);
            // 
            // dtgvCarrito
            // 
            this.dtgvCarrito.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarrito.Location = new System.Drawing.Point(843, 177);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.RowHeadersWidth = 51;
            this.dtgvCarrito.RowTemplate.Height = 24;
            this.dtgvCarrito.Size = new System.Drawing.Size(608, 307);
            this.dtgvCarrito.TabIndex = 4;
            this.dtgvCarrito.DataSourceChanged += new System.EventHandler(this.dtgvCarrito_DataSourceChanged);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRealizarVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRealizarVenta.Location = new System.Drawing.Point(1067, 538);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(208, 54);
            this.btnRealizarVenta.TabIndex = 5;
            this.btnRealizarVenta.Text = "REALIZAR VENTA";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnResetearCarro
            // 
            this.btnResetearCarro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetearCarro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetearCarro.Location = new System.Drawing.Point(841, 538);
            this.btnResetearCarro.Name = "btnResetearCarro";
            this.btnResetearCarro.Size = new System.Drawing.Size(208, 54);
            this.btnResetearCarro.TabIndex = 6;
            this.btnResetearCarro.Text = "RESETAR CARRITO";
            this.btnResetearCarro.UseVisualStyleBackColor = false;
            this.btnResetearCarro.Click += new System.EventHandler(this.btnResetearCarro_Click);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(445, 664);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(85, 53);
            this.txbCantidad.TabIndex = 7;
            // 
            // txbDniCliente
            // 
            this.txbDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDniCliente.Location = new System.Drawing.Point(1006, 498);
            this.txbDniCliente.Name = "txbDniCliente";
            this.txbDniCliente.Size = new System.Drawing.Size(269, 34);
            this.txbDniCliente.TabIndex = 8;
            this.txbDniCliente.TextChanged += new System.EventHandler(this.txbDniCliente_TextChanged);
            this.txbDniCliente.Leave += new System.EventHandler(this.txbDniCliente_Leave);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(838, 501);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(162, 29);
            this.lblDniCliente.TabIndex = 9;
            this.lblDniCliente.Text = "DNI CLIENTE";
            // 
            // txbEmpleadoNombre
            // 
            this.txbEmpleadoNombre.Enabled = false;
            this.txbEmpleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleadoNombre.Location = new System.Drawing.Point(942, 716);
            this.txbEmpleadoNombre.Name = "txbEmpleadoNombre";
            this.txbEmpleadoNombre.Size = new System.Drawing.Size(275, 34);
            this.txbEmpleadoNombre.TabIndex = 10;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(791, 719);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(145, 29);
            this.lblEmpleado.TabIndex = 11;
            this.lblEmpleado.Text = "EMPLEADO";
            // 
            // txbEmpleadoDni
            // 
            this.txbEmpleadoDni.Enabled = false;
            this.txbEmpleadoDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleadoDni.Location = new System.Drawing.Point(1223, 716);
            this.txbEmpleadoDni.Name = "txbEmpleadoDni";
            this.txbEmpleadoDni.Size = new System.Drawing.Size(216, 34);
            this.txbEmpleadoDni.TabIndex = 12;
            // 
            // btnElegirexistente
            // 
            this.btnElegirexistente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnElegirexistente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElegirexistente.Location = new System.Drawing.Point(1281, 498);
            this.btnElegirexistente.Name = "btnElegirexistente";
            this.btnElegirexistente.Size = new System.Drawing.Size(170, 34);
            this.btnElegirexistente.TabIndex = 13;
            this.btnElegirexistente.Text = "Elegir existente";
            this.btnElegirexistente.UseVisualStyleBackColor = false;
            this.btnElegirexistente.Click += new System.EventHandler(this.btnClienteExistente_Click);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(1062, 595);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(174, 29);
            this.lblDescuento.TabIndex = 14;
            this.lblDescuento.Text = "Descuento de: ";
            // 
            // lblSignoDescuento
            // 
            this.lblSignoDescuento.AutoSize = true;
            this.lblSignoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoDescuento.Location = new System.Drawing.Point(1259, 595);
            this.lblSignoDescuento.Name = "lblSignoDescuento";
            this.lblSignoDescuento.Size = new System.Drawing.Size(35, 29);
            this.lblSignoDescuento.TabIndex = 15;
            this.lblSignoDescuento.Text = "%";
            // 
            // lblElDescuento
            // 
            this.lblElDescuento.AutoSize = true;
            this.lblElDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElDescuento.Location = new System.Drawing.Point(1227, 595);
            this.lblElDescuento.Name = "lblElDescuento";
            this.lblElDescuento.Size = new System.Drawing.Size(26, 29);
            this.lblElDescuento.TabIndex = 16;
            this.lblElDescuento.Text = "0";
            // 
            // lblVuelvaProntoss
            // 
            this.lblVuelvaProntoss.AutoSize = true;
            this.lblVuelvaProntoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelvaProntoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVuelvaProntoss.Location = new System.Drawing.Point(934, 651);
            this.lblVuelvaProntoss.Name = "lblVuelvaProntoss";
            this.lblVuelvaProntoss.Size = new System.Drawing.Size(501, 44);
            this.lblVuelvaProntoss.TabIndex = 17;
            this.lblVuelvaProntoss.Text = "Gracias!! Vuelva prontosss";
            this.lblVuelvaProntoss.Visible = false;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackColor = System.Drawing.Color.DarkOrange;
            this.picboxLogo.Location = new System.Drawing.Point(538, 51);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(373, 120);
            this.picboxLogo.TabIndex = 18;
            this.picboxLogo.TabStop = false;
            // 
            // tiempoDeActividad
            // 
            this.tiempoDeActividad.Interval = 1000;
            this.tiempoDeActividad.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // picBoxMenuStrip
            // 
            this.picBoxMenuStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.picBoxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.picBoxMenuStrip.Name = "picBoxMenuStrip";
            this.picBoxMenuStrip.Size = new System.Drawing.Size(1483, 36);
            this.picBoxMenuStrip.TabIndex = 19;
            this.picBoxMenuStrip.TabStop = false;
            this.picBoxMenuStrip.MouseEnter += new System.EventHandler(this.menuStripPrincipal_MouseEnter);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1483, 806);
            this.ControlBox = false;
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.lblVuelvaProntoss);
            this.Controls.Add(this.lblElDescuento);
            this.Controls.Add(this.lblSignoDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.btnElegirexistente);
            this.Controls.Add(this.txbEmpleadoDni);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txbEmpleadoNombre);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.txbDniCliente);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnResetearCarro);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.dtgvCarrito);
            this.Controls.Add(this.btnAgregarAlCarro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtgvPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.Controls.Add(this.picBoxMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik E Mart por Sellanes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuStrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvPrincipal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregarAlCarro;
        private System.Windows.Forms.DataGridView dtgvCarrito;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnResetearCarro;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbDniCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txbEmpleadoNombre;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaClientesToolStripMenuItem;
        private System.Windows.Forms.TextBox txbEmpleadoDni;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarProductosConBajoStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalEnStockToolStripMenuItem;
        private System.Windows.Forms.Button btnElegirexistente;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSignoDescuento;
        private System.Windows.Forms.Label lblElDescuento;
        private System.Windows.Forms.Label lblVuelvaProntoss;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Timer tiempoDeActividad;
        private System.Windows.Forms.PictureBox picBoxMenuStrip;
    }
}

