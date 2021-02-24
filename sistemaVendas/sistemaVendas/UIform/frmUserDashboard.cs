using sistemaVendas.UIform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVendas
{
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }

        public static string transactionType;

        private void FrmUserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Formulario de Compras";
            frmVenda compra = new frmVenda();
            compra.Show();
        }

        private void ClienteRevendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Formulario de Vendas";
            frmVenda venda = new frmVenda();
            venda.Show();
        }
    }
}
