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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        categoriaBLL c = new categoriaBLL();
        categoriaDAL dal = new categoriaDAL();
        userDAL udal = new userDAL();
        private void PictureBoxCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmCategoria_Click(object sender, EventArgs e)
        {
            c.title = txtTitleCategoria.Text;
            c.description = txtDescricaoCategoria.Text;
            c.added_date = DateTime.Now;
            c.added_by = 1;

            
            bool success = dal.Insert(c);
            if (success == true)
            {
                MessageBox.Show("CATEGORIA CADASTRADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO");
            }

            DataTable dt = dal.Select();
            grdCategoria.DataSource = dt;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            txtCategoriaID.Text = "";
            txtDescricaoCategoria.Text = "";
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            grdCategoria.DataSource = dt;
            grdCategoria.Columns[0].HeaderText = "ID";
            grdCategoria.Columns[1].HeaderText = "Titulo";
            grdCategoria.Columns[2].HeaderText = "Descrição";
            grdCategoria.Columns[3].HeaderText = "Data de Cadastro";
            grdCategoria.Columns[4].HeaderText = "Cadastrado Por";
            
        }

        private void GrdCategoria_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCategoriaID.Text = grdCategoria.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitleCategoria.Text = grdCategoria.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescricaoCategoria.Text = grdCategoria.Rows[rowIndex].Cells[2].Value.ToString(); 
        }

        private void BtnUpgradeCategoria_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtCategoriaID.Text);
            c.title = txtTitleCategoria.Text;
            c.description = txtDescricaoCategoria.Text;
            c.added_date = DateTime.Now;
            c.added_by = 1;

            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("CATEGORIA EDITADA COM SUCESSO");
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL EDITAR A CATEGORIA");
            }

            DataTable dt = dal.Select();
            grdCategoria.DataSource = dt;
        }

        private void BtnDeleteCategoria_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtCategoriaID.Text);


            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("CATEGORIA DELETADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL DELETAR O CATEGORIA");
            }

            DataTable dt = dal.Select();
            grdCategoria.DataSource = dt;
        }

        private void TxtSearchCategoria_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchCategoria.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                grdCategoria.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Search();
                grdCategoria.DataSource = dt;
            }
        }

        private void LblSearchCategoria_Click(object sender, EventArgs e)
        {

        }

        private void GrdCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtDescricaoCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDescricaoCategoria_Click(object sender, EventArgs e)
        {

        }

        private void TxtTitleCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblTitleCategoria_Click(object sender, EventArgs e)
        {

        }

        private void TxtCategoriaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblCategoriaID_Click(object sender, EventArgs e)
        {

        }
    }
    
}
