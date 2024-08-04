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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(txtDescricao.Text, txtSigla.Text);

            categoria.Inserir();

            if (categoria.Id > 0)
            {
                MessageBox.Show($"Categoria {categoria.Descricao} inserida com sucesso!");
            }
            else
            {
                MessageBox.Show($"Não foi possivel inserir a categoria");
            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
