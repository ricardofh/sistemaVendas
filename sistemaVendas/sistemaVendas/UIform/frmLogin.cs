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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtLoginUsername.Text.Trim();
            l.password = txtLoginPassword.Text.Trim();
            l.user_type = cboLoginType.Text.Trim();

            bool Success = dal.loginCheck(l);
            if(Success == true)
            {
                MessageBox.Show("USUARIO LOGADO COM SUCESSO!!");
                switch(l.user_type)
                {
                    case "Administrador":
                        {
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "Comum":
                        {
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("USUARIO INVALIDO");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("ERRO AO LOGAR!!!");
            }
        }
    }
}
