using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchesDefault.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

      

        private void PesquisarProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();

            frmProdutos.Show();
        }

      

        private void NovoProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastroDeProduto frmCadastroDeProduto = new FrmCadastroDeProduto();

            frmCadastroDeProduto.Show();


        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
