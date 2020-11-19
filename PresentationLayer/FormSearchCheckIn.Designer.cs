namespace PresentationLayer
{
    partial class FormSearchCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchCheckIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCpf = new System.Windows.Forms.Panel();
            this.txtSearchCPF = new System.Windows.Forms.TextBox();
            this.pnlNumber = new System.Windows.Forms.Panel();
            this.txtSearchRoomNumber = new System.Windows.Forms.TextBox();
            this.lblConsSupCod = new System.Windows.Forms.Label();
            this.lblConsSupNome = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFarmacia
            // 
            this.lblNomeFarmacia.AutoSize = true;
            this.lblNomeFarmacia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeFarmacia.ForeColor = System.Drawing.Color.White;
            this.lblNomeFarmacia.Location = new System.Drawing.Point(43, 9);
            this.lblNomeFarmacia.Name = "lblNomeFarmacia";
            this.lblNomeFarmacia.Size = new System.Drawing.Size(85, 28);
            this.lblNomeFarmacia.TabIndex = 0;
            this.lblNomeFarmacia.Text = "Check In";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.picClose);
            this.pnlTopBar.Controls.Add(this.lblNomeFarmacia);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(624, 40);
            this.pnlTopBar.TabIndex = 5;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(582, 2);
            this.picClose.Margin = new System.Windows.Forms.Padding(0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(26, 36);
            this.picClose.TabIndex = 172;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(220, 508);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(189, 36);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearch.ColumnHeadersHeight = 29;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ColumnCnpj,
            this.ColumnCompanyName,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearch.Location = new System.Drawing.Point(22, 121);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSearch.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(571, 379);
            this.dgvSearch.TabIndex = 3;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            this.dgvSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 25F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 75F;
            this.Column2.HeaderText = "Nome";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.FillWeight = 75F;
            this.ColumnCnpj.HeaderText = "CPF";
            this.ColumnCnpj.MinimumWidth = 6;
            this.ColumnCnpj.Name = "ColumnCnpj";
            this.ColumnCnpj.ReadOnly = true;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.FillWeight = 45F;
            this.ColumnCompanyName.HeaderText = "Nº Quarto";
            this.ColumnCompanyName.MinimumWidth = 6;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 55F;
            this.Column3.HeaderText = "Check In";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.TabIndex = 259;
            this.pictureBox1.TabStop = false;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.White;
            this.pnlName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlName.Location = new System.Drawing.Point(23, 111);
            this.pnlName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(200, 1);
            this.pnlName.TabIndex = 280;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(27, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 11;
            this.txtName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 279;
            this.label1.Text = "Nome do Cliente";
            // 
            // pnlCpf
            // 
            this.pnlCpf.BackColor = System.Drawing.Color.White;
            this.pnlCpf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlCpf.Location = new System.Drawing.Point(244, 111);
            this.pnlCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCpf.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlCpf.Name = "pnlCpf";
            this.pnlCpf.Size = new System.Drawing.Size(150, 1);
            this.pnlCpf.TabIndex = 277;
            // 
            // txtSearchCPF
            // 
            this.txtSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtSearchCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCPF.ForeColor = System.Drawing.Color.White;
            this.txtSearchCPF.Location = new System.Drawing.Point(248, 90);
            this.txtSearchCPF.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchCPF.MaxLength = 11;
            this.txtSearchCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSearchCPF.Name = "txtSearchCPF";
            this.txtSearchCPF.Size = new System.Drawing.Size(146, 27);
            this.txtSearchCPF.TabIndex = 1;
            this.txtSearchCPF.TextChanged += new System.EventHandler(this.txtSearchCPF_TextChanged);
            this.txtSearchCPF.Enter += new System.EventHandler(this.txtSearchCPF_Enter);
            this.txtSearchCPF.Leave += new System.EventHandler(this.txtSearchCPF_Leave);
            // 
            // pnlNumber
            // 
            this.pnlNumber.BackColor = System.Drawing.Color.White;
            this.pnlNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlNumber.Location = new System.Drawing.Point(425, 110);
            this.pnlNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNumber.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlNumber.Name = "pnlNumber";
            this.pnlNumber.Size = new System.Drawing.Size(150, 1);
            this.pnlNumber.TabIndex = 275;
            // 
            // txtSearchRoomNumber
            // 
            this.txtSearchRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtSearchRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoomNumber.ForeColor = System.Drawing.Color.White;
            this.txtSearchRoomNumber.Location = new System.Drawing.Point(429, 89);
            this.txtSearchRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchRoomNumber.MaxLength = 11;
            this.txtSearchRoomNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSearchRoomNumber.Name = "txtSearchRoomNumber";
            this.txtSearchRoomNumber.Size = new System.Drawing.Size(146, 27);
            this.txtSearchRoomNumber.TabIndex = 2;
            this.txtSearchRoomNumber.TextChanged += new System.EventHandler(this.txtSearchRoomNumber_TextChanged);
            this.txtSearchRoomNumber.Enter += new System.EventHandler(this.txtSearchRoomNumber_Enter);
            this.txtSearchRoomNumber.Leave += new System.EventHandler(this.txtSearchRoomNumber_Leave);
            // 
            // lblConsSupCod
            // 
            this.lblConsSupCod.AutoSize = true;
            this.lblConsSupCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupCod.ForeColor = System.Drawing.Color.White;
            this.lblConsSupCod.Location = new System.Drawing.Point(240, 67);
            this.lblConsSupCod.Name = "lblConsSupCod";
            this.lblConsSupCod.Size = new System.Drawing.Size(45, 23);
            this.lblConsSupCod.TabIndex = 274;
            this.lblConsSupCod.Text = "CPF ";
            // 
            // lblConsSupNome
            // 
            this.lblConsSupNome.AutoSize = true;
            this.lblConsSupNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupNome.ForeColor = System.Drawing.Color.White;
            this.lblConsSupNome.Location = new System.Drawing.Point(422, 67);
            this.lblConsSupNome.Name = "lblConsSupNome";
            this.lblConsSupNome.Size = new System.Drawing.Size(160, 23);
            this.lblConsSupNome.TabIndex = 273;
            this.lblConsSupNome.Text = "Número do quarto";
            // 
            // FormSearchCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(624, 550);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCpf);
            this.Controls.Add(this.txtSearchCPF);
            this.Controls.Add(this.pnlNumber);
            this.Controls.Add(this.txtSearchRoomNumber);
            this.Controls.Add(this.lblConsSupCod);
            this.Controls.Add(this.lblConsSupNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSearchCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchCheckIn";
            this.Load += new System.EventHandler(this.FormSearchCheckIn_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCpf;
        private System.Windows.Forms.TextBox txtSearchCPF;
        private System.Windows.Forms.Panel pnlNumber;
        private System.Windows.Forms.TextBox txtSearchRoomNumber;
        private System.Windows.Forms.Label lblConsSupCod;
        private System.Windows.Forms.Label lblConsSupNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}