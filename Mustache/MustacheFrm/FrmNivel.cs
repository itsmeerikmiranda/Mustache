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
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        private void FormNivel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
         {
                Nivel nivel = new Nivel (txtNome.Text, txtSigla.Text);

                nivel.Inserir();

                if (nivel.Id > 0)
                {
                    MessageBox.Show($"O Nivel {nivel.Nome} foi Inserido com sucesso!");

                }
                else
                {
                    MessageBox.Show($"Nivel não cadastrado. Tente novamente!");
                }

            }
        }
    }
}
