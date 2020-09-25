using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class FormPersona : Form
    {
        string tipoDato;

        public FormPersona(string tipo)
        {
            InitializeComponent();
            this.tipoDato = tipo;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(this.txbNombre.BackColor == Color.Red|| this.txbApellido.BackColor == Color.Red|| this.txbDni.BackColor == Color.Red))
            {
                switch (tipoDato)
                {
                    case "Cliente":
                        Administracion.Add(new Cliente(this.txbNombre.Text, this.txbApellido.Text, Validaciones.StringToInt(this.txbDni.Text)));
                        break;
                    case "Empleado":
                        Administracion.Add(new Empleado(this.txbNombre.Text, this.txbApellido.Text, Validaciones.StringToInt(this.txbDni.Text)));
                        break;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txbNombre_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            if (!Validaciones.ValidarNombreTextBox(sender))
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }

        private void txbDni_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            if (!Validaciones.VerificarNumeros(((TextBox)sender).Text))
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }
    }
}
