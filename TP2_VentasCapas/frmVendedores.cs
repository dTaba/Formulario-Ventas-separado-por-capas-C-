using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP2_VentasCapas
{
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void frmVendedores_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            frmVendedoresABM f = new frmVendedoresABM();
            f.vendedores = null; //Create.
            f.ShowDialog();
            ActualizarGrilla();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (gv.SelectedRows.Count == 1)
            {
                int id = (int)gv.SelectedRows[0].Cells["Id"].Value;

                frmVendedoresABM f = new frmVendedoresABM();
                f.vendedores = VentasCapas.Business.Vendedores.ConsultarPorId(id); //Update.
                f.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            if (gv.SelectedRows.Count == 1)
            {
                int id = (int)gv.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show("¿Esta completamente seguro de que desea eliminar este registro?",
                    "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    VentasCapas.Business.Vendedores.Eliminar(id);
                    ActualizarGrilla();
                }
            }
        }

        private void ActualizarGrilla()
        {
            var vendedores = VentasCapas.Business.Vendedores.ConsultarPorNombre(txFiltro.Text.Trim());
            gv.DataSource = vendedores;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btModificar_Click(sender, e);
        }
    }
}
