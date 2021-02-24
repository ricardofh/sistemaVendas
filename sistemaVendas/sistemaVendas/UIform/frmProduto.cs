using sistemaVendas.BLLClasses;
using sistemaVendas.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas.UIform
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        categoriaDAL cdal = new categoriaDAL();
        produtoBLL p = new produtoBLL();
        produtosDAL pdal = new produtosDAL();

        private void PictureBoxProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            cboCategoriaProduto.DataSource = categoriesDT;
            cboCategoriaProduto.DisplayMember = "title";
            cboCategoriaProduto.ValueMember = "title";

            DataTable dt = pdal.Select();
            grdProduto.DataSource = dt;
            grdProduto.Columns[0].HeaderText = "ID";
            grdProduto.Columns[1].HeaderText = "Nome";
            grdProduto.Columns[2].HeaderText = "Categoria";
            grdProduto.Columns[3].HeaderText = "Descrição";
            grdProduto.Columns[4].HeaderText = "Valor";
            grdProduto.Columns[5].HeaderText = "Quantidade";
            grdProduto.Columns[6].HeaderText = "Data de Cadastro";
            grdProduto.Columns[7].HeaderText = "Cadastrado pro";
        }

        private void Limpar()
        {
            txtProdutoID.Text = "";
            txtNomeProduto.Text = "";
            cboCategoriaProduto.Text = "";
            txtValorProduto.Text = "";
        }

        private void BtnConfirmProduto_Click(object sender, EventArgs e)
        {
            p.name = txtNomeProduto.Text;
            p.category = cboCategoriaProduto.Text;
            p.descrition = txtDescricaoProduto.Text;
            p.rate = decimal.Parse(txtValorProduto.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            p.added_by = 1;


            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O PRODUTO");
            }

            DataTable dt = pdal.Select();
            grdProduto.DataSource = dt;
        }

        private void GrdProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtProdutoID.Text = grdProduto.Rows[rowIndex].Cells[0].Value.ToString();
            txtNomeProduto.Text = grdProduto.Rows[rowIndex].Cells[1].Value.ToString();
            cboCategoriaProduto.Text = grdProduto.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescricaoProduto.Text = grdProduto.Rows[rowIndex].Cells[3].Value.ToString();
            txtValorProduto.Text = grdProduto.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void BtnUpgradeProduto_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtProdutoID.Text);
            p.name = txtNomeProduto.Text;
            p.category = cboCategoriaProduto.Text;
            p.descrition = txtDescricaoProduto.Text;
            p.rate = decimal.Parse(txtValorProduto.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            p.added_by = 1;

            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("PRODUTO EDITADA COM SUCESSO");
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL EDITAR A PRODUTO");
            }

            DataTable dt = pdal.Select();
            grdProduto.DataSource = dt;
        }

        private void BtnDeleteProduto_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtProdutoID.Text);


            bool success = pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("PRODUTO DELETADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL DELETAR O PRODUTO");
            }

            DataTable dt = pdal.Select();
            grdProduto.DataSource = dt;
        }

        private void BtnLimparProduto_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void TxtSearchProduto_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchProduto.Text;
            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                grdProduto.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Search();
                grdProduto.DataSource = dt;
            }
        }
    }
}
