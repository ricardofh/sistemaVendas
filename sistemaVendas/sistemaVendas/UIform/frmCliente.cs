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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        clienteBLL cl = new clienteBLL();
        clienteDAL cldal = new clienteDAL();

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            txtClienteID.Text = "";
            cboClienteType.Text = "";
            txtNameCliente.Text = "";
            txtEmailCliente.Text = "";
            txtContactCliente.Text = "";
            txtAdressCliente.Text = "";
        }

        private void BtnConfirmCliente_Click(object sender, EventArgs e)
        {
            cl.type = cboClienteType.Text;
            cl.name = txtNameCliente.Text;
            cl.email = txtEmailCliente.Text;
            cl.contact = txtContactCliente.Text;
            cl.address = txtAdressCliente.Text;
            cl.added_date = DateTime.Now;
            cl.added_by = 1;

            bool success = cldal.Insert(cl);
            if (success == true)
            {
                MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO");
            }

            DataTable dt = cldal.Select();
            grdCliente.DataSource = dt;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = cldal.Select();
            grdCliente.DataSource = dt;
            grdCliente.Columns[0].HeaderText = "ID";
            grdCliente.Columns[1].HeaderText = "Tipo";
            grdCliente.Columns[2].HeaderText = "Nome";
            grdCliente.Columns[3].HeaderText = "Email";
            grdCliente.Columns[4].HeaderText = "Contato";
            grdCliente.Columns[5].HeaderText = "Endereço";
            grdCliente.Columns[6].HeaderText = "Data de Cadastro";
            grdCliente.Columns[7].HeaderText = "Cadastrado Por";
        }

        private void GrdCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtClienteID.Text = grdCliente.Rows[rowIndex].Cells[0].Value.ToString();
            cboClienteType.Text = grdCliente.Rows[rowIndex].Cells[1].Value.ToString();
            txtNameCliente.Text = grdCliente.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmailCliente.Text = grdCliente.Rows[rowIndex].Cells[3].Value.ToString();
            txtContactCliente.Text = grdCliente.Rows[rowIndex].Cells[4].Value.ToString();
            txtAdressCliente.Text = grdCliente.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void BtnUpgradeCliente_Click(object sender, EventArgs e)
        {
            cl.id = Convert.ToInt32(txtClienteID.Text);
            cl.type = cboClienteType.Text;
            cl.name = txtNameCliente.Text;
            cl.email = txtEmailCliente.Text;
            cl.contact = txtContactCliente.Text;
            cl.address = txtAdressCliente.Text;
            cl.added_date = DateTime.Now;
            cl.added_by = 1;

            bool success = cldal.Update(cl);
            if (success == true)
            {
                MessageBox.Show("CLIENTE EDITADO COM SUCESSO");
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL EDITAR O CLIENTE");
            }

            DataTable dt = cldal.Select();
            grdCliente.DataSource = dt;
        }

        private void BtnDeleteCliente_Click(object sender, EventArgs e)
        {
            cl.id = Convert.ToInt32(txtClienteID.Text);


            bool success = cldal.Delete(cl);
            if (success == true)
            {
                MessageBox.Show("CLIENTE DELETADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL DELETAR O CLIENTE");
            }

            DataTable dt = cldal.Select();
            grdCliente.DataSource = dt;
        }

        private void TxtSearchCliente_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchCliente.Text;
            if (keywords != null)
            {
                DataTable dt = cldal.Search(keywords);
                grdCliente.DataSource = dt;
            }
            else
            {
                DataTable dt = cldal.Search();
                grdCliente.DataSource = dt;
            }
        }
    }
}
