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
    public partial class frmClientesABM : Form
    {
        public ClientesDTO clientes { get; set; }

        public frmClientesABM()
        {
            InitializeComponent();
        }

        private void frmClientesABM_Load(object sender, EventArgs e)
        {
            //Es update?
            if (clientes != null)
            {
                txId.Text = clientes.Id.ToString();
                txNombre.Text = clientes.Nombre;
                txDireccion.Text = clientes.Direccion;
                txTelefono.Text = clientes.Telefono;
                txMail.Text = clientes.Email;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Es update?
            if (clientes != null)
            {
                clientes.Nombre = txNombre.Text;
                clientes.Direccion = txDireccion.Text;
                clientes.Telefono = txTelefono.Text;
                clientes.Email = txMail.Text;

                VentasCapas.Business.Clientes.Actualizar(clientes);
                this.Close();
            }
            else
            {
                //Es create.
                clientes = new ClientesDTO();

                clientes.Nombre = txNombre.Text;
                clientes.Direccion = txDireccion.Text;
                clientes.Telefono = txTelefono.Text;
                clientes.Email = txMail.Text;

                VentasCapas.Business.Clientes.Crear(clientes);
                this.Close();
            }
        }
    }
}
