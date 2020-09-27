namespace Comercio
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbIdProducto = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblDecripcion = new System.Windows.Forms.Label();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbIdProducto
            // 
            this.txbIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProducto.Location = new System.Drawing.Point(174, 19);
            this.txbIdProducto.Name = "txbIdProducto";
            this.txbIdProducto.Size = new System.Drawing.Size(260, 34);
            this.txbIdProducto.TabIndex = 0;
            this.txbIdProducto.Leave += new System.EventHandler(this.txbIdProducto_Leave);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcion.Location = new System.Drawing.Point(174, 75);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(260, 34);
            this.txbDescripcion.TabIndex = 1;
            // 
            // txbPrecioUnidad
            // 
            this.txbPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioUnidad.Location = new System.Drawing.Point(174, 130);
            this.txbPrecioUnidad.Name = "txbPrecioUnidad";
            this.txbPrecioUnidad.Size = new System.Drawing.Size(80, 34);
            this.txbPrecioUnidad.TabIndex = 2;
            // 
            // txbStock
            // 
            this.txbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(174, 183);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(80, 34);
            this.txbStock.TabIndex = 3;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(174, 236);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(260, 37);
            this.cmbTipoProducto.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(313, 288);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 46);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(12, 25);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(150, 25);
            this.lblIdProducto.TabIndex = 6;
            this.lblIdProducto.Text = "ID PRODUCTO";
            // 
            // lblDecripcion
            // 
            this.lblDecripcion.AutoSize = true;
            this.lblDecripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecripcion.Location = new System.Drawing.Point(12, 81);
            this.lblDecripcion.Name = "lblDecripcion";
            this.lblDecripcion.Size = new System.Drawing.Size(149, 25);
            this.lblDecripcion.TabIndex = 7;
            this.lblDecripcion.Text = "DESCRIPCION";
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnidad.Location = new System.Drawing.Point(12, 136);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(106, 25);
            this.lblPrecioUnidad.TabIndex = 8;
            this.lblPrecioUnidad.Text = "PRECIO U";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(12, 189);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(84, 25);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "STOCK";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 242);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(59, 25);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "TIPO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(174, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 46);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(471, 365);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecioUnidad);
            this.Controls.Add(this.lblDecripcion);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.txbPrecioUnidad);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbIdProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIdProducto;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecioUnidad;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblDecripcion;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnEliminar;
    }
}