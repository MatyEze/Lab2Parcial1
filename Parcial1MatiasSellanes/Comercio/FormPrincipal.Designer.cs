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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregarAlCarro = new System.Windows.Forms.Button();
            this.dtgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnResetearCarro = new System.Windows.Forms.Button();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.añadirToolStripMenuItem.Text = "Agregar";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.dtgvCarrito.Size = new System.Drawing.Size(518, 376);
            this.dtgvCarrito.TabIndex = 4;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(1153, 485);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(208, 54);
            this.btnRealizarVenta.TabIndex = 5;
            this.btnRealizarVenta.Text = "REALIZAR VENTA";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnResetearCarro
            // 
            this.btnResetearCarro.Location = new System.Drawing.Point(843, 485);
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 684);
            this.ControlBox = false;
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnResetearCarro);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.dtgvCarrito);
            this.Controls.Add(this.btnAgregarAlCarro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtgvPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Kwik E Mart por Sellanes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

