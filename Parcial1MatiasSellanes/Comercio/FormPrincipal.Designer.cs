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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.cientesToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1463, 36);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
            this.añadirToolStripMenuItem.Text = "Agregar";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.listaToolStripMenuItem.Text = " Lista empleados";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // cientesToolStripMenuItem
            // 
            this.cientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientesToolStripMenuItem});
            this.cientesToolStripMenuItem.Name = "cientesToolStripMenuItem";
            this.cientesToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.cientesToolStripMenuItem.Text = "Cientes";
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.listaClientesToolStripMenuItem.Text = "Lista clientes";
            this.listaClientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientesToolStripMenuItem_Click);
            // 
            // dtgvPrincipal
            // 
            this.dtgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrincipal.Location = new System.Drawing.Point(15, 103);
            this.dtgvPrincipal.Name = "dtgvPrincipal";
            this.dtgvPrincipal.RowHeadersWidth = 51;
            this.dtgvPrincipal.RowTemplate.Height = 24;
            this.dtgvPrincipal.Size = new System.Drawing.Size(778, 481);
            this.dtgvPrincipal.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(15, 590);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(192, 53);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregarAlCarro
            // 
            this.btnAgregarAlCarro.Location = new System.Drawing.Point(231, 590);
            this.btnAgregarAlCarro.Name = "btnAgregarAlCarro";
            this.btnAgregarAlCarro.Size = new System.Drawing.Size(208, 53);
            this.btnAgregarAlCarro.TabIndex = 3;
            this.btnAgregarAlCarro.Text = "AGREGAR AL CARRO";
            this.btnAgregarAlCarro.UseVisualStyleBackColor = true;
            this.btnAgregarAlCarro.Click += new System.EventHandler(this.btnAgregarAlCarro_Click);
            // 
            // dtgvCarrito
            // 
            this.dtgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarrito.Location = new System.Drawing.Point(843, 103);
            this.dtgvCarrito.Name = "dtgvCarrito";
            this.dtgvCarrito.RowHeadersWidth = 51;
            this.dtgvCarrito.RowTemplate.Height = 24;
            this.dtgvCarrito.Size = new System.Drawing.Size(608, 307);
            this.dtgvCarrito.TabIndex = 4;
            this.dtgvCarrito.DataSourceChanged += new System.EventHandler(this.dtgvCarrito_DataSourceChanged);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(1067, 464);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(208, 54);
            this.btnRealizarVenta.TabIndex = 5;
            this.btnRealizarVenta.Text = "REALIZAR VENTA";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnResetearCarro
            // 
            this.btnResetearCarro.Location = new System.Drawing.Point(841, 464);
            this.btnResetearCarro.Name = "btnResetearCarro";
            this.btnResetearCarro.Size = new System.Drawing.Size(208, 54);
            this.btnResetearCarro.TabIndex = 6;
            this.btnResetearCarro.Text = "RESETAR CARRITO";
            this.btnResetearCarro.UseVisualStyleBackColor = true;
            this.btnResetearCarro.Click += new System.EventHandler(this.btnResetearCarro_Click);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(445, 590);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(59, 53);
            this.txbCantidad.TabIndex = 7;
            // 
            // txbDniCliente
            // 
            this.txbDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDniCliente.Location = new System.Drawing.Point(1006, 424);
            this.txbDniCliente.Name = "txbDniCliente";
            this.txbDniCliente.Size = new System.Drawing.Size(269, 34);
            this.txbDniCliente.TabIndex = 8;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(838, 427);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(162, 29);
            this.lblDniCliente.TabIndex = 9;
            this.lblDniCliente.Text = "DNI CLIENTE";
            // 
            // txbEmpleadoNombre
            // 
            this.txbEmpleadoNombre.Enabled = false;
            this.txbEmpleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleadoNombre.Location = new System.Drawing.Point(942, 642);
            this.txbEmpleadoNombre.Name = "txbEmpleadoNombre";
            this.txbEmpleadoNombre.Size = new System.Drawing.Size(275, 34);
            this.txbEmpleadoNombre.TabIndex = 10;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(791, 645);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(145, 29);
            this.lblEmpleado.TabIndex = 11;
            this.lblEmpleado.Text = "EMPLEADO";
            // 
            // txbEmpleadoDni
            // 
            this.txbEmpleadoDni.Enabled = false;
            this.txbEmpleadoDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleadoDni.Location = new System.Drawing.Point(1223, 642);
            this.txbEmpleadoDni.Name = "txbEmpleadoDni";
            this.txbEmpleadoDni.Size = new System.Drawing.Size(228, 34);
            this.txbEmpleadoDni.TabIndex = 12;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 734);
            this.ControlBox = false;
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
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Kwik E Mart por Sellanes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
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
    }
}

