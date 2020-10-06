using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Comercio
{
    public partial class FormLogin : Form
    {
        int clave;
        public int Clave
        {
            get { return clave; }
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(Administracion.Users))
            {
                this.clave = Validaciones.StringToInt(this.txbClave.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.lblIncorrecto.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            HardCodeEmpleados();
            Administracion.GenerateUsers();
            this.picboxLogoLogin.ImageLocation = @"..\img\logologinScale.jpg";
            this.txbUser.Text = string.Empty;
            this.txbClave.Text = string.Empty;
        }

        private void HardCodeEmpleados()
        {
            Administracion.Add(new Empleado("Matias", "Sellanes", 123456789));
            Administracion.Add(new Empleado("Derat", "Demtres", 222222222));
            Administracion.Add(new Empleado("Demian", "Sanchez", 333333333));
        }

        private bool Login(Dictionary<int, string> users)
        {
            foreach (var item in users)
            {
                if (item.Key == Validaciones.StringToInt(this.txbClave.Text) && item.Value == this.txbUser.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            this.txbUser.BackColor = Color.White;
            if (!(Validaciones.ValidarNombreTextBox(sender)))
            {
                this.txbUser.BackColor = Color.Red;
            }
        }

        private void AnytxbInLogin_TextChanged(object sender, EventArgs e)
        {
            this.lblIncorrecto.Visible = false;
        }
    }
}
