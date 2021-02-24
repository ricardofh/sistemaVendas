namespace sistemaVendas.UIform
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.grdProduto = new System.Windows.Forms.DataGridView();
            this.txtSearchProduto = new System.Windows.Forms.TextBox();
            this.lblSearchCategoria = new System.Windows.Forms.Label();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.btnUpgradeProduto = new System.Windows.Forms.Button();
            this.btnDeleteProduto = new System.Windows.Forms.Button();
            this.btnConfirmProduto = new System.Windows.Forms.Button();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.lblProdutoID = new System.Windows.Forms.Label();
            this.lblCategoriaProduto = new System.Windows.Forms.Label();
            this.cboCategoriaProduto = new System.Windows.Forms.ComboBox();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxProduto);
            this.panel1.Controls.Add(this.lblProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(925, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProduto.Image")));
            this.pictureBoxProduto.Location = new System.Drawing.Point(764, 3);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduto.TabIndex = 3;
            this.pictureBoxProduto.TabStop = false;
            this.pictureBoxProduto.Click += new System.EventHandler(this.PictureBoxProduto_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(325, 9);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(187, 20);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Formulario de Produto";
            // 
            // grdProduto
            // 
            this.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduto.Location = new System.Drawing.Point(386, 86);
            this.grdProduto.Name = "grdProduto";
            this.grdProduto.Size = new System.Drawing.Size(411, 125);
            this.grdProduto.TabIndex = 51;
            this.grdProduto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdProduto_RowHeaderMouseClick);
            // 
            // txtSearchProduto
            // 
            this.txtSearchProduto.Location = new System.Drawing.Point(475, 60);
            this.txtSearchProduto.Name = "txtSearchProduto";
            this.txtSearchProduto.Size = new System.Drawing.Size(322, 20);
            this.txtSearchProduto.TabIndex = 50;
            this.txtSearchProduto.TextChanged += new System.EventHandler(this.TxtSearchProduto_TextChanged);
            // 
            // lblSearchCategoria
            // 
            this.lblSearchCategoria.AutoSize = true;
            this.lblSearchCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCategoria.Location = new System.Drawing.Point(383, 64);
            this.lblSearchCategoria.Name = "lblSearchCategoria";
            this.lblSearchCategoria.Size = new System.Drawing.Size(86, 16);
            this.lblSearchCategoria.TabIndex = 49;
            this.lblSearchCategoria.Text = "Pesquisar :";
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimparProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProduto.Location = new System.Drawing.Point(105, 256);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(106, 37);
            this.btnLimparProduto.TabIndex = 48;
            this.btnLimparProduto.Text = "LIMPAR";
            this.btnLimparProduto.UseVisualStyleBackColor = false;
            this.btnLimparProduto.Click += new System.EventHandler(this.BtnLimparProduto_Click);
            // 
            // btnUpgradeProduto
            // 
            this.btnUpgradeProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnUpgradeProduto.Image")));
            this.btnUpgradeProduto.Location = new System.Drawing.Point(623, 238);
            this.btnUpgradeProduto.Name = "btnUpgradeProduto";
            this.btnUpgradeProduto.Size = new System.Drawing.Size(81, 72);
            this.btnUpgradeProduto.TabIndex = 47;
            this.btnUpgradeProduto.UseVisualStyleBackColor = true;
            this.btnUpgradeProduto.Click += new System.EventHandler(this.BtnUpgradeProduto_Click);
            // 
            // btnDeleteProduto
            // 
            this.btnDeleteProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduto.Image")));
            this.btnDeleteProduto.Location = new System.Drawing.Point(514, 238);
            this.btnDeleteProduto.Name = "btnDeleteProduto";
            this.btnDeleteProduto.Size = new System.Drawing.Size(79, 72);
            this.btnDeleteProduto.TabIndex = 46;
            this.btnDeleteProduto.UseVisualStyleBackColor = true;
            this.btnDeleteProduto.Click += new System.EventHandler(this.BtnDeleteProduto_Click);
            // 
            // btnConfirmProduto
            // 
            this.btnConfirmProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmProduto.Image")));
            this.btnConfirmProduto.Location = new System.Drawing.Point(386, 238);
            this.btnConfirmProduto.Name = "btnConfirmProduto";
            this.btnConfirmProduto.Size = new System.Drawing.Size(97, 72);
            this.btnConfirmProduto.TabIndex = 45;
            this.btnConfirmProduto.UseVisualStyleBackColor = true;
            this.btnConfirmProduto.Click += new System.EventHandler(this.BtnConfirmProduto_Click);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(105, 146);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(213, 64);
            this.txtDescricaoProduto.TabIndex = 44;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProduto.Location = new System.Drawing.Point(12, 147);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(87, 16);
            this.lblDescricaoProduto.TabIndex = 43;
            this.lblDescricaoProduto.Text = "Descrição :";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(105, 91);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(213, 20);
            this.txtNomeProduto.TabIndex = 42;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(12, 90);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(57, 16);
            this.lblNomeProduto.TabIndex = 41;
            this.lblNomeProduto.Text = "Nome :";
            // 
            // txtProdutoID
            // 
            this.txtProdutoID.Location = new System.Drawing.Point(105, 63);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.ReadOnly = true;
            this.txtProdutoID.Size = new System.Drawing.Size(213, 20);
            this.txtProdutoID.TabIndex = 40;
            // 
            // lblProdutoID
            // 
            this.lblProdutoID.AutoSize = true;
            this.lblProdutoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoID.Location = new System.Drawing.Point(12, 62);
            this.lblProdutoID.Name = "lblProdutoID";
            this.lblProdutoID.Size = new System.Drawing.Size(31, 16);
            this.lblProdutoID.TabIndex = 39;
            this.lblProdutoID.Text = "ID :";
            // 
            // lblCategoriaProduto
            // 
            this.lblCategoriaProduto.AutoSize = true;
            this.lblCategoriaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProduto.Location = new System.Drawing.Point(12, 119);
            this.lblCategoriaProduto.Name = "lblCategoriaProduto";
            this.lblCategoriaProduto.Size = new System.Drawing.Size(80, 16);
            this.lblCategoriaProduto.TabIndex = 52;
            this.lblCategoriaProduto.Text = "Categoria:";
            // 
            // cboCategoriaProduto
            // 
            this.cboCategoriaProduto.FormattingEnabled = true;
            this.cboCategoriaProduto.Location = new System.Drawing.Point(105, 118);
            this.cboCategoriaProduto.Name = "cboCategoriaProduto";
            this.cboCategoriaProduto.Size = new System.Drawing.Size(213, 21);
            this.cboCategoriaProduto.TabIndex = 53;
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.Location = new System.Drawing.Point(12, 220);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(53, 16);
            this.lblValorProduto.TabIndex = 54;
            this.lblValorProduto.Text = "Valor :";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(105, 219);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(213, 20);
            this.txtValorProduto.TabIndex = 55;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.cboCategoriaProduto);
            this.Controls.Add(this.lblCategoriaProduto);
            this.Controls.Add(this.grdProduto);
            this.Controls.Add(this.txtSearchProduto);
            this.Controls.Add(this.lblSearchCategoria);
            this.Controls.Add(this.btnLimparProduto);
            this.Controls.Add(this.btnUpgradeProduto);
            this.Controls.Add(this.btnDeleteProduto);
            this.Controls.Add(this.btnConfirmProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.lblDescricaoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.txtProdutoID);
            this.Controls.Add(this.lblProdutoID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView grdProduto;
        private System.Windows.Forms.TextBox txtSearchProduto;
        private System.Windows.Forms.Label lblSearchCategoria;
        private System.Windows.Forms.Button btnLimparProduto;
        private System.Windows.Forms.Button btnUpgradeProduto;
        private System.Windows.Forms.Button btnDeleteProduto;
        private System.Windows.Forms.Button btnConfirmProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtProdutoID;
        private System.Windows.Forms.Label lblProdutoID;
        private System.Windows.Forms.Label lblCategoriaProduto;
        private System.Windows.Forms.ComboBox cboCategoriaProduto;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
    }
}