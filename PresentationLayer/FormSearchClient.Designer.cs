﻿namespace PresentationLayer
{
    partial class FormSearchClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchClient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlCpf = new System.Windows.Forms.Panel();
            this.txtSearchCPF = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblConsSupCod = new System.Windows.Forms.Label();
            this.lblConsSupNome = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.picIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.SuspendLayout();
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
            this.btnSelect.Location = new System.Drawing.Point(193, 508);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(189, 36);
            this.btnSelect.TabIndex = 250;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlCpf
            // 
            this.pnlCpf.BackColor = System.Drawing.Color.White;
            this.pnlCpf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlCpf.Location = new System.Drawing.Point(335, 111);
            this.pnlCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCpf.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlCpf.Name = "pnlCpf";
            this.pnlCpf.Size = new System.Drawing.Size(206, 1);
            this.pnlCpf.TabIndex = 248;
            // 
            // txtSearchCPF
            // 
            this.txtSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtSearchCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCPF.ForeColor = System.Drawing.Color.White;
            this.txtSearchCPF.Location = new System.Drawing.Point(339, 90);
            this.txtSearchCPF.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchCPF.MaxLength = 11;
            this.txtSearchCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSearchCPF.Name = "txtSearchCPF";
            this.txtSearchCPF.Size = new System.Drawing.Size(191, 27);
            this.txtSearchCPF.TabIndex = 249;
            this.txtSearchCPF.TextChanged += new System.EventHandler(this.txtSearchCPF_TextChanged);
            this.txtSearchCPF.Enter += new System.EventHandler(this.txtSearchCPF_Enter);
            this.txtSearchCPF.Leave += new System.EventHandler(this.txtSearchCPF_Leave);
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.White;
            this.pnlName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlName.Location = new System.Drawing.Point(22, 110);
            this.pnlName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(270, 1);
            this.pnlName.TabIndex = 246;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSearchName.Location = new System.Drawing.Point(26, 89);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchName.MaxLength = 11;
            this.txtSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(258, 27);
            this.txtSearchName.TabIndex = 247;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            this.txtSearchName.Enter += new System.EventHandler(this.txtSearchName_Enter);
            this.txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            // 
            // lblConsSupCod
            // 
            this.lblConsSupCod.AutoSize = true;
            this.lblConsSupCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupCod.ForeColor = System.Drawing.Color.White;
            this.lblConsSupCod.Location = new System.Drawing.Point(331, 67);
            this.lblConsSupCod.Name = "lblConsSupCod";
            this.lblConsSupCod.Size = new System.Drawing.Size(40, 23);
            this.lblConsSupCod.TabIndex = 245;
            this.lblConsSupCod.Text = "CPF";
            // 
            // lblConsSupNome
            // 
            this.lblConsSupNome.AutoSize = true;
            this.lblConsSupNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupNome.ForeColor = System.Drawing.Color.White;
            this.lblConsSupNome.Location = new System.Drawing.Point(19, 67);
            this.lblConsSupNome.Name = "lblConsSupNome";
            this.lblConsSupNome.Size = new System.Drawing.Size(145, 23);
            this.lblConsSupNome.TabIndex = 244;
            this.lblConsSupNome.Text = "Nome do Cliente";
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvSearch.ColumnHeadersHeight = 29;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompanyName,
            this.ColumnCnpj});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvSearch.Location = new System.Drawing.Point(23, 121);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSearch.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(518, 379);
            this.dgvSearch.TabIndex = 243;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.HeaderText = "Nome";
            this.ColumnCompanyName.MinimumWidth = 6;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.FillWeight = 75F;
            this.ColumnCnpj.HeaderText = "CPF";
            this.ColumnCnpj.MinimumWidth = 6;
            this.ColumnCnpj.Name = "ColumnCnpj";
            this.ColumnCnpj.ReadOnly = true;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.picIcone);
            this.pnlTopBar.Controls.Add(this.picClose);
            this.pnlTopBar.Controls.Add(this.lblNomeFarmacia);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(563, 40);
            this.pnlTopBar.TabIndex = 242;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(521, 2);
            this.picClose.Margin = new System.Windows.Forms.Padding(0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(26, 36);
            this.picClose.TabIndex = 172;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblNomeFarmacia
            // 
            this.lblNomeFarmacia.AutoSize = true;
            this.lblNomeFarmacia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeFarmacia.ForeColor = System.Drawing.Color.White;
            this.lblNomeFarmacia.Location = new System.Drawing.Point(43, 9);
            this.lblNomeFarmacia.Name = "lblNomeFarmacia";
            this.lblNomeFarmacia.Size = new System.Drawing.Size(190, 28);
            this.lblNomeFarmacia.TabIndex = 0;
            this.lblNomeFarmacia.Text = "Clientes cadastrados";
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 3);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(43, 35);
            this.picIcone.TabIndex = 179;
            this.picIcone.TabStop = false;
            // 
            // FormSearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(563, 550);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pnlCpf);
            this.Controls.Add(this.txtSearchCPF);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblConsSupCod);
            this.Controls.Add(this.lblConsSupNome);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSearchClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchClient";
            this.Load += new System.EventHandler(this.FormSearchClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlCpf;
        private System.Windows.Forms.TextBox txtSearchCPF;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblConsSupCod;
        private System.Windows.Forms.Label lblConsSupNome;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCnpj;
        private System.Windows.Forms.PictureBox picIcone;
    }
}