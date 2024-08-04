using Mustache.MustacheFrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustache
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frmClienteNovo = new FrmCliente();
            frmClienteNovo.MdiParent = this;
            frmClienteNovo.StartPosition = FormStartPosition.CenterScreen;
            frmClienteNovo.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.StartPosition = FormStartPosition.CenterScreen;
            frmUsuario.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.StartPosition = FormStartPosition.CenterScreen;
            frmCategoria.Show();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServico frmServico = new FrmServico();
            frmServico.MdiParent = this;
            frmServico.StartPosition = FormStartPosition.CenterScreen;
            frmServico.Show();
        }

     

        private void nivelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FrmNivel frmNivel = new FrmNivel();
            frmNivel.MdiParent = this;
            frmNivel.StartPosition = FormStartPosition.CenterScreen;
            frmNivel.Show();
        }
    }
}
