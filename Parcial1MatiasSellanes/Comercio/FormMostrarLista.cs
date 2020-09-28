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

namespace Comercio
{
    public partial class FormMostrarLista : Form
    {
        private object dato;

        public object Dato
        {
            get { return dato; }
        }

        public DataGridView ListaDtgv
        {
            get { return this.dtgvLista; }
        }
        public Button BotonAgregar
        {
            get { return this.btnAgregar; }
        }
        public Button BotonDetalles
        {
            get { return this.btnDetalles; }
        }

        public FormMostrarLista()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.dtgvLista.SelectedRows.Count > 0)
            {
                dato = this.dtgvLista.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.Yes;
            }
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (this.dtgvLista.SelectedRows.Count > 0)
            {
                dato = this.dtgvLista.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.No;
            }
        }

        private void FormMostrarLista_Load(object sender, EventArgs e)
        {
            this.dtgvLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
