namespace Comercio
{
    partial class FormPersona
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(128, 47);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(276, 34);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.Leave += new System.EventHandler(this.txbNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(24, 117);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 25);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Ampellido";
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(128, 111);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(276, 34);
            this.txbApellido.TabIndex = 8;
            this.txbApellido.Leave += new System.EventHandler(this.txbNombre_Leave);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(24, 181);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(45, 25);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "DNI";
            // 
            // txbDni
            // 
            this.txbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDni.Location = new System.Drawing.Point(128, 175);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(276, 34);
            this.txbDni.TabIndex = 10;
            this.txbDni.Leave += new System.EventHandler(this.txbDni_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Location = new System.Drawing.Point(241, 254);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 57);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(436, 323);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Button btnAceptar;
    }
}