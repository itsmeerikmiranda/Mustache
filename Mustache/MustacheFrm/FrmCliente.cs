using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustache.MustacheFrm
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            (
                 txtNome.Text, txtEmail.Text,
                 txtCpf.Text, dtpData_nasc.Value,
                 txtTelefone.Text
            );

            cliente.Inserir();

            if(cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.Nome} Foi inserido com sucesso");
            }
            else
            {
                MessageBox.Show("Cliente não inserido. Tente novamente!");
            }
        }
    }
}
