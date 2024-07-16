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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
        }
    }
}
