namespace PresentationLayer
{
    partial class FormRegisterSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterSupplier));
            this.lblConsFornCadastrados = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picSupplierRefresh = new System.Windows.Forms.PictureBox();
            this.btnSupplierDelete = new System.Windows.Forms.Button();
            this.lblConsSupCod = new System.Windows.Forms.Label();
            this.lblConsSupNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSuppCNPJ = new System.Windows.Forms.Panel();
            this.txtSuppSearchCNPJ = new System.Windows.Forms.TextBox();
            this.pnlSuppName = new System.Windows.Forms.Panel();
            this.txtSuppSearchName = new System.Windows.Forms.TextBox();
            this.btnSupplierSelect = new System.Windows.Forms.Button();
            this.btnSupplierClear = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCadID = new System.Windows.Forms.Label();
            this.btnSupplierRegister = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblCadRazaoSocial = new System.Windows.Forms.Label();
            this.txtSupplierRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblCadCnpj = new System.Windows.Forms.Label();
            this.lblCadTel = new System.Windows.Forms.Label();
            this.txtSupplierTel = new System.Windows.Forms.TextBox();
            this.lblCadNomeContato = new System.Windows.Forms.Label();
            this.txtSupplierNomeContato = new System.Windows.Forms.TextBox();
            this.lblCadEmail = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplierRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsFornCadastrados
            // 
            this.lblConsFornCadastrados.AutoSize = true;
            this.lblConsFornCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsFornCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsFornCadastrados.ForeColor = System.Drawing.Color.White;
            this.lblConsFornCadastrados.Location = new System.Drawing.Point(387, 167);
            this.lblConsFornCadastrados.Name = "lblConsFornCadastrados";
            this.lblConsFornCadastrados.Size = new System.Drawing.Size(219, 23);
            this.lblConsFornCadastrados.TabIndex = 49;
            this.lblConsFornCadastrados.Text = "Fornecedores Cadastrados";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvSuppliers.ColumnHeadersHeight = 29;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompanyName,
            this.ColumnCnpj,
            this.ColumnTelefone,
            this.ColumnEmail});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvSuppliers.Location = new System.Drawing.Point(389, 188);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowHeadersWidth = 51;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(700, 344);
            this.dgvSuppliers.TabIndex = 50;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            this.dgvSuppliers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellDoubleClick);
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.FillWeight = 90F;
            this.ColumnCompanyName.HeaderText = "Razão Social";
            this.ColumnCompanyName.MinimumWidth = 6;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            // 
            // ColumnCnpj
            // 
            this.ColumnCnpj.FillWeight = 68F;
            this.ColumnCnpj.HeaderText = "CNPJ";
            this.ColumnCnpj.MinimumWidth = 6;
            this.ColumnCnpj.Name = "ColumnCnpj";
            this.ColumnCnpj.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.FillWeight = 68F;
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.MinimumWidth = 6;
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // picSupplierRefresh
            // 
            this.picSupplierRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picSupplierRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSupplierRefresh.BackgroundImage")));
            this.picSupplierRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSupplierRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSupplierRefresh.Location = new System.Drawing.Point(1042, 562);
            this.picSupplierRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picSupplierRefresh.Name = "picSupplierRefresh";
            this.picSupplierRefresh.Size = new System.Drawing.Size(42, 38);
            this.picSupplierRefresh.TabIndex = 195;
            this.picSupplierRefresh.TabStop = false;
            this.picSupplierRefresh.Click += new System.EventHandler(this.picSupplierRefresh_Click);
            // 
            // btnSupplierDelete
            // 
            this.btnSupplierDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplierDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSupplierDelete.FlatAppearance.BorderSize = 0;
            this.btnSupplierDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSupplierDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierDelete.Image")));
            this.btnSupplierDelete.Location = new System.Drawing.Point(748, 558);
            this.btnSupplierDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierDelete.Name = "btnSupplierDelete";
            this.btnSupplierDelete.Size = new System.Drawing.Size(138, 47);
            this.btnSupplierDelete.TabIndex = 194;
            this.btnSupplierDelete.Text = "Excluir";
            this.btnSupplierDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierDelete.UseVisualStyleBackColor = false;
            this.btnSupplierDelete.Click += new System.EventHandler(this.btnSupplierDelete_Click);
            // 
            // lblConsSupCod
            // 
            this.lblConsSupCod.AutoSize = true;
            this.lblConsSupCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupCod.ForeColor = System.Drawing.Color.White;
            this.lblConsSupCod.Location = new System.Drawing.Point(692, 109);
            this.lblConsSupCod.Name = "lblConsSupCod";
            this.lblConsSupCod.Size = new System.Drawing.Size(51, 23);
            this.lblConsSupCod.TabIndex = 198;
            this.lblConsSupCod.Text = "CNPJ";
            // 
            // lblConsSupNome
            // 
            this.lblConsSupNome.AutoSize = true;
            this.lblConsSupNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsSupNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsSupNome.ForeColor = System.Drawing.Color.White;
            this.lblConsSupNome.Location = new System.Drawing.Point(385, 110);
            this.lblConsSupNome.Name = "lblConsSupNome";
            this.lblConsSupNome.Size = new System.Drawing.Size(109, 23);
            this.lblConsSupNome.TabIndex = 197;
            this.lblConsSupNome.Text = "Razão Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(383, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 196;
            this.label1.Text = "Consultar";
            // 
            // pnlSuppCNPJ
            // 
            this.pnlSuppCNPJ.BackColor = System.Drawing.Color.White;
            this.pnlSuppCNPJ.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSuppCNPJ.ForeColor = System.Drawing.Color.White;
            this.pnlSuppCNPJ.Location = new System.Drawing.Point(696, 153);
            this.pnlSuppCNPJ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuppCNPJ.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSuppCNPJ.Name = "pnlSuppCNPJ";
            this.pnlSuppCNPJ.Size = new System.Drawing.Size(206, 1);
            this.pnlSuppCNPJ.TabIndex = 202;
            // 
            // txtSuppSearchCNPJ
            // 
            this.txtSuppSearchCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtSuppSearchCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuppSearchCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppSearchCNPJ.ForeColor = System.Drawing.Color.White;
            this.txtSuppSearchCNPJ.Location = new System.Drawing.Point(700, 132);
            this.txtSuppSearchCNPJ.Margin = new System.Windows.Forms.Padding(0);
            this.txtSuppSearchCNPJ.MaxLength = 11;
            this.txtSuppSearchCNPJ.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSuppSearchCNPJ.Name = "txtSuppSearchCNPJ";
            this.txtSuppSearchCNPJ.Size = new System.Drawing.Size(191, 27);
            this.txtSuppSearchCNPJ.TabIndex = 203;
            this.txtSuppSearchCNPJ.TextChanged += new System.EventHandler(this.txtSuppSearchCNPJ_TextChanged);
            this.txtSuppSearchCNPJ.Enter += new System.EventHandler(this.txtSuppSearchCNPJ_Enter);
            this.txtSuppSearchCNPJ.Leave += new System.EventHandler(this.txtSuppSearchCNPJ_Leave);
            // 
            // pnlSuppName
            // 
            this.pnlSuppName.BackColor = System.Drawing.Color.White;
            this.pnlSuppName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSuppName.ForeColor = System.Drawing.Color.White;
            this.pnlSuppName.Location = new System.Drawing.Point(388, 153);
            this.pnlSuppName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSuppName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSuppName.Name = "pnlSuppName";
            this.pnlSuppName.Size = new System.Drawing.Size(270, 1);
            this.pnlSuppName.TabIndex = 200;
            // 
            // txtSuppSearchName
            // 
            this.txtSuppSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtSuppSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuppSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSuppSearchName.Location = new System.Drawing.Point(393, 132);
            this.txtSuppSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSuppSearchName.MaxLength = 11;
            this.txtSuppSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSuppSearchName.Name = "txtSuppSearchName";
            this.txtSuppSearchName.Size = new System.Drawing.Size(258, 27);
            this.txtSuppSearchName.TabIndex = 201;
            this.txtSuppSearchName.Click += new System.EventHandler(this.txtSuppSearchName_Click);
            this.txtSuppSearchName.TextChanged += new System.EventHandler(this.txtSuppSearchName_TextChanged);
            this.txtSuppSearchName.Enter += new System.EventHandler(this.txtSuppSearchName_Enter);
            this.txtSuppSearchName.Leave += new System.EventHandler(this.txtSuppSearchName_Leave);
            // 
            // btnSupplierSelect
            // 
            this.btnSupplierSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplierSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSupplierSelect.FlatAppearance.BorderSize = 0;
            this.btnSupplierSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSupplierSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierSelect.Image")));
            this.btnSupplierSelect.Location = new System.Drawing.Point(898, 558);
            this.btnSupplierSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierSelect.Name = "btnSupplierSelect";
            this.btnSupplierSelect.Size = new System.Drawing.Size(138, 47);
            this.btnSupplierSelect.TabIndex = 204;
            this.btnSupplierSelect.Text = "Selecionar";
            this.btnSupplierSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierSelect.UseVisualStyleBackColor = false;
            this.btnSupplierSelect.Click += new System.EventHandler(this.btnSupplierSelect_Click);
            // 
            // btnSupplierClear
            // 
            this.btnSupplierClear.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplierClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnSupplierClear.FlatAppearance.BorderSize = 0;
            this.btnSupplierClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSupplierClear.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierClear.Image")));
            this.btnSupplierClear.Location = new System.Drawing.Point(248, 348);
            this.btnSupplierClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierClear.Name = "btnSupplierClear";
            this.btnSupplierClear.Size = new System.Drawing.Size(98, 36);
            this.btnSupplierClear.TabIndex = 219;
            this.btnSupplierClear.Text = "Limpar";
            this.btnSupplierClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierClear.UseVisualStyleBackColor = false;
            this.btnSupplierClear.Click += new System.EventHandler(this.btnSupplierClear_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(310, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 217;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.White;
            this.lblCadID.Location = new System.Drawing.Point(282, 109);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(33, 23);
            this.lblCadID.TabIndex = 216;
            this.lblCadID.Text = "ID:";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSupplierRegister
            // 
            this.btnSupplierRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplierRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSupplierRegister.FlatAppearance.BorderSize = 0;
            this.btnSupplierRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSupplierRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplierRegister.Image")));
            this.btnSupplierRegister.Location = new System.Drawing.Point(102, 552);
            this.btnSupplierRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierRegister.Name = "btnSupplierRegister";
            this.btnSupplierRegister.Size = new System.Drawing.Size(189, 53);
            this.btnSupplierRegister.TabIndex = 218;
            this.btnSupplierRegister.Text = "Cadastrar";
            this.btnSupplierRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplierRegister.UseVisualStyleBackColor = false;
            this.btnSupplierRegister.Click += new System.EventHandler(this.btnSupplierRegister_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblCadastrar.Location = new System.Drawing.Point(37, 72);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(124, 32);
            this.lblCadastrar.TabIndex = 205;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblCadRazaoSocial
            // 
            this.lblCadRazaoSocial.AutoSize = true;
            this.lblCadRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblCadRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.lblCadRazaoSocial.Location = new System.Drawing.Point(39, 110);
            this.lblCadRazaoSocial.Name = "lblCadRazaoSocial";
            this.lblCadRazaoSocial.Size = new System.Drawing.Size(109, 23);
            this.lblCadRazaoSocial.TabIndex = 206;
            this.lblCadRazaoSocial.Text = "Razão Social";
            // 
            // txtSupplierRazaoSocial
            // 
            this.txtSupplierRazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtSupplierRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierRazaoSocial.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierRazaoSocial.Location = new System.Drawing.Point(43, 132);
            this.txtSupplierRazaoSocial.Margin = new System.Windows.Forms.Padding(0);
            this.txtSupplierRazaoSocial.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSupplierRazaoSocial.Name = "txtSupplierRazaoSocial";
            this.txtSupplierRazaoSocial.Size = new System.Drawing.Size(300, 27);
            this.txtSupplierRazaoSocial.TabIndex = 207;
            // 
            // lblCadCnpj
            // 
            this.lblCadCnpj.AutoSize = true;
            this.lblCadCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCnpj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCadCnpj.Location = new System.Drawing.Point(39, 166);
            this.lblCadCnpj.Name = "lblCadCnpj";
            this.lblCadCnpj.Size = new System.Drawing.Size(51, 23);
            this.lblCadCnpj.TabIndex = 208;
            this.lblCadCnpj.Text = "CNPJ";
            // 
            // lblCadTel
            // 
            this.lblCadTel.AutoSize = true;
            this.lblCadTel.BackColor = System.Drawing.Color.Transparent;
            this.lblCadTel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadTel.ForeColor = System.Drawing.Color.White;
            this.lblCadTel.Location = new System.Drawing.Point(203, 166);
            this.lblCadTel.Name = "lblCadTel";
            this.lblCadTel.Size = new System.Drawing.Size(77, 23);
            this.lblCadTel.TabIndex = 210;
            this.lblCadTel.Text = "Telefone";
            // 
            // txtSupplierTel
            // 
            this.txtSupplierTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtSupplierTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierTel.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierTel.Location = new System.Drawing.Point(208, 188);
            this.txtSupplierTel.Margin = new System.Windows.Forms.Padding(0);
            this.txtSupplierTel.MaxLength = 11;
            this.txtSupplierTel.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSupplierTel.Name = "txtSupplierTel";
            this.txtSupplierTel.Size = new System.Drawing.Size(135, 27);
            this.txtSupplierTel.TabIndex = 211;
            // 
            // lblCadNomeContato
            // 
            this.lblCadNomeContato.AutoSize = true;
            this.lblCadNomeContato.BackColor = System.Drawing.Color.Transparent;
            this.lblCadNomeContato.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadNomeContato.ForeColor = System.Drawing.Color.White;
            this.lblCadNomeContato.Location = new System.Drawing.Point(39, 222);
            this.lblCadNomeContato.Name = "lblCadNomeContato";
            this.lblCadNomeContato.Size = new System.Drawing.Size(168, 23);
            this.lblCadNomeContato.TabIndex = 212;
            this.lblCadNomeContato.Text = "Nome para Contato";
            // 
            // txtSupplierNomeContato
            // 
            this.txtSupplierNomeContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtSupplierNomeContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierNomeContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierNomeContato.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierNomeContato.Location = new System.Drawing.Point(43, 245);
            this.txtSupplierNomeContato.Margin = new System.Windows.Forms.Padding(0);
            this.txtSupplierNomeContato.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSupplierNomeContato.Name = "txtSupplierNomeContato";
            this.txtSupplierNomeContato.Size = new System.Drawing.Size(300, 27);
            this.txtSupplierNomeContato.TabIndex = 213;
            // 
            // lblCadEmail
            // 
            this.lblCadEmail.AutoSize = true;
            this.lblCadEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadEmail.ForeColor = System.Drawing.Color.White;
            this.lblCadEmail.Location = new System.Drawing.Point(39, 278);
            this.lblCadEmail.Name = "lblCadEmail";
            this.lblCadEmail.Size = new System.Drawing.Size(61, 23);
            this.lblCadEmail.TabIndex = 214;
            this.lblCadEmail.Text = "E-mail";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.txtSupplierEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierEmail.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierEmail.Location = new System.Drawing.Point(43, 301);
            this.txtSupplierEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtSupplierEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(300, 27);
            this.txtSupplierEmail.TabIndex = 215;
            // 
            // txtSupplierCnpj
            // 
            this.txtSupplierCnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtSupplierCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierCnpj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierCnpj.Location = new System.Drawing.Point(43, 188);
            this.txtSupplierCnpj.Mask = "00,000,000/0000-00";
            this.txtSupplierCnpj.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSupplierCnpj.Name = "txtSupplierCnpj";
            this.txtSupplierCnpj.Size = new System.Drawing.Size(151, 27);
            this.txtSupplierCnpj.TabIndex = 209;
            // 
            // lblDot1
            // 
            this.lblDot1.AutoSize = true;
            this.lblDot1.BackColor = System.Drawing.Color.Transparent;
            this.lblDot1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDot1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblDot1.Location = new System.Drawing.Point(18, 27);
            this.lblDot1.MinimumSize = new System.Drawing.Size(5, 10);
            this.lblDot1.Name = "lblDot1";
            this.lblDot1.Size = new System.Drawing.Size(26, 35);
            this.lblDot1.TabIndex = 230;
            this.lblDot1.Text = "•";
            this.lblDot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 35);
            this.label3.TabIndex = 229;
            this.label3.Text = "Fornecedores";
            // 
            // FormRegisterSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1141, 650);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSupplierClear);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.btnSupplierRegister);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblCadRazaoSocial);
            this.Controls.Add(this.txtSupplierRazaoSocial);
            this.Controls.Add(this.lblCadCnpj);
            this.Controls.Add(this.lblCadTel);
            this.Controls.Add(this.txtSupplierTel);
            this.Controls.Add(this.lblCadNomeContato);
            this.Controls.Add(this.txtSupplierNomeContato);
            this.Controls.Add(this.lblCadEmail);
            this.Controls.Add(this.txtSupplierEmail);
            this.Controls.Add(this.txtSupplierCnpj);
            this.Controls.Add(this.btnSupplierSelect);
            this.Controls.Add(this.pnlSuppCNPJ);
            this.Controls.Add(this.txtSuppSearchCNPJ);
            this.Controls.Add(this.pnlSuppName);
            this.Controls.Add(this.txtSuppSearchName);
            this.Controls.Add(this.lblConsSupCod);
            this.Controls.Add(this.lblConsSupNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSupplierRefresh);
            this.Controls.Add(this.btnSupplierDelete);
            this.Controls.Add(this.lblConsFornCadastrados);
            this.Controls.Add(this.dgvSuppliers);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterSupplier";
            this.Load += new System.EventHandler(this.FormRegisterSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplierRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsFornCadastrados;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.PictureBox picSupplierRefresh;
        private System.Windows.Forms.Button btnSupplierDelete;
        private System.Windows.Forms.Label lblConsSupCod;
        private System.Windows.Forms.Label lblConsSupNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSuppCNPJ;
        private System.Windows.Forms.TextBox txtSuppSearchCNPJ;
        private System.Windows.Forms.Panel pnlSuppName;
        private System.Windows.Forms.TextBox txtSuppSearchName;
        private System.Windows.Forms.Button btnSupplierSelect;
        private System.Windows.Forms.Button btnSupplierClear;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Button btnSupplierRegister;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblCadRazaoSocial;
        private System.Windows.Forms.TextBox txtSupplierRazaoSocial;
        private System.Windows.Forms.Label lblCadCnpj;
        private System.Windows.Forms.Label lblCadTel;
        private System.Windows.Forms.TextBox txtSupplierTel;
        private System.Windows.Forms.Label lblCadNomeContato;
        private System.Windows.Forms.TextBox txtSupplierNomeContato;
        private System.Windows.Forms.Label lblCadEmail;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.MaskedTextBox txtSupplierCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Label label3;
    }
}