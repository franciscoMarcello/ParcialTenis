using Tennis.Context;
using Tennis.Models;
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

namespace LanchesDefault.Forms
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (TxtPesquisar.Text == "")
            {
                MessageBox.Show("Digite alguma descrição ou código para pesquisa!");
            }
            else
            {
                PreencherGridViewDeProdutos();
            }
        }

        public void PreencherGridViewDeProdutos()
        {
            string textoDaPesquisa = TxtPesquisar.Text;

            List<Tenis> tenis;
            DataTable dataTable = new DataTable();

            using (TenisContext db = new TenisContext())
            {
                tenis = db.Tenis
                    .Where(x => x.Marca.Contains(textoDaPesquisa) || x.Modelo.Contains(textoDaPesquisa))
                    .AsNoTracking()
                    .ToList();
            }

            if (tenis.Count == 0)
            {
                MessageBox.Show("Sua pesquisa não trouxe resultados!");
            }
            else
            {
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Marca", typeof(string));
                dataTable.Columns.Add("Modelo", typeof(string));
                dataTable.Columns.Add("Valor", typeof(Decimal));

                foreach (var produto in tenis)
                {
                    dataTable.Rows.Add(produto.Id, produto.Marca, produto.Modelo, produto.Valor);
                }

                DgvProdutos.DataSource = dataTable;
            }

        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
