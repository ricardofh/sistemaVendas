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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            grdUser.DataSource = dt;
            grdUser.Columns[0].HeaderText = "ID";
            grdUser.Columns[1].HeaderText = "Nome";
            grdUser.Columns[2].HeaderText = "Sobrenome";
            grdUser.Columns[3].HeaderText = "Email";
            grdUser.Columns[4].HeaderText = "Nome de Usuario";
            grdUser.Columns[5].HeaderText = "Senha";
            grdUser.Columns[6].HeaderText = "Contato";
            grdUser.Columns[7].HeaderText = "Endereço";
            grdUser.Columns[8].HeaderText = "Nivel de Usuario";
            grdUser.Columns[9].HeaderText = "Data de Cadastro";
            grdUser.Columns[10].HeaderText = "Cadastrado Por";
            grdUser.Columns[11].HeaderText = "Genero";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.adress = txtAdress.Text;
            u.user_type = cboUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1; 
            u.gender = cboGender.Text;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("USUARIO CADASTRADO COM SUCESSO");
                Limpar();  
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL REALIZAR O CADASTRO");
            }

            DataTable dt = dal.Select();
            grdUser.DataSource = dt;
        }

        private void Limpar()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAdress.Text = "";
            cboUserType.Text = "";
            cboGender.Text = "";
        }

        private void GrdUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = grdUser.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = grdUser.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = grdUser.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = grdUser.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = grdUser.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = grdUser.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = grdUser.Rows[rowIndex].Cells[6].Value.ToString();
            txtAdress.Text = grdUser.Rows[rowIndex].Cells[7].Value.ToString();
            cboUserType.Text = grdUser.Rows[rowIndex].Cells[8].Value.ToString();
            cboGender.Text = grdUser.Rows[rowIndex].Cells[11].Value.ToString();
        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.adress = txtAdress.Text;
            u.user_type = cboUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;
            u.gender = cboGender.Text;

            bool success = dal.Update(u);
            if(success == true)
            {
                MessageBox.Show("USUARIO EDITADO COM SUCESSO");
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL EDITAR O USUARIO");
            }

            DataTable dt = dal.Select();
            grdUser.DataSource = dt;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
             u.id = Convert.ToInt32(txtUserID.Text);
            

            bool success = dal.Delete(u);
            if(success == true)
            {
                MessageBox.Show("USUARIO DELETADO COM SUCESSO");
                Limpar();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL DELETAR O USUARIO");
            }

            DataTable dt = dal.Select();
            grdUser.DataSource = dt;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                grdUser.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Search();
                grdUser.DataSource = dt;
            }
        }
    }   
}
