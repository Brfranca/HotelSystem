namespace PresentationLayer
{
    partial class FormSearchSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picRoomClose = new System.Windows.Forms.PictureBox();
            this.dgvSuppliersSearch = new System.Windows.Forms.DataGridView();
            this.pnlSuppCNPJ = new System.Windows.Forms.Panel();
            this.txtSuppSearchCNPJ = new System.Windows.Forms.TextBox();
            this.pnlSuppName = new System.Windows.Forms.Panel();
            this.txtSuppSearchName = new System.Windows.Forms.TextBox();
            this.lblConsSupCod = new System.Windows.Forms.Label();
            this.lblConsSupNome = new System.Windows.Forms.Label();
            this.btnSupplierSelect = new System.Windows.Forms.Button();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 8);
            this.picIcone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(32, 25);
            this.picIcone.TabIndex = 171;
            this.picIcone.TabStop = false;
            // 
            // lblNomeFarmacia
            // 
            this.lblNomeFarmacia.AutoSize = true;
            this.lblNomeFarmacia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeFarmacia.ForeColor = System.Drawing.Color.White;
            this.lblNomeFarmacia.Location = new System.Drawing.Point(34, 10);
            this.lblNomeFarmacia.Name = "lblNomeFarmacia";
            this.lblNomeFarmacia.Size = new System.Drawing.Size(240, 28);
            this.lblNomeFarmacia.TabIndex = 0;
            this.lblNomeFarmacia.Text = "Fornecedores cadastrados";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(77)))));
            this.pnlTopBar.Controls.Add(this.picRoomClose);
            this.pnlTopBar.Controls.Add(this.picIcone);
            this.pnlTopBar.Controls.Add(this.lblNomeFarmacia);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(563, 40);
            this.pnlTopBar.TabIndex = 224;
            // 
            // picRoomClose
            // 
            this.picRoomClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRoomClose.BackColor = System.Drawing.Color.Transparent;
            this.picRoomClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoomClose.BackgroundImage")));
            this.picRoomClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRoomClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomClose.Location = new System.Drawing.Point(517, 8);
            this.picRoomClose.Margin = new System.Windows.Forms.Padding(0);
            this.picRoomClose.Name = "picRoomClose";
            this.picRoomClose.Size = new System.Drawing.Size(29, 24);
            this.picRoomClose.TabIndex = 172;
            this.picRoomClose.TabStop = false;
            this.picRoomClose.Click += new System.EventHandler(this.picRoomClose_Click);
            // 
            // dgvSuppliersSearch
            // 
            this.dgvSuppliersSearch.AllowUserToAddRows = false;
            this.dgvSuppliersSearch.AllowUserToDeleteRows = false;
            this.dgvSuppliersSearch.AllowUserToResizeColumns = false;
            this.dgvSuppliersSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSuppliersSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliersSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliersSearch.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSuppliersSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliersSearch.ColumnHeadersHeight = 29;
            this.dgvSuppliersSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliersSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvSuppliersSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliersSearch.Location = new System.Drawing.Point(22, 114);
            this.dgvSuppliersSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSuppliersSearch.Name = "dgvSuppliersSearch";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSuppliersSearch.RowHeadersVisible = false;
            this.dgvSuppliersSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSuppliersSearch.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSuppliersSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliersSearch.Size = new System.Drawing.Size(518, 379);
            this.dgvSuppliersSearch.TabIndex = 225;
            // 
            // pnlSuppCNPJ
            // 
            this.pnlSuppCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlSuppCNPJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSuppCNPJ.Location = new System.Drawing.Point(334, 104);
            this.pnlSuppCNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuppCNPJ.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSuppCNPJ.Name = "pnlSuppCNPJ";
            this.pnlSuppCNPJ.Size = new System.Drawing.Size(206, 1);
            this.pnlSuppCNPJ.TabIndex = 231;
            // 
            // txtSuppSearchCNPJ
            // 
            this.txtSuppSearchCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtSuppSearchCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuppSearchCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppSearchCNPJ.ForeColor = System.Drawing.Color.Black;
            this.txtSuppSearchCNPJ.Location = new System.Drawing.Point(338, 83);
            this.txtSuppSearchCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.txtSuppSearchCNPJ.MaxLength = 11;
            this.txtSuppSearchCNPJ.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSuppSearchCNPJ.Name = "txtSuppSearchCNPJ";
            this.txtSuppSearchCNPJ.Size = new System.Drawing.Size(191, 27);
            this.txtSuppSearchCNPJ.TabIndex = 232;
            // 
            // pnlSuppName
            // 
            this.pnlSuppName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlSuppName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSuppName.Location = new System.Drawing.Point(21, 103);
            this.pnlSuppName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuppName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSuppName.Name = "pnlSuppName";
            this.pnlSuppName.Size = new System.Drawing.Size(270, 1);
            this.pnlSuppName.TabIndex = 229;
            // 
            // txtSuppSearchName
            // 
            this.txtSuppSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtSuppSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuppSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtSuppSearchName.Location = new System.Drawing.Point(25, 82);
            this.txtSuppSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSuppSearchName.MaxLength = 11;
            this.txtSuppSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSuppSearchName.Name = "txtSuppSearchName";
            this.txtSuppSearchName.Size = new System.Drawing.Size(258, 27);
            this.txtSuppSearchName.TabIndex = 230;
            // 
            // lblConsSupCod
            // 
            this.lblConsSupCod.AutoSize = true;
            this.lblConsSupCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsSupCod.Location = new System.Drawing.Point(330, 60);
            this.lblConsSupCod.Name = "lblConsSupCod";
            this.lblConsSupCod.Size = new System.Drawing.Size(51, 23);
            this.lblConsSupCod.TabIndex = 228;
            this.lblConsSupCod.Text = "CNPJ";
            // 
            // lblConsSupNome
            // 
            this.lblConsSupNome.AutoSize = true;
            this.lblConsSupNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsSupNome.Location = new System.Drawing.Point(18, 60);
            this.lblConsSupNome.Name = "lblConsSupNome";
            this.lblConsSupNome.Size = new System.Drawing.Size(109, 23);
            this.lblConsSupNome.TabIndex = 227;
            this.lblConsSupNome.Text = "Razão Social";
            // 
            // btnSupplierSelect
            // 
            this.btnSupplierSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnSupplierSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnSupplierSelect.FlatAppearance.BorderSize = 3;
            this.btnSupplierSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierSelect.ForeColor = System.Drawing.Color.White;
            this.btnSupplierSelect.Location = new System.Drawing.Point(192, 501);
            this.btnSupplierSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierSelect.Name = "btnSupplierSelect";
            this.btnSupplierSelect.Size = new System.Drawing.Size(189, 36);
            this.btnSupplierSelect.TabIndex = 233;
            this.btnSupplierSelect.Text = "Selecionar";
            this.btnSupplierSelect.UseVisualStyleBackColor = false;
            this.btnSupplierSelect.Click += new System.EventHandler(this.btnSupplierSelect_Click);
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.HeaderText = "Razão Social";
            this.ColumnCompanyName.MinimumWidth = 6;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.FillWeight = 75F;
            this.ColumnCnpj.HeaderText = "CNPJ";
            this.ColumnCnpj.MinimumWidth = 6;
            this.ColumnCnpj.Name = "ColumnCnpj";
            this.ColumnCnpj.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // FormSearchSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 550);
            this.Controls.Add(this.btnSupplierSelect);
            this.Controls.Add(this.pnlSuppCNPJ);
            this.Controls.Add(this.txtSuppSearchCNPJ);
            this.Controls.Add(this.pnlSuppName);
            this.Controls.Add(this.txtSuppSearchName);
            this.Controls.Add(this.lblConsSupCod);
            this.Controls.Add(this.lblConsSupNome);
            this.Controls.Add(this.dgvSuppliersSearch);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSearchSupplier";
            this.Text = "FormSearchSupplier";
            this.Load += new System.EventHandler(this.FormSearchSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picRoomClose;
        private System.Windows.Forms.DataGridView dgvSuppliersSearch;
        private System.Windows.Forms.Panel pnlSuppCNPJ;
        private System.Windows.Forms.TextBox txtSuppSearchCNPJ;
        private System.Windows.Forms.Panel pnlSuppName;
        private System.Windows.Forms.TextBox txtSuppSearchName;
        private System.Windows.Forms.Label lblConsSupCod;
        private System.Windows.Forms.Label lblConsSupNome;
        private System.Windows.Forms.Button btnSupplierSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCnpj;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}