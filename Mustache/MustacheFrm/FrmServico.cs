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
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico(txtNome.Text, int.Parse(txtCategoria.Text), double.Parse(txtValorUnit.Text), dtpDuracao.Value.TimeOfDay, double.Parse(txtDesconto.Text));

            servico.Inserir();

            if (servico.Id > 0)
            {
                MessageBox.Show($"O serviço {servico.Nome} foi Inserido com sucesso!");

            }
            else
            {
                MessageBox.Show($"Serviço não cadastrado. Tente novamente!");
            }

        }

        private void FrmServico_Load(object sender, EventArgs e)
        {

        }
    }
}
