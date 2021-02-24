namespace sistemaVendas.UIform
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.pictureBoxCategoria = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescricaoCategoria = new System.Windows.Forms.Label();
            this.txtTitleCategoria = new System.Windows.Forms.TextBox();
            this.lblTitleCategoria = new System.Windows.Forms.Label();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.lblCategoriaID = new System.Windows.Forms.Label();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.btnUpgradeCategoria = new System.Windows.Forms.Button();
            this.btnDeleteCategoria = new System.Windows.Forms.Button();
            this.btnConfirmCategoria = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grdCategoria = new System.Windows.Forms.DataGridView();
            this.txtSearchCategoria = new System.Windows.Forms.TextBox();
            this.lblSearchCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCategoria
            // 
            this.pictureBoxCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategoria.Image")));
            this.pictureBoxCategoria.Location = new System.Drawing.Point(764, 3);
            this.pictureBoxCategoria.Name = "pictureBoxCategoria";
            this.pictureBoxCategoria.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCategoria.TabIndex = 3;
            this.pictureBoxCategoria.TabStop = false;
            this.pictureBoxCategoria.Click += new System.EventHandler(this.PictureBoxCategoria_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxCategoria);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 43);
            this.panel1.TabIndex = 4;
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
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(325, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(202, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Formulario de Categoria";
            // 
            // lblDescricaoCategoria
            // 
            this.lblDescricaoCategoria.AutoSize = true;
            this.lblDescricaoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCategoria.Location = new System.Drawing.Point(12, 148);
            this.lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            this.lblDescricaoCategoria.Size = new System.Drawing.Size(87, 16);
            this.lblDescricaoCategoria.TabIndex = 13;
            this.lblDescricaoCategoria.Text = "Descrição :";
            this.lblDescricaoCategoria.Click += new System.EventHandler(this.LblDescricaoCategoria_Click);
            // 
            // txtTitleCategoria
            // 
            this.txtTitleCategoria.Location = new System.Drawing.Point(153, 120);
            this.txtTitleCategoria.Name = "txtTitleCategoria";
            this.txtTitleCategoria.Size = new System.Drawing.Size(213, 20);
            this.txtTitleCategoria.TabIndex = 12;
            this.txtTitleCategoria.TextChanged += new System.EventHandler(this.TxtTitleCategoria_TextChanged);
            // 
            // lblTitleCategoria
            // 
            this.lblTitleCategoria.AutoSize = true;
            this.lblTitleCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCategoria.Location = new System.Drawing.Point(12, 120);
            this.lblTitleCategoria.Name = "lblTitleCategoria";
            this.lblTitleCategoria.Size = new System.Drawing.Size(127, 16);
            this.lblTitleCategoria.TabIndex = 11;
            this.lblTitleCategoria.Text = "Titulo Categoria :";
            this.lblTitleCategoria.Click += new System.EventHandler(this.LblTitleCategoria_Click);
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Location = new System.Drawing.Point(153, 92);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.ReadOnly = true;
            this.txtCategoriaID.Size = new System.Drawing.Size(213, 20);
            this.txtCategoriaID.TabIndex = 10;
            this.txtCategoriaID.TextChanged += new System.EventHandler(this.TxtCategoriaID_TextChanged);
            // 
            // lblCategoriaID
            // 
            this.lblCategoriaID.AutoSize = true;
            this.lblCategoriaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaID.Location = new System.Drawing.Point(12, 92);
            this.lblCategoriaID.Name = "lblCategoriaID";
            this.lblCategoriaID.Size = new System.Drawing.Size(103, 16);
            this.lblCategoriaID.TabIndex = 9;
            this.lblCategoriaID.Text = "ID Categoria :";
            this.lblCategoriaID.Click += new System.EventHandler(this.LblCategoriaID_Click);
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(153, 146);
            this.txtDescricaoCategoria.Multiline = true;
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(213, 64);
            this.txtDescricaoCategoria.TabIndex = 21;
            this.txtDescricaoCategoria.TextChanged += new System.EventHandler(this.TxtDescricaoCategoria_TextChanged);
            // 
            // btnUpgradeCategoria
            // 
            this.btnUpgradeCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnUpgradeCategoria.Image")));
            this.btnUpgradeCategoria.Location = new System.Drawing.Point(695, 266);
            this.btnUpgradeCategoria.Name = "btnUpgradeCategoria";
            this.btnUpgradeCategoria.Size = new System.Drawing.Size(81, 72);
            this.btnUpgradeCategoria.TabIndex = 34;
            this.btnUpgradeCategoria.UseVisualStyleBackColor = true;
            this.btnUpgradeCategoria.Click += new System.EventHandler(this.BtnUpgradeCategoria_Click);
            // 
            // btnDeleteCategoria
            // 
            this.btnDeleteCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategoria.Image")));
            this.btnDeleteCategoria.Location = new System.Drawing.Point(586, 266);
            this.btnDeleteCategoria.Name = "btnDeleteCategoria";
            this.btnDeleteCategoria.Size = new System.Drawing.Size(79, 72);
            this.btnDeleteCategoria.TabIndex = 33;
            this.btnDeleteCategoria.UseVisualStyleBackColor = true;
            this.btnDeleteCategoria.Click += new System.EventHandler(this.BtnDeleteCategoria_Click);
            // 
            // btnConfirmCategoria
            // 
            this.btnConfirmCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmCategoria.Image")));
            this.btnConfirmCategoria.Location = new System.Drawing.Point(458, 266);
            this.btnConfirmCategoria.Name = "btnConfirmCategoria";
            this.btnConfirmCategoria.Size = new System.Drawing.Size(97, 72);
            this.btnConfirmCategoria.TabIndex = 32;
            this.btnConfirmCategoria.UseVisualStyleBackColor = true;
            this.btnConfirmCategoria.Click += new System.EventHandler(this.BtnConfirmCategoria_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(153, 223);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 37);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // grdCategoria
            // 
            this.grdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoria.Location = new System.Drawing.Point(458, 114);
            this.grdCategoria.Name = "grdCategoria";
            this.grdCategoria.Size = new System.Drawing.Size(339, 125);
            this.grdCategoria.TabIndex = 38;
            this.grdCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdCategoria_CellContentClick);
            this.grdCategoria.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdCategoria_RowHeaderMouseClick);
            // 
            // txtSearchCategoria
            // 
            this.txtSearchCategoria.Location = new System.Drawing.Point(547, 88);
            this.txtSearchCategoria.Name = "txtSearchCategoria";
            this.txtSearchCategoria.Size = new System.Drawing.Size(250, 20);
            this.txtSearchCategoria.TabIndex = 37;
            this.txtSearchCategoria.TextChanged += new System.EventHandler(this.TxtSearchCategoria_TextChanged);
            // 
            // lblSearchCategoria
            // 
            this.lblSearchCategoria.AutoSize = true;
            this.lblSearchCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCategoria.Location = new System.Drawing.Point(455, 92);
            this.lblSearchCategoria.Name = "lblSearchCategoria";
            this.lblSearchCategoria.Size = new System.Drawing.Size(86, 16);
            this.lblSearchCategoria.TabIndex = 36;
            this.lblSearchCategoria.Text = "Pesquisar :";
            this.lblSearchCategoria.Click += new System.EventHandler(this.LblSearchCategoria_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(819, 350);
            this.Controls.Add(this.grdCategoria);
            this.Controls.Add(this.txtSearchCategoria);
            this.Controls.Add(this.lblSearchCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnUpgradeCategoria);
            this.Controls.Add(this.btnDeleteCategoria);
            this.Controls.Add(this.btnConfirmCategoria);
            this.Controls.Add(this.txtDescricaoCategoria);
            this.Controls.Add(this.lblDescricaoCategoria);
            this.Controls.Add(this.txtTitleCategoria);
            this.Controls.Add(this.lblTitleCategoria);
            this.Controls.Add(this.txtCategoriaID);
            this.Controls.Add(this.lblCategoriaID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescricaoCategoria;
        private System.Windows.Forms.TextBox txtTitleCategoria;
        private System.Windows.Forms.Label lblTitleCategoria;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.Label lblCategoriaID;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
        private System.Windows.Forms.Button btnUpgradeCategoria;
        private System.Windows.Forms.Button btnDeleteCategoria;
        private System.Windows.Forms.Button btnConfirmCategoria;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView grdCategoria;
        private System.Windows.Forms.TextBox txtSearchCategoria;
        private System.Windows.Forms.Label lblSearchCategoria;
    }
}