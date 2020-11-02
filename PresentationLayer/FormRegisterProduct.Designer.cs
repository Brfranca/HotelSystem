namespace PresentationLayer
{
    partial class FormRegisterProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCadID = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.RichTextBox();
            this.lblCadDescricaoProd = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picSupplierClose = new System.Windows.Forms.PictureBox();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductRegister = new System.Windows.Forms.Button();
            this.btnProductSelect = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.txtProdSearchID = new System.Windows.Forms.TextBox();
            this.txtProdSearchName = new System.Windows.Forms.TextBox();
            this.lblConsProdCod = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsFornCadastrados = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlProduName = new System.Windows.Forms.Panel();
            this.pnlProduID = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.picProductRefresh = new System.Windows.Forms.PictureBox();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplierClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadID.Location = new System.Drawing.Point(225, 96);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(27, 19);
            this.lblCadID.TabIndex = 107;
            this.lblCadID.Text = "ID:";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductDescription.ForeColor = System.Drawing.Color.Black;
            this.txtProductDescription.Location = new System.Drawing.Point(21, 245);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(292, 115);
            this.txtProductDescription.TabIndex = 109;
            this.txtProductDescription.Text = "";
            // 
            // lblCadDescricaoProd
            // 
            this.lblCadDescricaoProd.AutoSize = true;
            this.lblCadDescricaoProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadDescricaoProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadDescricaoProd.Location = new System.Drawing.Point(25, 210);
            this.lblCadDescricaoProd.Name = "lblCadDescricaoProd";
            this.lblCadDescricaoProd.Size = new System.Drawing.Size(155, 19);
            this.lblCadDescricaoProd.TabIndex = 108;
            this.lblCadDescricaoProd.Text = "Descrição do Produto";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadastrar.Location = new System.Drawing.Point(12, 58);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(97, 25);
            this.lblCadastrar.TabIndex = 104;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblProdName.Location = new System.Drawing.Point(13, 97);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(50, 19);
            this.lblProdName.TabIndex = 105;
            this.lblProdName.Text = "Nome";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlTopBar.Controls.Add(this.picSupplierClose);
            this.pnlTopBar.Controls.Add(this.picIcone);
            this.pnlTopBar.Controls.Add(this.lblNomeFarmacia);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(991, 40);
            this.pnlTopBar.TabIndex = 103;
            // 
            // picSupplierClose
            // 
            this.picSupplierClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSupplierClose.BackColor = System.Drawing.Color.Transparent;
            this.picSupplierClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSupplierClose.BackgroundImage")));
            this.picSupplierClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSupplierClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSupplierClose.Location = new System.Drawing.Point(953, 6);
            this.picSupplierClose.Margin = new System.Windows.Forms.Padding(0);
            this.picSupplierClose.Name = "picSupplierClose";
            this.picSupplierClose.Size = new System.Drawing.Size(29, 24);
            this.picSupplierClose.TabIndex = 172;
            this.picSupplierClose.TabStop = false;
            this.picSupplierClose.Click += new System.EventHandler(this.picSupplierClose_Click);
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 7);
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
            this.lblNomeFarmacia.Location = new System.Drawing.Point(34, 9);
            this.lblNomeFarmacia.Name = "lblNomeFarmacia";
            this.lblNomeFarmacia.Size = new System.Drawing.Size(141, 21);
            this.lblNomeFarmacia.TabIndex = 0;
            this.lblNomeFarmacia.Text = "Tabela de Produtos";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(21, 119);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(0);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(300, 24);
            this.txtProductName.TabIndex = 106;
            // 
            // btnProductRegister
            // 
            this.btnProductRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductRegister.FlatAppearance.BorderSize = 3;
            this.btnProductRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductRegister.ForeColor = System.Drawing.Color.White;
            this.btnProductRegister.Location = new System.Drawing.Point(63, 576);
            this.btnProductRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductRegister.Name = "btnProductRegister";
            this.btnProductRegister.Size = new System.Drawing.Size(189, 53);
            this.btnProductRegister.TabIndex = 205;
            this.btnProductRegister.Text = "Cadastrar";
            this.btnProductRegister.UseVisualStyleBackColor = false;
            this.btnProductRegister.Click += new System.EventHandler(this.btnProductRegister_Click);
            // 
            // btnProductSelect
            // 
            this.btnProductSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductSelect.FlatAppearance.BorderSize = 3;
            this.btnProductSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSelect.ForeColor = System.Drawing.Color.White;
            this.btnProductSelect.Location = new System.Drawing.Point(767, 607);
            this.btnProductSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductSelect.Name = "btnProductSelect";
            this.btnProductSelect.Size = new System.Drawing.Size(138, 47);
            this.btnProductSelect.TabIndex = 208;
            this.btnProductSelect.Text = "Selecionar";
            this.btnProductSelect.UseVisualStyleBackColor = false;
            this.btnProductSelect.Click += new System.EventHandler(this.btnProductSelect_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductDelete.FlatAppearance.BorderSize = 3;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Location = new System.Drawing.Point(608, 607);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(138, 47);
            this.btnProductDelete.TabIndex = 206;
            this.btnProductDelete.Text = "Excluir";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // txtProdSearchID
            // 
            this.txtProdSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtProdSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdSearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSearchID.ForeColor = System.Drawing.Color.Black;
            this.txtProdSearchID.Location = new System.Drawing.Point(741, 144);
            this.txtProdSearchID.Margin = new System.Windows.Forms.Padding(0);
            this.txtProdSearchID.MaxLength = 11;
            this.txtProdSearchID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProdSearchID.Name = "txtProdSearchID";
            this.txtProdSearchID.Size = new System.Drawing.Size(103, 22);
            this.txtProdSearchID.TabIndex = 215;
            this.txtProdSearchID.Click += new System.EventHandler(this.txtProdSearchID_Click);
            this.txtProdSearchID.TextChanged += new System.EventHandler(this.txtProdSearchID_TextChanged);
            this.txtProdSearchID.Leave += new System.EventHandler(this.txtProdSearchID_Leave);
            // 
            // txtProdSearchName
            // 
            this.txtProdSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtProdSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtProdSearchName.Location = new System.Drawing.Point(402, 149);
            this.txtProdSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtProdSearchName.MaxLength = 11;
            this.txtProdSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtProdSearchName.Name = "txtProdSearchName";
            this.txtProdSearchName.Size = new System.Drawing.Size(258, 22);
            this.txtProdSearchName.TabIndex = 214;
            this.txtProdSearchName.Click += new System.EventHandler(this.txtProdSearchName_Click);
            this.txtProdSearchName.TextChanged += new System.EventHandler(this.txtProdSearchName_TextChanged);
            this.txtProdSearchName.Leave += new System.EventHandler(this.txtProdSearchName_Leave);
            // 
            // lblConsProdCod
            // 
            this.lblConsProdCod.AutoSize = true;
            this.lblConsProdCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsProdCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsProdCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsProdCod.Location = new System.Drawing.Point(705, 118);
            this.lblConsProdCod.Name = "lblConsProdCod";
            this.lblConsProdCod.Size = new System.Drawing.Size(23, 19);
            this.lblConsProdCod.TabIndex = 213;
            this.lblConsProdCod.Text = "ID";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblSearchName.Location = new System.Drawing.Point(398, 119);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(50, 19);
            this.lblSearchName.TabIndex = 212;
            this.lblSearchName.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(396, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 211;
            this.label2.Text = "Consultar";
            // 
            // lblConsFornCadastrados
            // 
            this.lblConsFornCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConsFornCadastrados.AutoSize = true;
            this.lblConsFornCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsFornCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsFornCadastrados.Location = new System.Drawing.Point(386, 199);
            this.lblConsFornCadastrados.Name = "lblConsFornCadastrados";
            this.lblConsFornCadastrados.Size = new System.Drawing.Size(155, 19);
            this.lblConsFornCadastrados.TabIndex = 216;
            this.lblConsFornCadastrados.Text = "Produtos cadastrados";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnPhone,
            this.ColumnEmail,
            this.ColumnPrice});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProducts.Location = new System.Drawing.Point(359, 221);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(605, 363);
            this.dgvProducts.TabIndex = 217;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // pnlProduName
            // 
            this.pnlProduName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlProduName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlProduName.Location = new System.Drawing.Point(390, 167);
            this.pnlProduName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlProduName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlProduName.Name = "pnlProduName";
            this.pnlProduName.Size = new System.Drawing.Size(270, 1);
            this.pnlProduName.TabIndex = 218;
            // 
            // pnlProduID
            // 
            this.pnlProduID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlProduID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlProduID.Location = new System.Drawing.Point(729, 167);
            this.pnlProduID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlProduID.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlProduID.Name = "pnlProduID";
            this.pnlProduID.Size = new System.Drawing.Size(149, 1);
            this.pnlProduID.TabIndex = 219;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblID.Location = new System.Drawing.Point(260, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 220;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picProductRefresh
            // 
            this.picProductRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProductRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picProductRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProductRefresh.BackgroundImage")));
            this.picProductRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProductRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picProductRefresh.Location = new System.Drawing.Point(922, 614);
            this.picProductRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picProductRefresh.Name = "picProductRefresh";
            this.picProductRefresh.Size = new System.Drawing.Size(42, 38);
            this.picProductRefresh.TabIndex = 221;
            this.picProductRefresh.TabStop = false;
            this.picProductRefresh.Click += new System.EventHandler(this.picProductRefresh_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.Color.Transparent;
            this.btnProductClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductClear.FlatAppearance.BorderSize = 3;
            this.btnProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnProductClear.Location = new System.Drawing.Point(223, 381);
            this.btnProductClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(98, 36);
            this.btnProductClear.TabIndex = 222;
            this.btnProductClear.Text = "Limpar";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 30F;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Nome";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Descrição";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.FillWeight = 40F;
            this.ColumnPrice.HeaderText = "Preço (R$)";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // FormRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 667);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.picProductRefresh);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pnlProduID);
            this.Controls.Add(this.pnlProduName);
            this.Controls.Add(this.lblConsFornCadastrados);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProdSearchID);
            this.Controls.Add(this.txtProdSearchName);
            this.Controls.Add(this.lblConsProdCod);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProductRegister);
            this.Controls.Add(this.btnProductSelect);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.lblCadDescricaoProd);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.txtProductName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterProduct";
            this.Text = "FormRegisterProduct";
            this.Load += new System.EventHandler(this.FormRegisterProduct_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSupplierClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.Label lblCadDescricaoProd;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Button btnProductRegister;
        private System.Windows.Forms.Button btnProductSelect;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.PictureBox picSupplierClose;
        private System.Windows.Forms.TextBox txtProdSearchID;
        private System.Windows.Forms.TextBox txtProdSearchName;
        private System.Windows.Forms.Label lblConsProdCod;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsFornCadastrados;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlProduName;
        private System.Windows.Forms.Panel pnlProduID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox picProductRefresh;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
    }
}