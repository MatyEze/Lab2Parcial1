namespace Comercio
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.lblIncorrecto = new System.Windows.Forms.Label();
            this.picboxLogoLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(265, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(220, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(12, 254);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(217, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(229, 55);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(256, 34);
            this.txbUser.TabIndex = 2;
            this.txbUser.TextChanged += new System.EventHandler(this.AnytxbInLogin_TextChanged);
            this.txbUser.Leave += new System.EventHandler(this.txbUser_Leave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(224, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 29);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(224, 120);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(74, 29);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // txbClave
            // 
            this.txbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Location = new System.Drawing.Point(229, 152);
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = 'x';
            this.txbClave.Size = new System.Drawing.Size(256, 34);
            this.txbClave.TabIndex = 4;
            this.txbClave.TextChanged += new System.EventHandler(this.AnytxbInLogin_TextChanged);
            // 
            // lblIncorrecto
            // 
            this.lblIncorrecto.AutoSize = true;
            this.lblIncorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrecto.ForeColor = System.Drawing.Color.Firebrick;
            this.lblIncorrecto.Location = new System.Drawing.Point(256, 227);
            this.lblIncorrecto.Name = "lblIncorrecto";
            this.lblIncorrecto.Size = new System.Drawing.Size(229, 24);
            this.lblIncorrecto.TabIndex = 6;
            this.lblIncorrecto.Text = "Clave o usuario incorrecto";
            this.lblIncorrecto.Visible = false;
            // 
            // picboxLogoLogin
            // 
            this.picboxLogoLogin.Location = new System.Drawing.Point(12, 23);
            this.picboxLogoLogin.Name = "picboxLogoLogin";
            this.picboxLogoLogin.Size = new System.Drawing.Size(206, 165);
            this.picboxLogoLogin.TabIndex = 7;
            this.picboxLogoLogin.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(514, 358);
            this.ControlBox = false;
            this.Controls.Add(this.picboxLogoLogin);
            this.Controls.Add(this.lblIncorrecto);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Label lblIncorrecto;
        private System.Windows.Forms.PictureBox picboxLogoLogin;
    }
}