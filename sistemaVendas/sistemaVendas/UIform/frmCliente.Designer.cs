namespace sistemaVendas.UIform
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnUpgradeCliente = new System.Windows.Forms.Button();
            this.btnDeleteCliente = new System.Windows.Forms.Button();
            this.btnConfirmCliente = new System.Windows.Forms.Button();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.txtSearchCliente = new System.Windows.Forms.TextBox();
            this.lblSearchCliente = new System.Windows.Forms.Label();
            this.cboClienteType = new System.Windows.Forms.ComboBox();
            this.txtAdressCliente = new System.Windows.Forms.TextBox();
            this.lblAdressCliente = new System.Windows.Forms.Label();
            this.txtContactCliente = new System.Windows.Forms.TextBox();
            this.lblContactCliente = new System.Windows.Forms.Label();
            this.lblTypeClinte = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtNameCliente = new System.Windows.Forms.TextBox();
            this.lblNameCliente = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 43);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(925, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(325, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(189, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Formulario de Clientes";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(153, 292);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 37);
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnUpgradeCliente
            // 
            this.btnUpgradeCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnUpgradeCliente.Image")));
            this.btnUpgradeCliente.Location = new System.Drawing.Point(877, 292);
            this.btnUpgradeCliente.Name = "btnUpgradeCliente";
            this.btnUpgradeCliente.Size = new System.Drawing.Size(81, 72);
            this.btnUpgradeCliente.TabIndex = 58;
            this.btnUpgradeCliente.UseVisualStyleBackColor = true;
            this.btnUpgradeCliente.Click += new System.EventHandler(this.BtnUpgradeCliente_Click);
            // 
            // btnDeleteCliente
            // 
            this.btnDeleteCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCliente.Image")));
            this.btnDeleteCliente.Location = new System.Drawing.Point(661, 292);
            this.btnDeleteCliente.Name = "btnDeleteCliente";
            this.btnDeleteCliente.Size = new System.Drawing.Size(79, 72);
            this.btnDeleteCliente.TabIndex = 57;
            this.btnDeleteCliente.UseVisualStyleBackColor = true;
            this.btnDeleteCliente.Click += new System.EventHandler(this.BtnDeleteCliente_Click);
            // 
            // btnConfirmCliente
            // 
            this.btnConfirmCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmCliente.Image")));
            this.btnConfirmCliente.Location = new System.Drawing.Point(413, 292);
            this.btnConfirmCliente.Name = "btnConfirmCliente";
            this.btnConfirmCliente.Size = new System.Drawing.Size(97, 72);
            this.btnConfirmCliente.TabIndex = 56;
            this.btnConfirmCliente.UseVisualStyleBackColor = true;
            this.btnConfirmCliente.Click += new System.EventHandler(this.BtnConfirmCliente_Click);
            // 
            // grdCliente
            // 
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(413, 87);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.Size = new System.Drawing.Size(545, 180);
            this.grdCliente.TabIndex = 55;
            this.grdCliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdCliente_RowHeaderMouseClick);
            // 
            // txtSearchCliente
            // 
            this.txtSearchCliente.Location = new System.Drawing.Point(502, 61);
            this.txtSearchCliente.Name = "txtSearchCliente";
            this.txtSearchCliente.Size = new System.Drawing.Size(456, 20);
            this.txtSearchCliente.TabIndex = 54;
            this.txtSearchCliente.TextChanged += new System.EventHandler(this.TxtSearchCliente_TextChanged);
            // 
            // lblSearchCliente
            // 
            this.lblSearchCliente.AutoSize = true;
            this.lblSearchCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCliente.Location = new System.Drawing.Point(410, 65);
            this.lblSearchCliente.Name = "lblSearchCliente";
            this.lblSearchCliente.Size = new System.Drawing.Size(86, 16);
            this.lblSearchCliente.TabIndex = 53;
            this.lblSearchCliente.Text = "Pesquisar :";
            // 
            // cboClienteType
            // 
            this.cboClienteType.FormattingEnabled = true;
            this.cboClienteType.Items.AddRange(new object[] {
            "Comum",
            "Revendedor"});
            this.cboClienteType.Location = new System.Drawing.Point(153, 119);
            this.cboClienteType.Name = "cboClienteType";
            this.cboClienteType.Size = new System.Drawing.Size(213, 21);
            this.cboClienteType.TabIndex = 51;
            // 
            // txtAdressCliente
            // 
            this.txtAdressCliente.Location = new System.Drawing.Point(153, 203);
            this.txtAdressCliente.Multiline = true;
            this.txtAdressCliente.Name = "txtAdressCliente";
            this.txtAdressCliente.Size = new System.Drawing.Size(213, 64);
            this.txtAdressCliente.TabIndex = 50;
            // 
            // lblAdressCliente
            // 
            this.lblAdressCliente.AutoSize = true;
            this.lblAdressCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressCliente.Location = new System.Drawing.Point(12, 231);
            this.lblAdressCliente.Name = "lblAdressCliente";
            this.lblAdressCliente.Size = new System.Drawing.Size(83, 16);
            this.lblAdressCliente.TabIndex = 49;
            this.lblAdressCliente.Text = "Endereço :";
            // 
            // txtContactCliente
            // 
            this.txtContactCliente.Location = new System.Drawing.Point(153, 177);
            this.txtContactCliente.Name = "txtContactCliente";
            this.txtContactCliente.Size = new System.Drawing.Size(213, 20);
            this.txtContactCliente.TabIndex = 48;
            // 
            // lblContactCliente
            // 
            this.lblContactCliente.AutoSize = true;
            this.lblContactCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactCliente.Location = new System.Drawing.Point(12, 177);
            this.lblContactCliente.Name = "lblContactCliente";
            this.lblContactCliente.Size = new System.Drawing.Size(69, 16);
            this.lblContactCliente.TabIndex = 47;
            this.lblContactCliente.Text = "Contato :";
            // 
            // lblTypeClinte
            // 
            this.lblTypeClinte.AutoSize = true;
            this.lblTypeClinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeClinte.Location = new System.Drawing.Point(12, 124);
            this.lblTypeClinte.Name = "lblTypeClinte";
            this.lblTypeClinte.Size = new System.Drawing.Size(122, 16);
            this.lblTypeClinte.TabIndex = 44;
            this.lblTypeClinte.Text = "Tipo de Cliente :";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(153, 149);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(213, 20);
            this.txtEmailCliente.TabIndex = 40;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(12, 149);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(55, 16);
            this.lblEmailCliente.TabIndex = 39;
            this.lblEmailCliente.Text = "Email :";
            // 
            // txtNameCliente
            // 
            this.txtNameCliente.Location = new System.Drawing.Point(153, 93);
            this.txtNameCliente.Name = "txtNameCliente";
            this.txtNameCliente.Size = new System.Drawing.Size(213, 20);
            this.txtNameCliente.TabIndex = 36;
            // 
            // lblNameCliente
            // 
            this.lblNameCliente.AutoSize = true;
            this.lblNameCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCliente.Location = new System.Drawing.Point(12, 93);
            this.lblNameCliente.Name = "lblNameCliente";
            this.lblNameCliente.Size = new System.Drawing.Size(57, 16);
            this.lblNameCliente.TabIndex = 35;
            this.lblNameCliente.Text = "Nome :";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(153, 65);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.ReadOnly = true;
            this.txtClienteID.Size = new System.Drawing.Size(213, 20);
            this.txtClienteID.TabIndex = 34;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(12, 65);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(31, 16);
            this.lblClienteID.TabIndex = 33;
            this.lblClienteID.Text = "ID :";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 388);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnUpgradeCliente);
            this.Controls.Add(this.btnDeleteCliente);
            this.Controls.Add(this.btnConfirmCliente);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.txtSearchCliente);
            this.Controls.Add(this.lblSearchCliente);
            this.Controls.Add(this.cboClienteType);
            this.Controls.Add(this.txtAdressCliente);
            this.Controls.Add(this.lblAdressCliente);
            this.Controls.Add(this.txtContactCliente);
            this.Controls.Add(this.lblContactCliente);
            this.Controls.Add(this.lblTypeClinte);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.txtNameCliente);
            this.Controls.Add(this.lblNameCliente);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnUpgradeCliente;
        private System.Windows.Forms.Button btnDeleteCliente;
        private System.Windows.Forms.Button btnConfirmCliente;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.TextBox txtSearchCliente;
        private System.Windows.Forms.Label lblSearchCliente;
        private System.Windows.Forms.ComboBox cboClienteType;
        private System.Windows.Forms.TextBox txtAdressCliente;
        private System.Windows.Forms.Label lblAdressCliente;
        private System.Windows.Forms.TextBox txtContactCliente;
        private System.Windows.Forms.Label lblContactCliente;
        private System.Windows.Forms.Label lblTypeClinte;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtNameCliente;
        private System.Windows.Forms.Label lblNameCliente;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label lblClienteID;
    }
}