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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        clienteDAL ctDAL = new clienteDAL();
        produtosDAL ptDAL = new produtosDAL();
        DataTable transactionDT = new DataTable();

        private void PictureBoxProduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            string type = frmUserDashboard.transactionType;
            lblVenda.Text = type;

            transactionDT.Columns.Add("Nome do produto");
            transactionDT.Columns.Add("Valor");
            transactionDT.Columns.Add("Quantidade");
            transactionDT.Columns.Add("Total");
        }

        private void TxtSearchVendaCliente_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchVendaCliente.Text;
            if (keyword == "")
            {
                txtNomeVendaCliente.Text = "";
                txtEmailVendaCliente.Text = "";
                txtContactVendaCliente.Text = "";
                txtAddressVenda.Text = "";
                return;
            }
            clienteBLL ct = ctDAL.SearchClientForTransaction(keyword);
            txtNomeVendaCliente.Text = ct.name;
            txtEmailVendaCliente.Text = ct.email;
            txtContactVendaCliente.Text = ct.contact;
            txtAddressVenda.Text = ct.address;
        }

        private void TxtSearchVendaProduto_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchVendaProduto.Text;
            if (keyword == "")
            {
                txtNomeVendaProduto.Text = "";
                txtInventarioVenda.Text = "";
                txtValorVenda.Text = "";
                txtQtdVenda.Text = "";
                return;
            }
            produtoBLL pt = ptDAL.SearchProductForTransaction(keyword);
            txtNomeVendaProduto.Text = pt.name;
            txtValorVenda.Text = pt.rate.ToString();
            txtInventarioVenda.Text = pt.qty.ToString();
           
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            string productName = txtNomeVendaProduto.Text;
            decimal rate = decimal.Parse(txtValorVenda.Text);
            decimal qty = decimal.Parse(txtQtdVenda.Text);
            decimal total = rate * qty;

            decimal subtotal = decimal.Parse(txtSubTotal.Text);
            subtotal = subtotal + total;

            if (productName =="")
            {
                MessageBox.Show("DIGITAR O NOME DO PRODUTO");
            }
            else
            {
                transactionDT.Rows.Add(productName, rate, qty, total);
                grdProductList.DataSource = transactionDT;

                txtSubTotal.Text = subtotal.ToString();

                txtSearchVendaProduto.Text = "";
                txtNomeVendaProduto.Text = "";
                txtInventarioVenda.Text = "0.00";
                txtValorVenda.Text = "0.00";
                txtQtdVenda.Text = "";
            }
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            string value = txtDesconto.Text;
            if(value =="")
            {
                MessageBox.Show("Favor digitar valor");
            }
            else
            {
                decimal subtotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDesconto.Text);

                decimal grandtotal = ((100 - discount) / 100) * subtotal;
                txtTotalGeral.Text = grandtotal.ToString();
            }
        }

        private void TxtTotalPago_TextChanged(object sender, EventArgs e)
        {
            decimal grantotal = decimal.Parse(txtTotalGeral.Text);
            decimal pago = decimal.Parse(txtTotalPago.Text);

            decimal troco = pago - grantotal;
            txtTroco.Text = troco.ToString(); 
        }
    }
}
