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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnRealizarUmPedido_Click(object sender, EventArgs e)
        {
            FrmFazerPedido frmFazerPedido = new FrmFazerPedido();

            frmFazerPedido.Show();
        }

        private void BtnPedidosRealizados_Click(object sender, EventArgs e)
        {
            FrmPedidosRealizados frmPedidosRealizados = new FrmPedidosRealizados();

            frmPedidosRealizados.Show();
        }
    }
}
