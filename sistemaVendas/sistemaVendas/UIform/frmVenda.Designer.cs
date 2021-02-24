namespace sistemaVendas.UIform
{
    partial class frmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeVendaCliente = new System.Windows.Forms.TextBox();
            this.lblNomeVendaCliente = new System.Windows.Forms.Label();
            this.txtSearchVendaCliente = new System.Windows.Forms.TextBox();
            this.lblSearchVendaCliente = new System.Windows.Forms.Label();
            this.txtEmailVendaCliente = new System.Windows.Forms.TextBox();
            this.lblEmailVendaCliente = new System.Windows.Forms.Label();
            this.txtContactVendaCliente = new System.Windows.Forms.TextBox();
            this.lblContactVendaCliente = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataVendaCliente = new System.Windows.Forms.Label();
            this.lblEnderecoVendaCliente = new System.Windows.Forms.Label();
            this.txtAddressVenda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.lblQuantidadeVenda = new System.Windows.Forms.Label();
            this.txtInventarioVenda = new System.Windows.Forms.TextBox();
            this.lblInventarioVenda = new System.Windows.Forms.Label();
            this.txtSearchVendaProduto = new System.Windows.Forms.TextBox();
            this.lblSerachVendaProduto = new System.Windows.Forms.Label();
            this.txtNomeVendaProduto = new System.Windows.Forms.TextBox();
            this.lblNomeVendaProduto = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.grdProductList = new System.Windows.Forms.DataGridView();
            this.lblDetalhes = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnDetalhesVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBoxProduto);
            this.panel1.Controls.Add(this.lblVenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 43);
            this.panel1.TabIndex = 6;
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProduto.Image")));
            this.pictureBoxProduto.Location = new System.Drawing.Point(1036, 3);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto.TabIndex = 3;
            this.pictureBoxProduto.TabStop = false;
            this.pictureBoxProduto.Click += new System.EventHandler(this.PictureBoxProduto_Click);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(325, 9);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(0, 20);
            this.lblVenda.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 28);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes do Cliente | Revendedor ";
            // 
            // txtNomeVendaCliente
            // 
            this.txtNomeVendaCliente.Location = new System.Drawing.Point(99, 111);
            this.txtNomeVendaCliente.Name = "txtNomeVendaCliente";
            this.txtNomeVendaCliente.Size = new System.Drawing.Size(213, 20);
            this.txtNomeVendaCliente.TabIndex = 44;
            // 
            // lblNomeVendaCliente
            // 
            this.lblNomeVendaCliente.AutoSize = true;
            this.lblNomeVendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVendaCliente.Location = new System.Drawing.Point(12, 112);
            this.lblNomeVendaCliente.Name = "lblNomeVendaCliente";
            this.lblNomeVendaCliente.Size = new System.Drawing.Size(57, 16);
            this.lblNomeVendaCliente.TabIndex = 43;
            this.lblNomeVendaCliente.Text = "Nome :";
            // 
            // txtSearchVendaCliente
            // 
            this.txtSearchVendaCliente.Location = new System.Drawing.Point(99, 77);
            this.txtSearchVendaCliente.Name = "txtSearchVendaCliente";
            this.txtSearchVendaCliente.Size = new System.Drawing.Size(213, 20);
            this.txtSearchVendaCliente.TabIndex = 46;
            this.txtSearchVendaCliente.TextChanged += new System.EventHandler(this.TxtSearchVendaCliente_TextChanged);
            // 
            // lblSearchVendaCliente
            // 
            this.lblSearchVendaCliente.AutoSize = true;
            this.lblSearchVendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchVendaCliente.Location = new System.Drawing.Point(12, 76);
            this.lblSearchVendaCliente.Name = "lblSearchVendaCliente";
            this.lblSearchVendaCliente.Size = new System.Drawing.Size(81, 16);
            this.lblSearchVendaCliente.TabIndex = 45;
            this.lblSearchVendaCliente.Text = "Pesquisa :";
            // 
            // txtEmailVendaCliente
            // 
            this.txtEmailVendaCliente.Location = new System.Drawing.Point(399, 80);
            this.txtEmailVendaCliente.Name = "txtEmailVendaCliente";
            this.txtEmailVendaCliente.Size = new System.Drawing.Size(213, 20);
            this.txtEmailVendaCliente.TabIndex = 48;
            // 
            // lblEmailVendaCliente
            // 
            this.lblEmailVendaCliente.AutoSize = true;
            this.lblEmailVendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailVendaCliente.Location = new System.Drawing.Point(324, 81);
            this.lblEmailVendaCliente.Name = "lblEmailVendaCliente";
            this.lblEmailVendaCliente.Size = new System.Drawing.Size(55, 16);
            this.lblEmailVendaCliente.TabIndex = 47;
            this.lblEmailVendaCliente.Text = "Email :";
            // 
            // txtContactVendaCliente
            // 
            this.txtContactVendaCliente.Location = new System.Drawing.Point(399, 111);
            this.txtContactVendaCliente.Name = "txtContactVendaCliente";
            this.txtContactVendaCliente.Size = new System.Drawing.Size(213, 20);
            this.txtContactVendaCliente.TabIndex = 50;
            // 
            // lblContactVendaCliente
            // 
            this.lblContactVendaCliente.AutoSize = true;
            this.lblContactVendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactVendaCliente.Location = new System.Drawing.Point(324, 112);
            this.lblContactVendaCliente.Name = "lblContactVendaCliente";
            this.lblContactVendaCliente.Size = new System.Drawing.Size(69, 16);
            this.lblContactVendaCliente.TabIndex = 49;
            this.lblContactVendaCliente.Text = "Contato :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(786, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // lblDataVendaCliente
            // 
            this.lblDataVendaCliente.AutoSize = true;
            this.lblDataVendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVendaCliente.Location = new System.Drawing.Point(680, 84);
            this.lblDataVendaCliente.Name = "lblDataVendaCliente";
            this.lblDataVendaCliente.Size = new System.Drawing.Size(49, 16);
            this.lblDataVendaCliente.TabIndex = 52;
            this.lblDataVendaCliente.Text = "Data :";
            // 
            // lblEnderecoVendaCliente
            // 
            this.lblEnderecoVendaCliente.AutoSize = true;
            this.lblEnderecoVendaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoVendaCliente.Location = new System.Drawing.Point(680, 142);
            this.lblEnderecoVendaCliente.Name = "lblEnderecoVendaCliente";
            this.lblEnderecoVendaCliente.Size = new System.Drawing.Size(83, 16);
            this.lblEnderecoVendaCliente.TabIndex = 53;
            this.lblEnderecoVendaCliente.Text = "Endereço :";
            // 
            // txtAddressVenda
            // 
            this.txtAddressVenda.Location = new System.Drawing.Point(786, 110);
            this.txtAddressVenda.Multiline = true;
            this.txtAddressVenda.Name = "txtAddressVenda";
            this.txtAddressVenda.Size = new System.Drawing.Size(217, 86);
            this.txtAddressVenda.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 23);
            this.panel3.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalhes do Produto";
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.Location = new System.Drawing.Point(422, 261);
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(56, 20);
            this.txtQtdVenda.TabIndex = 63;
            // 
            // lblQuantidadeVenda
            // 
            this.lblQuantidadeVenda.AutoSize = true;
            this.lblQuantidadeVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeVenda.Location = new System.Drawing.Point(324, 262);
            this.lblQuantidadeVenda.Name = "lblQuantidadeVenda";
            this.lblQuantidadeVenda.Size = new System.Drawing.Size(92, 16);
            this.lblQuantidadeVenda.TabIndex = 62;
            this.lblQuantidadeVenda.Text = "Quantidade:";
            // 
            // txtInventarioVenda
            // 
            this.txtInventarioVenda.Location = new System.Drawing.Point(422, 230);
            this.txtInventarioVenda.Name = "txtInventarioVenda";
            this.txtInventarioVenda.Size = new System.Drawing.Size(213, 20);
            this.txtInventarioVenda.TabIndex = 61;
            // 
            // lblInventarioVenda
            // 
            this.lblInventarioVenda.AutoSize = true;
            this.lblInventarioVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventarioVenda.Location = new System.Drawing.Point(324, 231);
            this.lblInventarioVenda.Name = "lblInventarioVenda";
            this.lblInventarioVenda.Size = new System.Drawing.Size(84, 16);
            this.lblInventarioVenda.TabIndex = 60;
            this.lblInventarioVenda.Text = "Inventario :";
            // 
            // txtSearchVendaProduto
            // 
            this.txtSearchVendaProduto.Location = new System.Drawing.Point(99, 227);
            this.txtSearchVendaProduto.Name = "txtSearchVendaProduto";
            this.txtSearchVendaProduto.Size = new System.Drawing.Size(213, 20);
            this.txtSearchVendaProduto.TabIndex = 59;
            this.txtSearchVendaProduto.TextChanged += new System.EventHandler(this.TxtSearchVendaProduto_TextChanged);
            // 
            // lblSerachVendaProduto
            // 
            this.lblSerachVendaProduto.AutoSize = true;
            this.lblSerachVendaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerachVendaProduto.Location = new System.Drawing.Point(12, 226);
            this.lblSerachVendaProduto.Name = "lblSerachVendaProduto";
            this.lblSerachVendaProduto.Size = new System.Drawing.Size(81, 16);
            this.lblSerachVendaProduto.TabIndex = 58;
            this.lblSerachVendaProduto.Text = "Pesquisa :";
            // 
            // txtNomeVendaProduto
            // 
            this.txtNomeVendaProduto.Location = new System.Drawing.Point(99, 261);
            this.txtNomeVendaProduto.Name = "txtNomeVendaProduto";
            this.txtNomeVendaProduto.Size = new System.Drawing.Size(213, 20);
            this.txtNomeVendaProduto.TabIndex = 57;
            // 
            // lblNomeVendaProduto
            // 
            this.lblNomeVendaProduto.AutoSize = true;
            this.lblNomeVendaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVendaProduto.Location = new System.Drawing.Point(12, 262);
            this.lblNomeVendaProduto.Name = "lblNomeVendaProduto";
            this.lblNomeVendaProduto.Size = new System.Drawing.Size(57, 16);
            this.lblNomeVendaProduto.TabIndex = 56;
            this.lblNomeVendaProduto.Text = "Nome :";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(543, 262);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(92, 20);
            this.txtValorVenda.TabIndex = 65;
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.Location = new System.Drawing.Point(484, 262);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(53, 16);
            this.lblValorVenda.TabIndex = 64;
            this.lblValorVenda.Text = "Valor :";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.Color.Green;
            this.lblLista.Location = new System.Drawing.Point(3, 305);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(150, 20);
            this.lblLista.TabIndex = 66;
            this.lblLista.Text = "Lista de Produtos";
            // 
            // grdProductList
            // 
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductList.Location = new System.Drawing.Point(7, 328);
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.Size = new System.Drawing.Size(409, 228);
            this.grdProductList.TabIndex = 67;
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhes.ForeColor = System.Drawing.Color.Green;
            this.lblDetalhes.Location = new System.Drawing.Point(539, 305);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(163, 20);
            this.lblDetalhes.TabIndex = 68;
            this.lblDetalhes.Text = "Detalhes da Venda";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(645, 338);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(213, 20);
            this.txtSubTotal.TabIndex = 70;
            this.txtSubTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(540, 339);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(83, 16);
            this.lblSubTotal.TabIndex = 69;
            this.lblSubTotal.Text = "Sub Total :";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(645, 370);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(213, 20);
            this.txtDesconto.TabIndex = 72;
            this.txtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(540, 370);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(99, 16);
            this.lblDesconto.TabIndex = 71;
            this.lblDesconto.Text = "Desconto % :";
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Location = new System.Drawing.Point(645, 395);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.Size = new System.Drawing.Size(213, 20);
            this.txtTotalGeral.TabIndex = 74;
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(540, 396);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(94, 16);
            this.lblTotalGeral.TabIndex = 73;
            this.lblTotalGeral.Text = "Total Geral :";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Location = new System.Drawing.Point(645, 426);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(213, 20);
            this.txtTotalPago.TabIndex = 76;
            this.txtTotalPago.TextChanged += new System.EventHandler(this.TxtTotalPago_TextChanged);
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Location = new System.Drawing.Point(540, 427);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(93, 16);
            this.lblTotalPago.TabIndex = 75;
            this.lblTotalPago.Text = "Total Pago :";
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(645, 457);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(213, 20);
            this.txtTroco.TabIndex = 78;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(540, 458);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(57, 16);
            this.lblTroco.TabIndex = 77;
            this.lblTroco.Text = "Troco :";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Location = new System.Drawing.Point(645, 231);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(97, 30);
            this.btnAddProduto.TabIndex = 79;
            this.btnAddProduto.Text = "ADICIONAR";
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // btnDetalhesVenda
            // 
            this.btnDetalhesVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDetalhesVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesVenda.Location = new System.Drawing.Point(645, 483);
            this.btnDetalhesVenda.Name = "btnDetalhesVenda";
            this.btnDetalhesVenda.Size = new System.Drawing.Size(97, 30);
            this.btnDetalhesVenda.TabIndex = 80;
            this.btnDetalhesVenda.Text = "SALVAR";
            this.btnDetalhesVenda.UseVisualStyleBackColor = false;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1072, 568);
            this.Controls.Add(this.btnDetalhesVenda);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.txtTotalGeral);
            this.Controls.Add(this.lblTotalGeral);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.grdProductList);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.txtQtdVenda);
            this.Controls.Add(this.lblQuantidadeVenda);
            this.Controls.Add(this.txtInventarioVenda);
            this.Controls.Add(this.lblInventarioVenda);
            this.Controls.Add(this.txtSearchVendaProduto);
            this.Controls.Add(this.lblSerachVendaProduto);
            this.Controls.Add(this.txtNomeVendaProduto);
            this.Controls.Add(this.lblNomeVendaProduto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtAddressVenda);
            this.Controls.Add(this.lblEnderecoVendaCliente);
            this.Controls.Add(this.lblDataVendaCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtContactVendaCliente);
            this.Controls.Add(this.lblContactVendaCliente);
            this.Controls.Add(this.txtEmailVendaCliente);
            this.Controls.Add(this.lblEmailVendaCliente);
            this.Controls.Add(this.txtSearchVendaCliente);
            this.Controls.Add(this.lblSearchVendaCliente);
            this.Controls.Add(this.txtNomeVendaCliente);
            this.Controls.Add(this.lblNomeVendaCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxProduto;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeVendaCliente;
        private System.Windows.Forms.Label lblNomeVendaCliente;
        private System.Windows.Forms.TextBox txtSearchVendaCliente;
        private System.Windows.Forms.Label lblSearchVendaCliente;
        private System.Windows.Forms.TextBox txtEmailVendaCliente;
        private System.Windows.Forms.Label lblEmailVendaCliente;
        private System.Windows.Forms.TextBox txtContactVendaCliente;
        private System.Windows.Forms.Label lblContactVendaCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataVendaCliente;
        private System.Windows.Forms.Label lblEnderecoVendaCliente;
        private System.Windows.Forms.TextBox txtAddressVenda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdVenda;
        private System.Windows.Forms.Label lblQuantidadeVenda;
        private System.Windows.Forms.TextBox txtInventarioVenda;
        private System.Windows.Forms.Label lblInventarioVenda;
        private System.Windows.Forms.TextBox txtSearchVendaProduto;
        private System.Windows.Forms.Label lblSerachVendaProduto;
        private System.Windows.Forms.TextBox txtNomeVendaProduto;
        private System.Windows.Forms.Label lblNomeVendaProduto;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView grdProductList;
        private System.Windows.Forms.Label lblDetalhes;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnDetalhesVenda;
    }
}