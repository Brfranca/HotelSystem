namespace PresentationLayer
{
    partial class FormRegisterEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterEmployee));
            this.btnEmployeeRegister = new System.Windows.Forms.Button();
            this.lblCadID = new System.Windows.Forms.Label();
            this.lblConsCliCod = new System.Windows.Forms.Label();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.lblConsCliNome = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblConsCliCadastrados = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mktEmployeeCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblCadCliEmail = new System.Windows.Forms.Label();
            this.lblCadCliTel2 = new System.Windows.Forms.Label();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.lblCadCliTel1 = new System.Windows.Forms.Label();
            this.txtEmployeeRG = new System.Windows.Forms.TextBox();
            this.lblCadCliRg = new System.Windows.Forms.Label();
            this.lblCadCliCpf = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblCadCliNome = new System.Windows.Forms.Label();
            this.txtEmployeeStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCadPassFun2 = new System.Windows.Forms.Label();
            this.txtEmployeePassword2 = new System.Windows.Forms.TextBox();
            this.lblCadPassFun = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.mktEmployeeCEP = new System.Windows.Forms.MaskedTextBox();
            this.cboEmployeePosition = new System.Windows.Forms.ComboBox();
            this.txtEmployeeDistrict = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmployeeClear = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.btnEmployeeNew = new System.Windows.Forms.Button();
            this.picEmployeeRefresh = new System.Windows.Forms.PictureBox();
            this.chkEmployeeActive = new System.Windows.Forms.CheckBox();
            this.txtEmployeeSearchName = new System.Windows.Forms.TextBox();
            this.pnlEmployeeName = new System.Windows.Forms.Panel();
            this.picEmployeeClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.pnlEmployeeTopBar = new System.Windows.Forms.Panel();
            this.pnlEmployeeCPF = new System.Windows.Forms.Panel();
            this.txtEmployeeSearchCPF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.pnlEmployeeTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeRegister
            // 
            this.btnEmployeeRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeRegister.FlatAppearance.BorderSize = 3;
            this.btnEmployeeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRegister.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeRegister.Location = new System.Drawing.Point(83, 626);
            this.btnEmployeeRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeRegister.Name = "btnEmployeeRegister";
            this.btnEmployeeRegister.Size = new System.Drawing.Size(189, 53);
            this.btnEmployeeRegister.TabIndex = 14;
            this.btnEmployeeRegister.Text = "Cadastrar";
            this.btnEmployeeRegister.UseVisualStyleBackColor = false;
            this.btnEmployeeRegister.Click += new System.EventHandler(this.btnEmployeeRegister_Click);
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadID.Location = new System.Drawing.Point(275, 97);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(33, 23);
            this.lblCadID.TabIndex = 177;
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
            this.lblConsCliCod.Size = new System.Drawing.Size(40, 23);
            this.lblConsCliCod.TabIndex = 183;
            this.lblConsCliCod.Text = "CPF";
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnEmployeeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnEmployeeSearch.FlatAppearance.BorderSize = 3;
            this.btnEmployeeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSearch.Location = new System.Drawing.Point(942, 102);
            this.btnEmployeeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(127, 45);
            this.btnEmployeeSearch.TabIndex = 18;
            this.btnEmployeeSearch.Text = "Pesquisar";
            this.btnEmployeeSearch.UseVisualStyleBackColor = false;
            // 
            // lblConsCliNome
            // 
            this.lblConsCliNome.AutoSize = true;
            this.lblConsCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliNome.Location = new System.Drawing.Point(366, 98);
            this.lblConsCliNome.Name = "lblConsCliNome";
            this.lblConsCliNome.Size = new System.Drawing.Size(182, 23);
            this.lblConsCliNome.TabIndex = 182;
            this.lblConsCliNome.Text = "Nome do Funcionário";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsultar.Location = new System.Drawing.Point(364, 60);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(125, 32);
            this.lblConsultar.TabIndex = 181;
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
            this.lblCadastrar.Size = new System.Drawing.Size(124, 32);
            this.lblCadastrar.TabIndex = 167;
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
            this.lblConsCliCadastrados.Size = new System.Drawing.Size(213, 23);
            this.lblConsCliCadastrados.TabIndex = 186;
            this.lblConsCliCadastrados.Text = "Funcionários Cadastrados";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeight = 29;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployee.Location = new System.Drawing.Point(370, 176);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(755, 427);
            this.dgvEmployee.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 68F;
            this.Column2.HeaderText = "CPF";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 68F;
            this.Column3.HeaderText = "Telefone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "E-mail";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Função";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // mktEmployeeCPF
            // 
            this.mktEmployeeCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.mktEmployeeCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mktEmployeeCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mktEmployeeCPF.Location = new System.Drawing.Point(24, 176);
            this.mktEmployeeCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mktEmployeeCPF.Mask = "000,000,000-00";
            this.mktEmployeeCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.mktEmployeeCPF.Name = "mktEmployeeCPF";
            this.mktEmployeeCPF.Size = new System.Drawing.Size(144, 27);
            this.mktEmployeeCPF.TabIndex = 1;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtEmployeeEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeEmail.Location = new System.Drawing.Point(24, 289);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeEmail.MaxLength = 200;
            this.txtEmployeeEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(303, 27);
            this.txtEmployeeEmail.TabIndex = 5;
            // 
            // lblCadCliEmail
            // 
            this.lblCadCliEmail.AutoSize = true;
            this.lblCadCliEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliEmail.Location = new System.Drawing.Point(20, 266);
            this.lblCadCliEmail.Name = "lblCadCliEmail";
            this.lblCadCliEmail.Size = new System.Drawing.Size(61, 23);
            this.lblCadCliEmail.TabIndex = 179;
            this.lblCadCliEmail.Text = "E-mail";
            // 
            // lblCadCliTel2
            // 
            this.lblCadCliTel2.AutoSize = true;
            this.lblCadCliTel2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel2.Location = new System.Drawing.Point(20, 323);
            this.lblCadCliTel2.Name = "lblCadCliTel2";
            this.lblCadCliTel2.Size = new System.Drawing.Size(40, 23);
            this.lblCadCliTel2.TabIndex = 176;
            this.lblCadCliTel2.Text = "CEP";
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.txtEmployeePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePhone.Location = new System.Drawing.Point(24, 233);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeePhone.MaxLength = 11;
            this.txtEmployeePhone.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(144, 27);
            this.txtEmployeePhone.TabIndex = 3;
            // 
            // lblCadCliTel1
            // 
            this.lblCadCliTel1.AutoSize = true;
            this.lblCadCliTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel1.Location = new System.Drawing.Point(20, 210);
            this.lblCadCliTel1.Name = "lblCadCliTel1";
            this.lblCadCliTel1.Size = new System.Drawing.Size(77, 23);
            this.lblCadCliTel1.TabIndex = 174;
            this.lblCadCliTel1.Text = "Telefone";
            // 
            // txtEmployeeRG
            // 
            this.txtEmployeeRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtEmployeeRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeRG.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeRG.Location = new System.Drawing.Point(183, 176);
            this.txtEmployeeRG.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeRG.MaxLength = 15;
            this.txtEmployeeRG.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeRG.Name = "txtEmployeeRG";
            this.txtEmployeeRG.Size = new System.Drawing.Size(144, 27);
            this.txtEmployeeRG.TabIndex = 2;
            // 
            // lblCadCliRg
            // 
            this.lblCadCliRg.AutoSize = true;
            this.lblCadCliRg.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliRg.Location = new System.Drawing.Point(178, 154);
            this.lblCadCliRg.Name = "lblCadCliRg";
            this.lblCadCliRg.Size = new System.Drawing.Size(33, 23);
            this.lblCadCliRg.TabIndex = 172;
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
            this.lblCadCliCpf.Size = new System.Drawing.Size(40, 23);
            this.lblCadCliCpf.TabIndex = 170;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeName.Location = new System.Drawing.Point(24, 120);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeName.MaxLength = 100;
            this.txtEmployeeName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(303, 27);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // lblCadCliNome
            // 
            this.lblCadCliNome.AutoSize = true;
            this.lblCadCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliNome.Location = new System.Drawing.Point(20, 98);
            this.lblCadCliNome.Name = "lblCadCliNome";
            this.lblCadCliNome.Size = new System.Drawing.Size(58, 23);
            this.lblCadCliNome.TabIndex = 168;
            this.lblCadCliNome.Text = "Nome";
            // 
            // txtEmployeeStreet
            // 
            this.txtEmployeeStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtEmployeeStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeStreet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeStreet.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeStreet.Location = new System.Drawing.Point(24, 402);
            this.txtEmployeeStreet.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeStreet.MaxLength = 150;
            this.txtEmployeeStreet.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeStreet.Name = "txtEmployeeStreet";
            this.txtEmployeeStreet.Size = new System.Drawing.Size(303, 27);
            this.txtEmployeeStreet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(20, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 194;
            this.label1.Text = "Rua";
            // 
            // txtEmployeeCity
            // 
            this.txtEmployeeCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.txtEmployeeCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeCity.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeCity.Location = new System.Drawing.Point(157, 346);
            this.txtEmployeeCity.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeCity.MaxLength = 100;
            this.txtEmployeeCity.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeCity.Name = "txtEmployeeCity";
            this.txtEmployeeCity.Size = new System.Drawing.Size(170, 27);
            this.txtEmployeeCity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(152, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 196;
            this.label2.Text = "Cidade";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeNumber.Location = new System.Drawing.Point(24, 460);
            this.txtEmployeeNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeNumber.MaxLength = 7;
            this.txtEmployeeNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(62, 27);
            this.txtEmployeeNumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(20, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 198;
            this.label3.Text = "Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(179, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 200;
            this.label4.Text = "Função";
            // 
            // lblCadPassFun2
            // 
            this.lblCadPassFun2.AutoSize = true;
            this.lblCadPassFun2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPassFun2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPassFun2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadPassFun2.Location = new System.Drawing.Point(180, 495);
            this.lblCadPassFun2.Name = "lblCadPassFun2";
            this.lblCadPassFun2.Size = new System.Drawing.Size(122, 23);
            this.lblCadPassFun2.TabIndex = 204;
            this.lblCadPassFun2.Text = "Repetir Senha";
            // 
            // txtEmployeePassword2
            // 
            this.txtEmployeePassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.txtEmployeePassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword2.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePassword2.Location = new System.Drawing.Point(184, 518);
            this.txtEmployeePassword2.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeePassword2.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeePassword2.Name = "txtEmployeePassword2";
            this.txtEmployeePassword2.Size = new System.Drawing.Size(143, 27);
            this.txtEmployeePassword2.TabIndex = 12;
            this.txtEmployeePassword2.UseSystemPasswordChar = true;
            // 
            // lblCadPassFun
            // 
            this.lblCadPassFun.AutoSize = true;
            this.lblCadPassFun.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPassFun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPassFun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadPassFun.Location = new System.Drawing.Point(20, 495);
            this.lblCadPassFun.Name = "lblCadPassFun";
            this.lblCadPassFun.Size = new System.Drawing.Size(58, 23);
            this.lblCadPassFun.TabIndex = 202;
            this.lblCadPassFun.Text = "Senha";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.txtEmployeePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePassword.Location = new System.Drawing.Point(24, 518);
            this.txtEmployeePassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeePassword.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(145, 27);
            this.txtEmployeePassword.TabIndex = 11;
            this.txtEmployeePassword.UseSystemPasswordChar = true;
            // 
            // mktEmployeeCEP
            // 
            this.mktEmployeeCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.mktEmployeeCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mktEmployeeCEP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mktEmployeeCEP.Location = new System.Drawing.Point(24, 346);
            this.mktEmployeeCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mktEmployeeCEP.Mask = "00000-000";
            this.mktEmployeeCEP.Name = "mktEmployeeCEP";
            this.mktEmployeeCEP.Size = new System.Drawing.Size(118, 27);
            this.mktEmployeeCEP.TabIndex = 6;
            this.mktEmployeeCEP.Leave += new System.EventHandler(this.mktEmployeeCEP_Leave);
            // 
            // cboEmployeePosition
            // 
            this.cboEmployeePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.cboEmployeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeePosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEmployeePosition.FormattingEnabled = true;
            this.cboEmployeePosition.Location = new System.Drawing.Point(183, 232);
            this.cboEmployeePosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEmployeePosition.Name = "cboEmployeePosition";
            this.cboEmployeePosition.Size = new System.Drawing.Size(144, 31);
            this.cboEmployeePosition.TabIndex = 4;
            // 
            // txtEmployeeDistrict
            // 
            this.txtEmployeeDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtEmployeeDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeDistrict.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeDistrict.Location = new System.Drawing.Point(101, 460);
            this.txtEmployeeDistrict.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeDistrict.MaxLength = 150;
            this.txtEmployeeDistrict.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeDistrict.Name = "txtEmployeeDistrict";
            this.txtEmployeeDistrict.Size = new System.Drawing.Size(226, 27);
            this.txtEmployeeDistrict.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label6.Location = new System.Drawing.Point(98, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 213;
            this.label6.Text = "Bairro";
            // 
            // btnEmployeeClear
            // 
            this.btnEmployeeClear.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeClear.FlatAppearance.BorderSize = 3;
            this.btnEmployeeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeClear.Location = new System.Drawing.Point(229, 555);
            this.btnEmployeeClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeClear.Name = "btnEmployeeClear";
            this.btnEmployeeClear.Size = new System.Drawing.Size(98, 36);
            this.btnEmployeeClear.TabIndex = 15;
            this.btnEmployeeClear.Text = "Limpar";
            this.btnEmployeeClear.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeDelete.FlatAppearance.BorderSize = 3;
            this.btnEmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDelete.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeDelete.Location = new System.Drawing.Point(775, 628);
            this.btnEmployeeDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(138, 47);
            this.btnEmployeeDelete.TabIndex = 20;
            this.btnEmployeeDelete.Text = "Excluir";
            this.btnEmployeeDelete.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeNew
            // 
            this.btnEmployeeNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeNew.FlatAppearance.BorderSize = 3;
            this.btnEmployeeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeNew.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeNew.Location = new System.Drawing.Point(925, 628);
            this.btnEmployeeNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeNew.Name = "btnEmployeeNew";
            this.btnEmployeeNew.Size = new System.Drawing.Size(138, 47);
            this.btnEmployeeNew.TabIndex = 21;
            this.btnEmployeeNew.Text = "Selecionar";
            this.btnEmployeeNew.UseVisualStyleBackColor = false;
            // 
            // picEmployeeRefresh
            // 
            this.picEmployeeRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picEmployeeRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picEmployeeRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEmployeeRefresh.BackgroundImage")));
            this.picEmployeeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEmployeeRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmployeeRefresh.Location = new System.Drawing.Point(1078, 632);
            this.picEmployeeRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picEmployeeRefresh.Name = "picEmployeeRefresh";
            this.picEmployeeRefresh.Size = new System.Drawing.Size(42, 38);
            this.picEmployeeRefresh.TabIndex = 219;
            this.picEmployeeRefresh.TabStop = false;
            // 
            // chkEmployeeActive
            // 
            this.chkEmployeeActive.AutoSize = true;
            this.chkEmployeeActive.BackColor = System.Drawing.Color.Transparent;
            this.chkEmployeeActive.Checked = true;
            this.chkEmployeeActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmployeeActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployeeActive.Location = new System.Drawing.Point(24, 560);
            this.chkEmployeeActive.Name = "chkEmployeeActive";
            this.chkEmployeeActive.Size = new System.Drawing.Size(75, 27);
            this.chkEmployeeActive.TabIndex = 13;
            this.chkEmployeeActive.Text = "Ativo";
            this.chkEmployeeActive.UseVisualStyleBackColor = false;
            // 
            // txtEmployeeSearchName
            // 
            this.txtEmployeeSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtEmployeeSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeSearchName.Location = new System.Drawing.Point(374, 120);
            this.txtEmployeeSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeSearchName.MaxLength = 11;
            this.txtEmployeeSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeSearchName.Name = "txtEmployeeSearchName";
            this.txtEmployeeSearchName.Size = new System.Drawing.Size(258, 27);
            this.txtEmployeeSearchName.TabIndex = 16;
            this.txtEmployeeSearchName.Click += new System.EventHandler(this.txtEmployeeSearchName_Click);
            this.txtEmployeeSearchName.TextChanged += new System.EventHandler(this.txtEmployeeSearchName_TextChanged);
            this.txtEmployeeSearchName.Leave += new System.EventHandler(this.txtEmployeeSearchName_Leave);
            // 
            // pnlEmployeeName
            // 
            this.pnlEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlEmployeeName.Location = new System.Drawing.Point(369, 141);
            this.pnlEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployeeName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlEmployeeName.Name = "pnlEmployeeName";
            this.pnlEmployeeName.Size = new System.Drawing.Size(270, 1);
            this.pnlEmployeeName.TabIndex = 221;
            // 
            // picEmployeeClose
            // 
            this.picEmployeeClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picEmployeeClose.BackColor = System.Drawing.Color.Transparent;
            this.picEmployeeClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEmployeeClose.BackgroundImage")));
            this.picEmployeeClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEmployeeClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmployeeClose.Location = new System.Drawing.Point(1118, 8);
            this.picEmployeeClose.Margin = new System.Windows.Forms.Padding(0);
            this.picEmployeeClose.Name = "picEmployeeClose";
            this.picEmployeeClose.Size = new System.Drawing.Size(29, 24);
            this.picEmployeeClose.TabIndex = 7;
            this.picEmployeeClose.TabStop = false;
            this.picEmployeeClose.Click += new System.EventHandler(this.picEmployeeClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tabela de Funcionário";
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 10);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(32, 25);
            this.picIcone.TabIndex = 169;
            this.picIcone.TabStop = false;
            // 
            // pnlEmployeeTopBar
            // 
            this.pnlEmployeeTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(77)))));
            this.pnlEmployeeTopBar.Controls.Add(this.picIcone);
            this.pnlEmployeeTopBar.Controls.Add(this.label5);
            this.pnlEmployeeTopBar.Controls.Add(this.picEmployeeClose);
            this.pnlEmployeeTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlEmployeeTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployeeTopBar.Name = "pnlEmployeeTopBar";
            this.pnlEmployeeTopBar.Size = new System.Drawing.Size(1156, 40);
            this.pnlEmployeeTopBar.TabIndex = 212;
            // 
            // pnlEmployeeCPF
            // 
            this.pnlEmployeeCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlEmployeeCPF.Location = new System.Drawing.Point(677, 141);
            this.pnlEmployeeCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployeeCPF.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlEmployeeCPF.Name = "pnlEmployeeCPF";
            this.pnlEmployeeCPF.Size = new System.Drawing.Size(206, 1);
            this.pnlEmployeeCPF.TabIndex = 222;
            // 
            // txtEmployeeSearchCPF
            // 
            this.txtEmployeeSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtEmployeeSearchCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeSearchCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSearchCPF.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeSearchCPF.Location = new System.Drawing.Point(681, 120);
            this.txtEmployeeSearchCPF.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeSearchCPF.MaxLength = 11;
            this.txtEmployeeSearchCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeSearchCPF.Name = "txtEmployeeSearchCPF";
            this.txtEmployeeSearchCPF.Size = new System.Drawing.Size(188, 27);
            this.txtEmployeeSearchCPF.TabIndex = 17;
            this.txtEmployeeSearchCPF.Click += new System.EventHandler(this.txtEmployeeSearchCPF_Click);
            this.txtEmployeeSearchCPF.TextChanged += new System.EventHandler(this.txtEmployeeSearchCPF_TextChanged);
            this.txtEmployeeSearchCPF.Leave += new System.EventHandler(this.txtEmployeeSearchCPF_Leave);
            // 
            // FormRegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1156, 699);
            this.Controls.Add(this.pnlEmployeeCPF);
            this.Controls.Add(this.pnlEmployeeName);
            this.Controls.Add(this.chkEmployeeActive);
            this.Controls.Add(this.picEmployeeRefresh);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.btnEmployeeNew);
            this.Controls.Add(this.btnEmployeeClear);
            this.Controls.Add(this.txtEmployeeDistrict);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlEmployeeTopBar);
            this.Controls.Add(this.txtEmployeeSearchCPF);
            this.Controls.Add(this.txtEmployeeSearchName);
            this.Controls.Add(this.cboEmployeePosition);
            this.Controls.Add(this.mktEmployeeCEP);
            this.Controls.Add(this.lblCadPassFun2);
            this.Controls.Add(this.txtEmployeePassword2);
            this.Controls.Add(this.lblCadPassFun);
            this.Controls.Add(this.txtEmployeePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeStreet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmployeeRegister);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.lblConsCliCod);
            this.Controls.Add(this.btnEmployeeSearch);
            this.Controls.Add(this.lblConsCliNome);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblConsCliCadastrados);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.mktEmployeeCPF);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.lblCadCliEmail);
            this.Controls.Add(this.lblCadCliTel2);
            this.Controls.Add(this.txtEmployeePhone);
            this.Controls.Add(this.lblCadCliTel1);
            this.Controls.Add(this.txtEmployeeRG);
            this.Controls.Add(this.lblCadCliRg);
            this.Controls.Add(this.lblCadCliCpf);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblCadCliNome);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormRegisterEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.pnlEmployeeTopBar.ResumeLayout(false);
            this.pnlEmployeeTopBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmployeeRegister;
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Label lblConsCliCod;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.Label lblConsCliNome;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblConsCliCadastrados;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.MaskedTextBox mktEmployeeCPF;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label lblCadCliEmail;
        private System.Windows.Forms.Label lblCadCliTel2;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.Label lblCadCliTel1;
        private System.Windows.Forms.TextBox txtEmployeeRG;
        private System.Windows.Forms.Label lblCadCliRg;
        private System.Windows.Forms.Label lblCadCliCpf;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblCadCliNome;
        private System.Windows.Forms.TextBox txtEmployeeStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCadPassFun2;
        private System.Windows.Forms.TextBox txtEmployeePassword2;
        private System.Windows.Forms.Label lblCadPassFun;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.MaskedTextBox mktEmployeeCEP;
        private System.Windows.Forms.ComboBox cboEmployeePosition;
        private System.Windows.Forms.TextBox txtEmployeeDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEmployeeClear;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Button btnEmployeeNew;
        private System.Windows.Forms.PictureBox picEmployeeRefresh;
        private System.Windows.Forms.CheckBox chkEmployeeActive;
        private System.Windows.Forms.TextBox txtEmployeeSearchName;
        private System.Windows.Forms.Panel pnlEmployeeName;
        private System.Windows.Forms.PictureBox picEmployeeClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Panel pnlEmployeeTopBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel pnlEmployeeCPF;
        private System.Windows.Forms.TextBox txtEmployeeSearchCPF;
    }
}