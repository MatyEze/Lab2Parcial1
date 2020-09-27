namespace Comercio
{
    partial class FormMostrarLista
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
            this.dtgvLista = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLista
            // 
            this.dtgvLista.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.dtgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLista.Location = new System.Drawing.Point(12, 38);
            this.dtgvLista.Name = "dtgvLista";
            this.dtgvLista.RowHeadersWidth = 51;
            this.dtgvLista.RowTemplate.Height = 24;
            this.dtgvLista.Size = new System.Drawing.Size(776, 322);
            this.dtgvLista.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(646, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 46);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(12, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 46);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDetalles.Enabled = false;
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetalles.Location = new System.Drawing.Point(138, 392);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(120, 46);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // FormMostrarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgvLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMostrarLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMostrarLista";
            this.Load += new System.EventHandler(this.FormMostrarLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDetalles;
    }
}