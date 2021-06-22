using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis.Context;
using Tennis.Models;

namespace LanchesDefault.Forms
{
    public partial class FrmCadastroDeProduto : Form
    {
        private int tenisId;
        public FrmCadastroDeProduto(int tenisId = 0)
        {
            InitializeComponent();
            this.tenisId = tenisId;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                decimal valor = Convert.ToDecimal(TxtValor.Text);

                Tenis tenis = new Tenis(TxtMarca.Text, TxtModelo.Text,  valor);

                bool ehEdicao = tenisId != 0;

              
                {
                    using (TenisContext db = new TenisContext())
                    {
                        db.Tenis.Add(tenis);
                        db.SaveChanges();
                    }

                    MessageBox.Show("Tenis criado com sucesso!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
