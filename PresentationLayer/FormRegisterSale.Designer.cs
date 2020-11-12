namespace PresentationLayer
{
    partial class FormRegisterSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picSupplierClose = new System.Windows.Forms.PictureBox();
            this.pnlProduID = new System.Windows.Forms.Panel();
            this.pnlProduName = new System.Windows.Forms.Panel();
            this.lblConsFornCadastrados = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProdSearchID = new System.Windows.Forms.TextBox();
            this.txtProdSearchName = new System.Windows.Forms.TextBox();
            this.lblConsProdCod = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCadCliCpf = new System.Windows.Forms.Label();
            this.btnClientRegister = new System.Windows.Forms.Button();
            this.btnClientNew = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblCadCliNome = new System.Windows.Forms.Label();
            this.txtClientRG = new System.Windows.Forms.TextBox();
            this.lblCadCliRg = new System.Windows.Forms.Label();
            this.btnSearchCliente = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoomFloor = new System.Windows.Forms.TextBox();
            this.lblRoomFloor = new System.Windows.Forms.Label();
            this.dgvIncomeItems = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEntradaProdQtd = new System.Windows.Forms.Panel();
            this.txtProdQuantity = new System.Windows.Forms.TextBox();
            this.lblEntradaProdQtd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplierClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeItems)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 8);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(32, 25);
            this.picIcone.TabIndex = 171;
            this.picIcone.TabStop = false;
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeTabela.ForeColor = System.Drawing.Color.White;
            this.lblNomeTabela.Location = new System.Drawing.Point(34, 10);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(74, 28);
            this.lblNomeTabela.TabIndex = 0;
            this.lblNomeTabela.Text = "Vendas";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(77)))));
            this.pnlTopBar.Controls.Add(this.picSupplierClose);
            this.pnlTopBar.Controls.Add(this.picIcone);
            this.pnlTopBar.Controls.Add(this.lblNomeTabela);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1271, 40);
            this.pnlTopBar.TabIndex = 105;
            // 
            // picSupplierClose
            // 
            this.picSupplierClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSupplierClose.BackColor = System.Drawing.Color.Transparent;
            this.picSupplierClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSupplierClose.BackgroundImage")));
            this.picSupplierClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSupplierClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSupplierClose.Location = new System.Drawing.Point(1233, 8);
            this.picSupplierClose.Margin = new System.Windows.Forms.Padding(0);
            this.picSupplierClose.Name = "picSupplierClose";
            this.picSupplierClose.Size = new System.Drawing.Size(29, 24);
            this.picSupplierClose.TabIndex = 172;
            this.picSupplierClose.TabStop = false;
            // 
            // pnlProduID
            // 
            this.pnlProduID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlProduID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlProduID.Location = new System.Drawing.Point(931, 163);
            this.pnlProduID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlProduID.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlProduID.Name = "pnlProduID";
            this.pnlProduID.Size = new System.Drawing.Size(149, 1);
            this.pnlProduID.TabIndex = 228;
            // 
            // pnlProduName
            // 
            this.pnlProduName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlProduName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlProduName.Location = new System.Drawing.Point(623, 163);
            this.pnlProduName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlProduName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlProduName.Name = "pnlProduName";
            this.pnlProduName.Size = new System.Drawing.Size(270, 1);
            this.pnlProduName.TabIndex = 227;
            // 
            // lblConsFornCadastrados
            // 
            this.lblConsFornCadastrados.AutoSize = true;
            this.lblConsFornCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsFornCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsFornCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsFornCadastrados.Location = new System.Drawing.Point(624, 205);
            this.lblConsFornCadastrados.Name = "lblConsFornCadastrados";
            this.lblConsFornCadastrados.Size = new System.Drawing.Size(182, 23);
            this.lblConsFornCadastrados.TabIndex = 225;
            this.lblConsFornCadastrados.Text = "Produtos cadastrados";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 29;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnPhone,
            this.ColumnEmail,
            this.ColumnPrice,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Location = new System.Drawing.Point(623, 247);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(611, 295);
            this.dgvProducts.TabIndex = 226;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 30F;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Nome";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Descrição";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.FillWeight = 40F;
            this.ColumnPrice.HeaderText = "Preço (R$)";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estoque";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtProdSearchID
            // 
            this.txtProdSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtProdSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdSearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSearchID.ForeColor = System.Drawing.Color.Black;
            this.txtProdSearchID.Location = new System.Drawing.Point(935, 142);
            this.txtProdSearchID.Margin = new System.Windows.Forms.Padding(0);
            this.txtProdSearchID.MaxLength = 11;
            this.txtProdSearchID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProdSearchID.Name = "txtProdSearchID";
            this.txtProdSearchID.Size = new System.Drawing.Size(103, 27);
            this.txtProdSearchID.TabIndex = 224;
            // 
            // txtProdSearchName
            // 
            this.txtProdSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtProdSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtProdSearchName.Location = new System.Drawing.Point(628, 142);
            this.txtProdSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtProdSearchName.MaxLength = 11;
            this.txtProdSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProdSearchName.Name = "txtProdSearchName";
            this.txtProdSearchName.Size = new System.Drawing.Size(258, 27);
            this.txtProdSearchName.TabIndex = 223;
            // 
            // lblConsProdCod
            // 
            this.lblConsProdCod.AutoSize = true;
            this.lblConsProdCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsProdCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsProdCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsProdCod.Location = new System.Drawing.Point(927, 119);
            this.lblConsProdCod.Name = "lblConsProdCod";
            this.lblConsProdCod.Size = new System.Drawing.Size(28, 23);
            this.lblConsProdCod.TabIndex = 222;
            this.lblConsProdCod.Text = "ID";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblSearchName.Location = new System.Drawing.Point(620, 120);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(154, 23);
            this.lblSearchName.TabIndex = 221;
            this.lblSearchName.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(618, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 220;
            this.label2.Text = "Produtos";
            // 
            // txtClientCPF
            // 
            this.txtClientCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtClientCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClientCPF.Location = new System.Drawing.Point(39, 152);
            this.txtClientCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientCPF.Mask = "000,000,000-00";
            this.txtClientCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientCPF.Name = "txtClientCPF";
            this.txtClientCPF.Size = new System.Drawing.Size(144, 27);
            this.txtClientCPF.TabIndex = 229;
            // 
            // lblCadCliCpf
            // 
            this.lblCadCliCpf.AutoSize = true;
            this.lblCadCliCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliCpf.Location = new System.Drawing.Point(35, 130);
            this.lblCadCliCpf.Name = "lblCadCliCpf";
            this.lblCadCliCpf.Size = new System.Drawing.Size(40, 23);
            this.lblCadCliCpf.TabIndex = 230;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // btnClientRegister
            // 
            this.btnClientRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnClientRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnClientRegister.FlatAppearance.BorderSize = 3;
            this.btnClientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientRegister.ForeColor = System.Drawing.Color.White;
            this.btnClientRegister.Location = new System.Drawing.Point(132, 656);
            this.btnClientRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientRegister.Name = "btnClientRegister";
            this.btnClientRegister.Size = new System.Drawing.Size(189, 53);
            this.btnClientRegister.TabIndex = 231;
            this.btnClientRegister.Text = "Efetuar a compra";
            this.btnClientRegister.UseVisualStyleBackColor = false;
            // 
            // btnClientNew
            // 
            this.btnClientNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnClientNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnClientNew.FlatAppearance.BorderSize = 3;
            this.btnClientNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientNew.ForeColor = System.Drawing.Color.White;
            this.btnClientNew.Location = new System.Drawing.Point(951, 656);
            this.btnClientNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientNew.Name = "btnClientNew";
            this.btnClientNew.Size = new System.Drawing.Size(196, 37);
            this.btnClientNew.TabIndex = 232;
            this.btnClientNew.Text = "Adicionar à compra";
            this.btnClientNew.UseVisualStyleBackColor = false;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadastrar.Location = new System.Drawing.Point(33, 82);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(94, 32);
            this.lblCadastrar.TabIndex = 233;
            this.lblCadastrar.Text = "Cliente";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.Black;
            this.txtClientName.Location = new System.Drawing.Point(39, 227);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientName.MaxLength = 100;
            this.txtClientName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(303, 27);
            this.txtClientName.TabIndex = 234;
            // 
            // lblCadCliNome
            // 
            this.lblCadCliNome.AutoSize = true;
            this.lblCadCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliNome.Location = new System.Drawing.Point(35, 205);
            this.lblCadCliNome.Name = "lblCadCliNome";
            this.lblCadCliNome.Size = new System.Drawing.Size(58, 23);
            this.lblCadCliNome.TabIndex = 235;
            this.lblCadCliNome.Text = "Nome";
            // 
            // txtClientRG
            // 
            this.txtClientRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtClientRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientRG.ForeColor = System.Drawing.Color.Black;
            this.txtClientRG.Location = new System.Drawing.Point(198, 152);
            this.txtClientRG.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientRG.MaxLength = 15;
            this.txtClientRG.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientRG.Name = "txtClientRG";
            this.txtClientRG.Size = new System.Drawing.Size(144, 27);
            this.txtClientRG.TabIndex = 236;
            // 
            // lblCadCliRg
            // 
            this.lblCadCliRg.AutoSize = true;
            this.lblCadCliRg.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliRg.Location = new System.Drawing.Point(193, 130);
            this.lblCadCliRg.Name = "lblCadCliRg";
            this.lblCadCliRg.Size = new System.Drawing.Size(33, 23);
            this.lblCadCliRg.TabIndex = 237;
            this.lblCadCliRg.Text = "RG";
            // 
            // btnSearchCliente
            // 
            this.btnSearchCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSearchCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSearchCliente.FlatAppearance.BorderSize = 3;
            this.btnSearchCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCliente.ForeColor = System.Drawing.Color.White;
            this.btnSearchCliente.Location = new System.Drawing.Point(292, 142);
            this.btnSearchCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchCliente.Name = "btnSearchCliente";
            this.btnSearchCliente.Size = new System.Drawing.Size(105, 37);
            this.btnSearchCliente.TabIndex = 238;
            this.btnSearchCliente.Text = "Pesquisar";
            this.btnSearchCliente.UseVisualStyleBackColor = false;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumber.Location = new System.Drawing.Point(39, 299);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomNumber.MaxLength = 100;
            this.txtRoomNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(144, 27);
            this.txtRoomNumber.TabIndex = 239;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblRoom.Location = new System.Drawing.Point(35, 277);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(134, 23);
            this.lblRoom.TabIndex = 240;
            this.lblRoom.Text = "Número quarto";
            // 
            // txtRoomFloor
            // 
            this.txtRoomFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtRoomFloor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomFloor.ForeColor = System.Drawing.Color.Black;
            this.txtRoomFloor.Location = new System.Drawing.Point(207, 299);
            this.txtRoomFloor.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomFloor.MaxLength = 100;
            this.txtRoomFloor.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomFloor.Name = "txtRoomFloor";
            this.txtRoomFloor.Size = new System.Drawing.Size(144, 27);
            this.txtRoomFloor.TabIndex = 241;
            // 
            // lblRoomFloor
            // 
            this.lblRoomFloor.AutoSize = true;
            this.lblRoomFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblRoomFloor.Location = new System.Drawing.Point(203, 277);
            this.lblRoomFloor.Name = "lblRoomFloor";
            this.lblRoomFloor.Size = new System.Drawing.Size(59, 23);
            this.lblRoomFloor.TabIndex = 242;
            this.lblRoomFloor.Text = "Andar";
            // 
            // dgvIncomeItems
            // 
            this.dgvIncomeItems.AllowUserToAddRows = false;
            this.dgvIncomeItems.AllowUserToDeleteRows = false;
            this.dgvIncomeItems.AllowUserToResizeColumns = false;
            this.dgvIncomeItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvIncomeItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIncomeItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncomeItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncomeItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvIncomeItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncomeItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIncomeItems.ColumnHeadersHeight = 29;
            this.dgvIncomeItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIncomeItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncomeItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIncomeItems.Location = new System.Drawing.Point(25, 392);
            this.dgvIncomeItems.Name = "dgvIncomeItems";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncomeItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIncomeItems.RowHeadersVisible = false;
            this.dgvIncomeItems.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvIncomeItems.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIncomeItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomeItems.Size = new System.Drawing.Size(537, 217);
            this.dgvIncomeItems.TabIndex = 265;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(21, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 23);
            this.label5.TabIndex = 264;
            this.label5.Text = "Produtos adicionados ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(568, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 663);
            this.panel1.TabIndex = 266;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 40F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Preço";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // pnlEntradaProdQtd
            // 
            this.pnlEntradaProdQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlEntradaProdQtd.Location = new System.Drawing.Point(620, 606);
            this.pnlEntradaProdQtd.MaximumSize = new System.Drawing.Size(500, 1);
            this.pnlEntradaProdQtd.Name = "pnlEntradaProdQtd";
            this.pnlEntradaProdQtd.Size = new System.Drawing.Size(116, 1);
            this.pnlEntradaProdQtd.TabIndex = 269;
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtProdQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtProdQuantity.Location = new System.Drawing.Point(624, 582);
            this.txtProdQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.txtProdQuantity.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(112, 27);
            this.txtProdQuantity.TabIndex = 268;
            this.txtProdQuantity.Text = "0";
            // 
            // lblEntradaProdQtd
            // 
            this.lblEntradaProdQtd.AutoSize = true;
            this.lblEntradaProdQtd.BackColor = System.Drawing.Color.Transparent;
            this.lblEntradaProdQtd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaProdQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblEntradaProdQtd.Location = new System.Drawing.Point(615, 558);
            this.lblEntradaProdQtd.Name = "lblEntradaProdQtd";
            this.lblEntradaProdQtd.Size = new System.Drawing.Size(104, 23);
            this.lblEntradaProdQtd.TabIndex = 267;
            this.lblEntradaProdQtd.Text = "Quantidade";
            // 
            // FormRegisterSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 722);
            this.Controls.Add(this.pnlEntradaProdQtd);
            this.Controls.Add(this.txtProdQuantity);
            this.Controls.Add(this.lblEntradaProdQtd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvIncomeItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomFloor);
            this.Controls.Add(this.lblRoomFloor);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.btnSearchCliente);
            this.Controls.Add(this.txtClientRG);
            this.Controls.Add(this.lblCadCliRg);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblCadCliNome);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.btnClientRegister);
            this.Controls.Add(this.btnClientNew);
            this.Controls.Add(this.txtClientCPF);
            this.Controls.Add(this.lblCadCliCpf);
            this.Controls.Add(this.pnlProduID);
            this.Controls.Add(this.pnlProduName);
            this.Controls.Add(this.lblConsFornCadastrados);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProdSearchID);
            this.Controls.Add(this.txtProdSearchName);
            this.Controls.Add(this.lblConsProdCod);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterSale";
            this.Text = "FormRegisterSale";
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplierClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomeItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblNomeTabela;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picSupplierClose;
        private System.Windows.Forms.Panel pnlProduID;
        private System.Windows.Forms.Panel pnlProduName;
        private System.Windows.Forms.Label lblConsFornCadastrados;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtProdSearchID;
        private System.Windows.Forms.TextBox txtProdSearchName;
        private System.Windows.Forms.Label lblConsProdCod;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtClientCPF;
        private System.Windows.Forms.Label lblCadCliCpf;
        private System.Windows.Forms.Button btnClientRegister;
        private System.Windows.Forms.Button btnClientNew;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblCadCliNome;
        private System.Windows.Forms.TextBox txtClientRG;
        private System.Windows.Forms.Label lblCadCliRg;
        private System.Windows.Forms.Button btnSearchCliente;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtRoomFloor;
        private System.Windows.Forms.Label lblRoomFloor;
        private System.Windows.Forms.DataGridView dgvIncomeItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEntradaProdQtd;
        private System.Windows.Forms.TextBox txtProdQuantity;
        private System.Windows.Forms.Label lblEntradaProdQtd;
    }
}