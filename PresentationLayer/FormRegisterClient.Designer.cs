namespace PresentationLayer
{
    partial class FormRegisterClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterClient));
            this.lblCadID = new System.Windows.Forms.Label();
            this.lblConsCliCod = new System.Windows.Forms.Label();
            this.btnClient_Search = new System.Windows.Forms.Button();
            this.lblConsCliNome = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblConsCliCadastrados = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtClientCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblCadCliEmail = new System.Windows.Forms.Label();
            this.txtClientPhone2 = new System.Windows.Forms.TextBox();
            this.lblCadCliTel2 = new System.Windows.Forms.Label();
            this.lblCadCliTel1 = new System.Windows.Forms.Label();
            this.txtClientRG = new System.Windows.Forms.TextBox();
            this.lblCadCliRg = new System.Windows.Forms.Label();
            this.lblCadCliCpf = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblCadCliNome = new System.Windows.Forms.Label();
            this.picBtnClose = new System.Windows.Forms.PictureBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnClient_New = new System.Windows.Forms.Button();
            this.btnClientRegister = new System.Windows.Forms.Button();
            this.btnClient_Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.pnlSearchName = new System.Windows.Forms.Panel();
            this.pnlSearchCPF = new System.Windows.Forms.Panel();
            this.txtSearchCPF = new System.Windows.Forms.TextBox();
            this.txtClientPhone1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadID.Location = new System.Drawing.Point(279, 84);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(33, 23);
            this.lblCadID.TabIndex = 141;
            this.lblCadID.Text = "ID:";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConsCliCod
            // 
            this.lblConsCliCod.AutoSize = true;
            this.lblConsCliCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliCod.Location = new System.Drawing.Point(677, 85);
            this.lblConsCliCod.Name = "lblConsCliCod";
            this.lblConsCliCod.Size = new System.Drawing.Size(40, 23);
            this.lblConsCliCod.TabIndex = 152;
            this.lblConsCliCod.Text = "CPF";
            // 
            // btnClient_Search
            // 
            this.btnClient_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnClient_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnClient_Search.FlatAppearance.BorderSize = 3;
            this.btnClient_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient_Search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient_Search.ForeColor = System.Drawing.Color.White;
            this.btnClient_Search.Location = new System.Drawing.Point(912, 91);
            this.btnClient_Search.Name = "btnClient_Search";
            this.btnClient_Search.Size = new System.Drawing.Size(127, 44);
            this.btnClient_Search.TabIndex = 154;
            this.btnClient_Search.Text = "Pesquisar";
            this.btnClient_Search.UseVisualStyleBackColor = false;
            // 
            // lblConsCliNome
            // 
            this.lblConsCliNome.AutoSize = true;
            this.lblConsCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliNome.Location = new System.Drawing.Point(399, 85);
            this.lblConsCliNome.Name = "lblConsCliNome";
            this.lblConsCliNome.Size = new System.Drawing.Size(145, 23);
            this.lblConsCliNome.TabIndex = 150;
            this.lblConsCliNome.Text = "Nome do Cliente";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsultar.Location = new System.Drawing.Point(397, 49);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(125, 32);
            this.lblConsultar.TabIndex = 149;
            this.lblConsultar.Text = "Consultar";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadastrar.Location = new System.Drawing.Point(29, 49);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(124, 32);
            this.lblCadastrar.TabIndex = 131;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblConsCliCadastrados
            // 
            this.lblConsCliCadastrados.AutoSize = true;
            this.lblConsCliCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliCadastrados.Location = new System.Drawing.Point(399, 150);
            this.lblConsCliCadastrados.Name = "lblConsCliCadastrados";
            this.lblConsCliCadastrados.Size = new System.Drawing.Size(176, 23);
            this.lblConsCliCadastrados.TabIndex = 155;
            this.lblConsCliCadastrados.Text = "Clientes Cadastrados";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeight = 29;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.CPF,
            this.Phone1,
            this.Email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Location = new System.Drawing.Point(401, 172);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(713, 325);
            this.dgvClients.TabIndex = 156;
            // 
            // Name1
            // 
            this.Name1.FillWeight = 90F;
            this.Name1.HeaderText = "Nome";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.FillWeight = 68F;
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Phone1
            // 
            this.Phone1.FillWeight = 68F;
            this.Phone1.HeaderText = "Telefone";
            this.Phone1.MinimumWidth = 6;
            this.Phone1.Name = "Phone1";
            this.Phone1.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // txtClientCPF
            // 
            this.txtClientCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtClientCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClientCPF.Location = new System.Drawing.Point(35, 169);
            this.txtClientCPF.Mask = "000,000,000-00";
            this.txtClientCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientCPF.Name = "txtClientCPF";
            this.txtClientCPF.Size = new System.Drawing.Size(161, 27);
            this.txtClientCPF.TabIndex = 1;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.txtClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEmail.ForeColor = System.Drawing.Color.Black;
            this.txtClientEmail.Location = new System.Drawing.Point(35, 298);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(325, 27);
            this.txtClientEmail.TabIndex = 5;
            // 
            // lblCadCliEmail
            // 
            this.lblCadCliEmail.AutoSize = true;
            this.lblCadCliEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliEmail.Location = new System.Drawing.Point(31, 275);
            this.lblCadCliEmail.Name = "lblCadCliEmail";
            this.lblCadCliEmail.Size = new System.Drawing.Size(61, 23);
            this.lblCadCliEmail.TabIndex = 143;
            this.lblCadCliEmail.Text = "E-mail";
            // 
            // txtClientPhone2
            // 
            this.txtClientPhone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtClientPhone2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone2.ForeColor = System.Drawing.Color.Black;
            this.txtClientPhone2.Location = new System.Drawing.Point(209, 235);
            this.txtClientPhone2.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientPhone2.MaxLength = 11;
            this.txtClientPhone2.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientPhone2.Name = "txtClientPhone2";
            this.txtClientPhone2.Size = new System.Drawing.Size(151, 27);
            this.txtClientPhone2.TabIndex = 4;
            // 
            // lblCadCliTel2
            // 
            this.lblCadCliTel2.AutoSize = true;
            this.lblCadCliTel2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel2.Location = new System.Drawing.Point(201, 212);
            this.lblCadCliTel2.Name = "lblCadCliTel2";
            this.lblCadCliTel2.Size = new System.Drawing.Size(92, 23);
            this.lblCadCliTel2.TabIndex = 140;
            this.lblCadCliTel2.Text = "Telefone 2";
            // 
            // lblCadCliTel1
            // 
            this.lblCadCliTel1.AutoSize = true;
            this.lblCadCliTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel1.Location = new System.Drawing.Point(31, 212);
            this.lblCadCliTel1.Name = "lblCadCliTel1";
            this.lblCadCliTel1.Size = new System.Drawing.Size(92, 23);
            this.lblCadCliTel1.TabIndex = 138;
            this.lblCadCliTel1.Text = "Telefone 1";
            // 
            // txtClientRG
            // 
            this.txtClientRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtClientRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientRG.ForeColor = System.Drawing.Color.Black;
            this.txtClientRG.Location = new System.Drawing.Point(209, 167);
            this.txtClientRG.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientRG.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientRG.Name = "txtClientRG";
            this.txtClientRG.Size = new System.Drawing.Size(151, 27);
            this.txtClientRG.TabIndex = 2;
            // 
            // lblCadCliRg
            // 
            this.lblCadCliRg.AutoSize = true;
            this.lblCadCliRg.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliRg.Location = new System.Drawing.Point(201, 145);
            this.lblCadCliRg.Name = "lblCadCliRg";
            this.lblCadCliRg.Size = new System.Drawing.Size(33, 23);
            this.lblCadCliRg.TabIndex = 136;
            this.lblCadCliRg.Text = "RG";
            // 
            // lblCadCliCpf
            // 
            this.lblCadCliCpf.AutoSize = true;
            this.lblCadCliCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliCpf.Location = new System.Drawing.Point(31, 145);
            this.lblCadCliCpf.Name = "lblCadCliCpf";
            this.lblCadCliCpf.Size = new System.Drawing.Size(40, 23);
            this.lblCadCliCpf.TabIndex = 134;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.Black;
            this.txtClientName.Location = new System.Drawing.Point(35, 108);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(325, 27);
            this.txtClientName.TabIndex = 0;
            // 
            // lblCadCliNome
            // 
            this.lblCadCliNome.AutoSize = true;
            this.lblCadCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliNome.Location = new System.Drawing.Point(31, 85);
            this.lblCadCliNome.Name = "lblCadCliNome";
            this.lblCadCliNome.Size = new System.Drawing.Size(58, 23);
            this.lblCadCliNome.TabIndex = 132;
            this.lblCadCliNome.Text = "Nome";
            // 
            // picBtnClose
            // 
            this.picBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.picBtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBtnClose.BackgroundImage")));
            this.picBtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBtnClose.Location = new System.Drawing.Point(1119, 7);
            this.picBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.picBtnClose.Name = "picBtnClose";
            this.picBtnClose.Size = new System.Drawing.Size(25, 26);
            this.picBtnClose.TabIndex = 7;
            this.picBtnClose.TabStop = false;
            this.picBtnClose.Click += new System.EventHandler(this.picBtnClose_Click);
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeTabela.ForeColor = System.Drawing.Color.White;
            this.lblNomeTabela.Location = new System.Drawing.Point(33, 9);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(167, 28);
            this.lblNomeTabela.TabIndex = 0;
            this.lblNomeTabela.Text = "Tabela de Clientes";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(77)))));
            this.pnlTopBar.Controls.Add(this.lblNomeTabela);
            this.pnlTopBar.Controls.Add(this.picBtnClose);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1153, 40);
            this.pnlTopBar.TabIndex = 130;
            // 
            // btnClient_New
            // 
            this.btnClient_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient_New.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_New.FlatAppearance.BorderSize = 3;
            this.btnClient_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient_New.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient_New.ForeColor = System.Drawing.Color.White;
            this.btnClient_New.Location = new System.Drawing.Point(912, 519);
            this.btnClient_New.Name = "btnClient_New";
            this.btnClient_New.Size = new System.Drawing.Size(137, 47);
            this.btnClient_New.TabIndex = 158;
            this.btnClient_New.Text = "Selecionar";
            this.btnClient_New.UseVisualStyleBackColor = false;
            // 
            // btnClientRegister
            // 
            this.btnClientRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientRegister.FlatAppearance.BorderSize = 3;
            this.btnClientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientRegister.ForeColor = System.Drawing.Color.White;
            this.btnClientRegister.Location = new System.Drawing.Point(112, 516);
            this.btnClientRegister.Name = "btnClientRegister";
            this.btnClientRegister.Size = new System.Drawing.Size(189, 53);
            this.btnClientRegister.TabIndex = 6;
            this.btnClientRegister.Text = "Cadastrar";
            this.btnClientRegister.UseVisualStyleBackColor = false;
            // 
            // btnClient_Delete
            // 
            this.btnClient_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Delete.FlatAppearance.BorderSize = 3;
            this.btnClient_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient_Delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient_Delete.ForeColor = System.Drawing.Color.White;
            this.btnClient_Delete.Location = new System.Drawing.Point(757, 519);
            this.btnClient_Delete.Name = "btnClient_Delete";
            this.btnClient_Delete.Size = new System.Drawing.Size(137, 47);
            this.btnClient_Delete.TabIndex = 161;
            this.btnClient_Delete.Text = "Excluir";
            this.btnClient_Delete.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1061, 524);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.TabIndex = 163;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.button1.Location = new System.Drawing.Point(251, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchName.Location = new System.Drawing.Point(411, 108);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchName.MaxLength = 11;
            this.txtSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(229, 27);
            this.txtSearchName.TabIndex = 166;
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            // 
            // pnlSearchName
            // 
            this.pnlSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlSearchName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSearchName.Location = new System.Drawing.Point(401, 138);
            this.pnlSearchName.MaximumSize = new System.Drawing.Size(501, 1);
            this.pnlSearchName.Name = "pnlSearchName";
            this.pnlSearchName.Size = new System.Drawing.Size(248, 1);
            this.pnlSearchName.TabIndex = 166;
            // 
            // pnlSearchCPF
            // 
            this.pnlSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlSearchCPF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSearchCPF.Location = new System.Drawing.Point(680, 138);
            this.pnlSearchCPF.MaximumSize = new System.Drawing.Size(501, 1);
            this.pnlSearchCPF.Name = "pnlSearchCPF";
            this.pnlSearchCPF.Size = new System.Drawing.Size(189, 1);
            this.pnlSearchCPF.TabIndex = 167;
            // 
            // txtSearchCPF
            // 
            this.txtSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtSearchCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCPF.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCPF.Location = new System.Drawing.Point(689, 108);
            this.txtSearchCPF.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchCPF.MaxLength = 11;
            this.txtSearchCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtSearchCPF.Name = "txtSearchCPF";
            this.txtSearchCPF.Size = new System.Drawing.Size(167, 27);
            this.txtSearchCPF.TabIndex = 168;
            // 
            // txtClientPhone1
            // 
            this.txtClientPhone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtClientPhone1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone1.ForeColor = System.Drawing.Color.Black;
            this.txtClientPhone1.Location = new System.Drawing.Point(35, 235);
            this.txtClientPhone1.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientPhone1.MaxLength = 11;
            this.txtClientPhone1.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientPhone1.Name = "txtClientPhone1";
            this.txtClientPhone1.Size = new System.Drawing.Size(161, 27);
            this.txtClientPhone1.TabIndex = 3;
            // 
            // FormRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1153, 593);
            this.Controls.Add(this.pnlSearchCPF);
            this.Controls.Add(this.txtSearchCPF);
            this.Controls.Add(this.pnlSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClient_Delete);
            this.Controls.Add(this.btnClientRegister);
            this.Controls.Add(this.btnClient_New);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.lblConsCliCod);
            this.Controls.Add(this.btnClient_Search);
            this.Controls.Add(this.lblConsCliNome);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblConsCliCadastrados);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.txtClientCPF);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.lblCadCliEmail);
            this.Controls.Add(this.txtClientPhone2);
            this.Controls.Add(this.lblCadCliTel2);
            this.Controls.Add(this.txtClientPhone1);
            this.Controls.Add(this.lblCadCliTel1);
            this.Controls.Add(this.txtClientRG);
            this.Controls.Add(this.lblCadCliRg);
            this.Controls.Add(this.lblCadCliCpf);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblCadCliNome);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterClient";
            this.Load += new System.EventHandler(this.FormRegisterClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Label lblConsCliCod;
        private System.Windows.Forms.Button btnClient_Search;
        private System.Windows.Forms.Label lblConsCliNome;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblConsCliCadastrados;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.MaskedTextBox txtClientCPF;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblCadCliEmail;
        private System.Windows.Forms.TextBox txtClientPhone2;
        private System.Windows.Forms.Label lblCadCliTel2;
        private System.Windows.Forms.Label lblCadCliTel1;
        private System.Windows.Forms.TextBox txtClientRG;
        private System.Windows.Forms.Label lblCadCliRg;
        private System.Windows.Forms.Label lblCadCliCpf;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblCadCliNome;
        private System.Windows.Forms.PictureBox picBtnClose;
        private System.Windows.Forms.Label lblNomeTabela;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnClient_New;
        private System.Windows.Forms.Button btnClientRegister;
        private System.Windows.Forms.Button btnClient_Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Panel pnlSearchName;
        private System.Windows.Forms.Panel pnlSearchCPF;
        private System.Windows.Forms.TextBox txtSearchCPF;
        private System.Windows.Forms.TextBox txtClientPhone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}