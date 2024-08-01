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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Passa os parametros vindo dos textbox para as propriedades da classe
            // e cria um objeto da classe 
            Usuario usuario = new Usuario(
                    txtNivel.Text,
                    txtNome.Text,
                    txtEmail.Text,
                    txtSenha.Text,
                    txtCpf.Text);

            // Chama o metodo inserir através do objeto
            usuario.Inserir();

            // se a propriedade Id for maior que 0
            if (usuario.Id > 0 )
            {
                MessageBox.Show($"usuário {usuario.Nome} inserido com sucesso!");
               
            }
            else
            {
                MessageBox.Show($"Usuário não inserido. Tente novamente.");
            }

        }
    }
}
