using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentasCapas.DTO;

namespace TP2_VentasCapas
{
    public partial class frmVendedoresABM : Form
    {
        public VendedoresDTO vendedores { get; set; }

        public frmVendedoresABM()
        {
            InitializeComponent();
        }

        private void frmVendedoresABM_Load(object sender, EventArgs e)
        {
            //Es update?
            if (vendedores != null)
            {
                txId.Text = vendedores.Id.ToString();
                txNombre.Text = vendedores.Nombre;
                txApellido.Text = vendedores.Apellido;
                txTurno.Text = vendedores.Turno;
                txLegajo.Text = vendedores.Legajo;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Es update?
            if (vendedores != null)
            {
                vendedores.Nombre = txNombre.Text;
                vendedores.Apellido = txApellido.Text;
                vendedores.Turno = txTurno.Text;
                vendedores.Legajo = txLegajo.Text;

                VentasCapas.Business.Vendedores.Actualizar(vendedores);
                this.Close();
            }
            else
            {
                //Es create.
                vendedores = new VendedoresDTO();

                vendedores.Nombre = txNombre.Text;
                vendedores.Apellido = txApellido.Text;
                vendedores.Turno = txTurno.Text;
                vendedores.Legajo = txLegajo.Text;

                VentasCapas.Business.Vendedores.Crear(vendedores);
                this.Close();
            }
        }
    }
}
