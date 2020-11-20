namespace PresentationLayer
{
    partial class FormSearchProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picProductClose = new System.Windows.Forms.PictureBox();
            this.btnProductSelect = new System.Windows.Forms.Button();
            this.pnlSuppId = new System.Windows.Forms.Panel();
            this.txtProduSearchID = new System.Windows.Forms.TextBox();
            this.pnlSuppName = new System.Windows.Forms.Panel();
            this.txtSuppSearchName = new System.Windows.Forms.TextBox();
            this.lblConsSupCod = new System.Windows.Forms.Label();
            this.lblConsSupNome = new System.Windows.Forms.Label();
            this.dgvProductSearch = new System.Windows.Forms.DataGridView();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeTabela.ForeColor = System.Drawing.Color.White;
            this.lblNomeTabela.Location = new System.Drawing.Point(43, 9);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(202, 28);
            this.lblNomeTabela.TabIndex = 0;
            this.lblNomeTabela.Text = "Produtos cadastrados";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.picProductClose);
            this.pnlTopBar.Controls.Add(this.lblNomeTabela);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(563, 40);
            this.pnlTopBar.TabIndex = 225;
            // 
            // picProductClose
            // 
            this.picProductClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProductClose.BackColor = System.Drawing.Color.Transparent;
            this.picProductClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProductClose.BackgroundImage")));
            this.picProductClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProductClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProductClose.Location = new System.Drawing.Point(521, 2);
            this.picProductClose.Margin = new System.Windows.Forms.Padding(0);
            this.picProductClose.Name = "picProductClose";
            this.picProductClose.Size = new System.Drawing.Size(26, 36);
            this.picProductClose.TabIndex = 172;
            this.picProductClose.TabStop = false;
            this.picProductClose.Click += new System.EventHandler(this.picProductClose_Click);
            // 
            // btnProductSelect
            // 
            this.btnProductSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnProductSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnProductSelect.FlatAppearance.BorderSize = 0;
            this.btnProductSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnProductSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSelect.Image")));
            this.btnProductSelect.Location = new System.Drawing.Point(193, 508);
            this.btnProductSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductSelect.Name = "btnProductSelect";
            this.btnProductSelect.Size = new System.Drawing.Size(189, 36);
            this.btnProductSelect.TabIndex = 241;
            this.btnProductSelect.Text = "Selecionar";
            this.btnProductSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductSelect.UseVisualStyleBackColor = false;
            this.btnProductSelect.Click += new System.EventHandler(this.btnProductSelect_Click);
            // 
            // pnlSuppId
            // 
            this.pnlSuppId.BackColor = System.Drawing.Color.White;
            this.pnlSuppId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSuppId.Location = new System.Drawing.Point(335, 111);
            this.pnlSuppId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuppId.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSuppId.Name = "pnlSuppId";
            this.pnlSuppId.Size = new System.Drawing.Size(150, 1);
            this.pnlSuppId.TabIndex = 239;
            // 
            // txtProduSearchID
            // 
            this.txtProduSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtProduSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduSearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduSearchID.ForeColor = System.Drawing.Color.White;
            this.txtProduSearchID.Location = new System.Drawing.Point(339, 90);
            this.txtProduSearchID.Margin = new System.Windows.Forms.Padding(0);
            this.txtProduSearchID.MaxLength = 11;
            this.txtProduSearchID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProduSearchID.Name = "txtProduSearchID";
            this.txtProduSearchID.Size = new System.Drawing.Size(137, 27);
            this.txtProduSearchID.TabIndex = 240;
            this.txtProduSearchID.TextChanged += new System.EventHandler(this.txtProduSearchID_TextChanged);
            this.txtProduSearchID.Enter += new System.EventHandler(this.txtProduSearchID_Enter);
            this.txtProduSearchID.Leave += new System.EventHandler(this.txtProduSearchID_Leave);
            // 
            // pnlSuppName
            // 
            this.pnlSuppName.BackColor = System.Drawing.Color.White;
            this.pnlSuppName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSuppName.Location = new System.Drawing.Point(22, 110);
            this.pnlSuppName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuppName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSuppName.Name = "pnlSuppName";
            this.pnlSuppName.Size = new System.Drawing.Size(270, 1);
            this.pnlSuppName.TabIndex = 237;
            // 
            // txtSuppSearchName
            // 
            this.txtSuppSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtSuppSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuppSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSuppSearchName.Location = new System.Drawing.Point(26, 89);
            this.txtSuppSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSuppSearchName.MaxLength = 11;
            this.txtSuppSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSuppSearchName.Name = "txtSuppSearchName";
            this.txtSuppSearchName.Size = new System.Drawing.Size(258, 27);
            this.txtSuppSearchName.TabIndex = 238;
            this.txtSuppSearchName.TextChanged += new System.EventHandler(this.txtSuppSearchName_TextChanged);
            this.txtSuppSearchName.Enter += new System.EventHandler(this.txtSuppSearchName_Enter);
            this.txtSuppSearchName.Leave += new System.EventHandler(this.txtSuppSearchName_Leave);
            // 
            // lblConsSupCod
            // 
            this.lblConsSupCod.AutoSize = true;
            this.lblConsSupCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupCod.ForeColor = System.Drawing.Color.White;
            this.lblConsSupCod.Location = new System.Drawing.Point(331, 67);
            this.lblConsSupCod.Name = "lblConsSupCod";
            this.lblConsSupCod.Size = new System.Drawing.Size(28, 23);
            this.lblConsSupCod.TabIndex = 236;
            this.lblConsSupCod.Text = "ID";
            // 
            // lblConsSupNome
            // 
            this.lblConsSupNome.AutoSize = true;
            this.lblConsSupNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupNome.ForeColor = System.Drawing.Color.White;
            this.lblConsSupNome.Location = new System.Drawing.Point(19, 67);
            this.lblConsSupNome.Name = "lblConsSupNome";
            this.lblConsSupNome.Size = new System.Drawing.Size(58, 23);
            this.lblConsSupNome.TabIndex = 235;
            this.lblConsSupNome.Text = "Nome";
            // 
            // dgvProductSearch
            // 
            this.dgvProductSearch.AllowUserToAddRows = false;
            this.dgvProductSearch.AllowUserToDeleteRows = false;
            this.dgvProductSearch.AllowUserToResizeColumns = false;
            this.dgvProductSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvProductSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductSearch.ColumnHeadersHeight = 29;
            this.dgvProductSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompanyName,
            this.ColumnCnpj,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductSearch.Location = new System.Drawing.Point(23, 121);
            this.dgvProductSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductSearch.Name = "dgvProductSearch";
            this.dgvProductSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductSearch.RowHeadersVisible = false;
            this.dgvProductSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvProductSearch.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductSearch.Size = new System.Drawing.Size(518, 379);
            this.dgvProductSearch.TabIndex = 234;
            this.dgvProductSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSearch_CellClick);
            this.dgvProductSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductSearch_CellDoubleClick);
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.FillWeight = 40F;
            this.ColumnCompanyName.HeaderText = "ID";
            this.ColumnCompanyName.MinimumWidth = 6;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.FillWeight = 75F;
            this.ColumnCnpj.HeaderText = "Nome";
            this.ColumnCnpj.MinimumWidth = 6;
            this.ColumnCnpj.Name = "ColumnCnpj";
            this.ColumnCnpj.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descrição";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.TabIndex = 242;
            this.pictureBox1.TabStop = false;
            // 
            // FormSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(563, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProductSelect);
            this.Controls.Add(this.pnlSuppId);
            this.Controls.Add(this.txtProduSearchID);
            this.Controls.Add(this.pnlSuppName);
            this.Controls.Add(this.txtSuppSearchName);
            this.Controls.Add(this.lblConsSupCod);
            this.Controls.Add(this.lblConsSupNome);
            this.Controls.Add(this.dgvProductSearch);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchProduct";
            this.Load += new System.EventHandler(this.FormSearchProduct_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeTabela;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picProductClose;
        private System.Windows.Forms.Button btnProductSelect;
        private System.Windows.Forms.Panel pnlSuppId;
        private System.Windows.Forms.TextBox txtProduSearchID;
        private System.Windows.Forms.Panel pnlSuppName;
        private System.Windows.Forms.TextBox txtSuppSearchName;
        private System.Windows.Forms.Label lblConsSupCod;
        private System.Windows.Forms.Label lblConsSupNome;
        private System.Windows.Forms.DataGridView dgvProductSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}