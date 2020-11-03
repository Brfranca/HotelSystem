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
            this.picClientClose = new System.Windows.Forms.PictureBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this.pnlClientTopBar = new System.Windows.Forms.Panel();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.btnClientNew = new System.Windows.Forms.Button();
            this.btnClientRegister = new System.Windows.Forms.Button();
            this.btnClientDelete = new System.Windows.Forms.Button();
            this.btnClientClear = new System.Windows.Forms.Button();
            this.txtClientSearchName = new System.Windows.Forms.TextBox();
            this.pnlClientName = new System.Windows.Forms.Panel();
            this.pnlClientCPF = new System.Windows.Forms.Panel();
            this.txtClientSearchCPF = new System.Windows.Forms.TextBox();
            this.txtClientPhone1 = new System.Windows.Forms.TextBox();
            this.picClientRefresh = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientClose)).BeginInit();
            this.pnlClientTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadID.Location = new System.Drawing.Point(263, 97);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(27, 19);
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
            this.lblConsCliCod.Location = new System.Drawing.Point(673, 97);
            this.lblConsCliCod.Name = "lblConsCliCod";
            this.lblConsCliCod.Size = new System.Drawing.Size(34, 19);
            this.lblConsCliCod.TabIndex = 152;
            this.lblConsCliCod.Text = "CPF";
            // 
            // lblConsCliNome
            // 
            this.lblConsCliNome.AutoSize = true;
            this.lblConsCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliNome.Location = new System.Drawing.Point(366, 98);
            this.lblConsCliNome.Name = "lblConsCliNome";
            this.lblConsCliNome.Size = new System.Drawing.Size(122, 19);
            this.lblConsCliNome.TabIndex = 150;
            this.lblConsCliNome.Text = "Nome do Cliente";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsultar.Location = new System.Drawing.Point(364, 60);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(98, 25);
            this.lblConsultar.TabIndex = 149;
            this.lblConsultar.Text = "Consultar";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadastrar.Location = new System.Drawing.Point(18, 60);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(97, 25);
            this.lblCadastrar.TabIndex = 131;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblConsCliCadastrados
            // 
            this.lblConsCliCadastrados.AutoSize = true;
            this.lblConsCliCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliCadastrados.Location = new System.Drawing.Point(368, 155);
            this.lblConsCliCadastrados.Name = "lblConsCliCadastrados";
            this.lblConsCliCadastrados.Size = new System.Drawing.Size(148, 19);
            this.lblConsCliCadastrados.TabIndex = 155;
            this.lblConsCliCadastrados.Text = "Clientes Cadastrados";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Location = new System.Drawing.Point(370, 176);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.dgvClients.Size = new System.Drawing.Size(700, 344);
            this.dgvClients.TabIndex = 156;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellDoubleClick);
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
            this.txtClientCPF.Location = new System.Drawing.Point(24, 176);
            this.txtClientCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientCPF.Mask = "000,000,000-00";
            this.txtClientCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientCPF.Name = "txtClientCPF";
            this.txtClientCPF.Size = new System.Drawing.Size(144, 22);
            this.txtClientCPF.TabIndex = 1;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.txtClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEmail.ForeColor = System.Drawing.Color.Black;
            this.txtClientEmail.Location = new System.Drawing.Point(24, 289);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientEmail.MaxLength = 200;
            this.txtClientEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(303, 22);
            this.txtClientEmail.TabIndex = 5;
            // 
            // lblCadCliEmail
            // 
            this.lblCadCliEmail.AutoSize = true;
            this.lblCadCliEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliEmail.Location = new System.Drawing.Point(20, 266);
            this.lblCadCliEmail.Name = "lblCadCliEmail";
            this.lblCadCliEmail.Size = new System.Drawing.Size(51, 19);
            this.lblCadCliEmail.TabIndex = 143;
            this.lblCadCliEmail.Text = "E-mail";
            // 
            // txtClientPhone2
            // 
            this.txtClientPhone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtClientPhone2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone2.ForeColor = System.Drawing.Color.Black;
            this.txtClientPhone2.Location = new System.Drawing.Point(183, 233);
            this.txtClientPhone2.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientPhone2.MaxLength = 11;
            this.txtClientPhone2.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientPhone2.Name = "txtClientPhone2";
            this.txtClientPhone2.Size = new System.Drawing.Size(144, 22);
            this.txtClientPhone2.TabIndex = 4;
            // 
            // lblCadCliTel2
            // 
            this.lblCadCliTel2.AutoSize = true;
            this.lblCadCliTel2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel2.Location = new System.Drawing.Point(179, 210);
            this.lblCadCliTel2.Name = "lblCadCliTel2";
            this.lblCadCliTel2.Size = new System.Drawing.Size(78, 19);
            this.lblCadCliTel2.TabIndex = 140;
            this.lblCadCliTel2.Text = "Telefone 2";
            // 
            // lblCadCliTel1
            // 
            this.lblCadCliTel1.AutoSize = true;
            this.lblCadCliTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel1.Location = new System.Drawing.Point(20, 210);
            this.lblCadCliTel1.Name = "lblCadCliTel1";
            this.lblCadCliTel1.Size = new System.Drawing.Size(78, 19);
            this.lblCadCliTel1.TabIndex = 138;
            this.lblCadCliTel1.Text = "Telefone 1";
            // 
            // txtClientRG
            // 
            this.txtClientRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtClientRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientRG.ForeColor = System.Drawing.Color.Black;
            this.txtClientRG.Location = new System.Drawing.Point(183, 176);
            this.txtClientRG.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientRG.MaxLength = 15;
            this.txtClientRG.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientRG.Name = "txtClientRG";
            this.txtClientRG.Size = new System.Drawing.Size(144, 22);
            this.txtClientRG.TabIndex = 2;
            // 
            // lblCadCliRg
            // 
            this.lblCadCliRg.AutoSize = true;
            this.lblCadCliRg.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliRg.Location = new System.Drawing.Point(178, 154);
            this.lblCadCliRg.Name = "lblCadCliRg";
            this.lblCadCliRg.Size = new System.Drawing.Size(28, 19);
            this.lblCadCliRg.TabIndex = 136;
            this.lblCadCliRg.Text = "RG";
            // 
            // lblCadCliCpf
            // 
            this.lblCadCliCpf.AutoSize = true;
            this.lblCadCliCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliCpf.Location = new System.Drawing.Point(20, 154);
            this.lblCadCliCpf.Name = "lblCadCliCpf";
            this.lblCadCliCpf.Size = new System.Drawing.Size(34, 19);
            this.lblCadCliCpf.TabIndex = 134;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.Black;
            this.txtClientName.Location = new System.Drawing.Point(24, 120);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientName.MaxLength = 100;
            this.txtClientName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(303, 22);
            this.txtClientName.TabIndex = 0;
            // 
            // lblCadCliNome
            // 
            this.lblCadCliNome.AutoSize = true;
            this.lblCadCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliNome.Location = new System.Drawing.Point(20, 98);
            this.lblCadCliNome.Name = "lblCadCliNome";
            this.lblCadCliNome.Size = new System.Drawing.Size(50, 19);
            this.lblCadCliNome.TabIndex = 132;
            this.lblCadCliNome.Text = "Nome";
            // 
            // picClientClose
            // 
            this.picClientClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picClientClose.BackColor = System.Drawing.Color.Transparent;
            this.picClientClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClientClose.BackgroundImage")));
            this.picClientClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClientClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClientClose.Location = new System.Drawing.Point(1062, 8);
            this.picClientClose.Margin = new System.Windows.Forms.Padding(0);
            this.picClientClose.Name = "picClientClose";
            this.picClientClose.Size = new System.Drawing.Size(29, 24);
            this.picClientClose.TabIndex = 7;
            this.picClientClose.TabStop = false;
            this.picClientClose.Click += new System.EventHandler(this.picClientClose_Click);
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeTabela.ForeColor = System.Drawing.Color.White;
            this.lblNomeTabela.Location = new System.Drawing.Point(34, 10);
            this.lblNomeTabela.Name = "lblNomeTabela";
            this.lblNomeTabela.Size = new System.Drawing.Size(133, 21);
            this.lblNomeTabela.TabIndex = 0;
            this.lblNomeTabela.Text = "Tabela de Clientes";
            // 
            // pnlClientTopBar
            // 
            this.pnlClientTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(77)))));
            this.pnlClientTopBar.Controls.Add(this.picIcone);
            this.pnlClientTopBar.Controls.Add(this.lblNomeTabela);
            this.pnlClientTopBar.Controls.Add(this.picClientClose);
            this.pnlClientTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlClientTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlClientTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlClientTopBar.Name = "pnlClientTopBar";
            this.pnlClientTopBar.Size = new System.Drawing.Size(1100, 40);
            this.pnlClientTopBar.TabIndex = 130;
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 8);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(32, 25);
            this.picIcone.TabIndex = 169;
            this.picIcone.TabStop = false;
            // 
            // btnClientNew
            // 
            this.btnClientNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientNew.FlatAppearance.BorderSize = 3;
            this.btnClientNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientNew.ForeColor = System.Drawing.Color.White;
            this.btnClientNew.Location = new System.Drawing.Point(879, 546);
            this.btnClientNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientNew.Name = "btnClientNew";
            this.btnClientNew.Size = new System.Drawing.Size(138, 47);
            this.btnClientNew.TabIndex = 158;
            this.btnClientNew.Text = "Selecionar";
            this.btnClientNew.UseVisualStyleBackColor = false;
            this.btnClientNew.Click += new System.EventHandler(this.btnClientNew_Click);
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
            this.btnClientRegister.Location = new System.Drawing.Point(83, 540);
            this.btnClientRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientRegister.Name = "btnClientRegister";
            this.btnClientRegister.Size = new System.Drawing.Size(189, 53);
            this.btnClientRegister.TabIndex = 6;
            this.btnClientRegister.Text = "Cadastrar";
            this.btnClientRegister.UseVisualStyleBackColor = false;
            this.btnClientRegister.Click += new System.EventHandler(this.btnClientRegister_Click);
            // 
            // btnClientDelete
            // 
            this.btnClientDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientDelete.FlatAppearance.BorderSize = 3;
            this.btnClientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDelete.ForeColor = System.Drawing.Color.White;
            this.btnClientDelete.Location = new System.Drawing.Point(729, 546);
            this.btnClientDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientDelete.Name = "btnClientDelete";
            this.btnClientDelete.Size = new System.Drawing.Size(138, 47);
            this.btnClientDelete.TabIndex = 161;
            this.btnClientDelete.Text = "Excluir";
            this.btnClientDelete.UseVisualStyleBackColor = false;
            this.btnClientDelete.Click += new System.EventHandler(this.btnClientDelete_Click);
            // 
            // btnClientClear
            // 
            this.btnClientClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClientClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientClear.FlatAppearance.BorderSize = 3;
            this.btnClientClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientClear.Location = new System.Drawing.Point(229, 336);
            this.btnClientClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientClear.Name = "btnClientClear";
            this.btnClientClear.Size = new System.Drawing.Size(98, 36);
            this.btnClientClear.TabIndex = 7;
            this.btnClientClear.Text = "Limpar";
            this.btnClientClear.UseVisualStyleBackColor = false;
            this.btnClientClear.Click += new System.EventHandler(this.btnClientClear_Click);
            // 
            // txtClientSearchName
            // 
            this.txtClientSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtClientSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtClientSearchName.Location = new System.Drawing.Point(374, 120);
            this.txtClientSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientSearchName.MaxLength = 11;
            this.txtClientSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientSearchName.Name = "txtClientSearchName";
            this.txtClientSearchName.Size = new System.Drawing.Size(258, 22);
            this.txtClientSearchName.TabIndex = 166;
            this.txtClientSearchName.Click += new System.EventHandler(this.txtClientSearchName_Click);
            this.txtClientSearchName.TextChanged += new System.EventHandler(this.txtClientSearchName_TextChanged);
            this.txtClientSearchName.Leave += new System.EventHandler(this.txtClientSearchName_Leave);
            // 
            // pnlClientName
            // 
            this.pnlClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlClientName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlClientName.Location = new System.Drawing.Point(369, 141);
            this.pnlClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlClientName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlClientName.Name = "pnlClientName";
            this.pnlClientName.Size = new System.Drawing.Size(270, 1);
            this.pnlClientName.TabIndex = 166;
            // 
            // pnlClientCPF
            // 
            this.pnlClientCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlClientCPF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlClientCPF.Location = new System.Drawing.Point(677, 141);
            this.pnlClientCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlClientCPF.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlClientCPF.Name = "pnlClientCPF";
            this.pnlClientCPF.Size = new System.Drawing.Size(206, 1);
            this.pnlClientCPF.TabIndex = 167;
            // 
            // txtClientSearchCPF
            // 
            this.txtClientSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtClientSearchCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientSearchCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearchCPF.ForeColor = System.Drawing.Color.Black;
            this.txtClientSearchCPF.Location = new System.Drawing.Point(681, 120);
            this.txtClientSearchCPF.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientSearchCPF.MaxLength = 11;
            this.txtClientSearchCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientSearchCPF.Name = "txtClientSearchCPF";
            this.txtClientSearchCPF.Size = new System.Drawing.Size(191, 22);
            this.txtClientSearchCPF.TabIndex = 168;
            this.txtClientSearchCPF.Click += new System.EventHandler(this.txtClientSearchCPF_Click);
            this.txtClientSearchCPF.TextChanged += new System.EventHandler(this.txtClientSearchCPF_TextChanged);
            this.txtClientSearchCPF.Leave += new System.EventHandler(this.txtClientSearchCPF_Leave);
            // 
            // txtClientPhone1
            // 
            this.txtClientPhone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtClientPhone1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone1.ForeColor = System.Drawing.Color.Black;
            this.txtClientPhone1.Location = new System.Drawing.Point(24, 233);
            this.txtClientPhone1.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientPhone1.MaxLength = 11;
            this.txtClientPhone1.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientPhone1.Name = "txtClientPhone1";
            this.txtClientPhone1.Size = new System.Drawing.Size(144, 22);
            this.txtClientPhone1.TabIndex = 3;
            // 
            // picClientRefresh
            // 
            this.picClientRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picClientRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picClientRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClientRefresh.BackgroundImage")));
            this.picClientRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picClientRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClientRefresh.Location = new System.Drawing.Point(1023, 550);
            this.picClientRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picClientRefresh.Name = "picClientRefresh";
            this.picClientRefresh.Size = new System.Drawing.Size(42, 38);
            this.picClientRefresh.TabIndex = 192;
            this.picClientRefresh.TabStop = false;
            this.picClientRefresh.Click += new System.EventHandler(this.picClientRefresh_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblID.Location = new System.Drawing.Point(289, 97);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 193;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 610);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.picClientRefresh);
            this.Controls.Add(this.pnlClientCPF);
            this.Controls.Add(this.txtClientSearchCPF);
            this.Controls.Add(this.pnlClientName);
            this.Controls.Add(this.txtClientSearchName);
            this.Controls.Add(this.btnClientClear);
            this.Controls.Add(this.btnClientDelete);
            this.Controls.Add(this.btnClientRegister);
            this.Controls.Add(this.btnClientNew);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.lblConsCliCod);
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
            this.Controls.Add(this.pnlClientTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterClient";
            this.Load += new System.EventHandler(this.FormRegisterClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientClose)).EndInit();
            this.pnlClientTopBar.ResumeLayout(false);
            this.pnlClientTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClientRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Label lblConsCliCod;
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
        private System.Windows.Forms.PictureBox picClientClose;
        private System.Windows.Forms.Label lblNomeTabela;
        private System.Windows.Forms.Panel pnlClientTopBar;
        private System.Windows.Forms.Button btnClientNew;
        private System.Windows.Forms.Button btnClientRegister;
        private System.Windows.Forms.Button btnClientDelete;
        private System.Windows.Forms.Button btnClientClear;
        private System.Windows.Forms.TextBox txtClientSearchName;
        private System.Windows.Forms.Panel pnlClientName;
        private System.Windows.Forms.Panel pnlClientCPF;
        private System.Windows.Forms.TextBox txtClientSearchCPF;
        private System.Windows.Forms.TextBox txtClientPhone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.PictureBox picClientRefresh;
        private System.Windows.Forms.Label lblID;
    }
}