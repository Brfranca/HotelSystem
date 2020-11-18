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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterEmployee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEmployeeRegister = new System.Windows.Forms.Button();
            this.lblConsCliCod = new System.Windows.Forms.Label();
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
            this.btnEmployeeSelect = new System.Windows.Forms.Button();
            this.picEmployeeRefresh = new System.Windows.Forms.PictureBox();
            this.chkEmployeeActive = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeSearchName = new System.Windows.Forms.TextBox();
            this.pnlEmployeeName = new System.Windows.Forms.Panel();
            this.txtEmployeeSearchCPF = new System.Windows.Forms.TextBox();
            this.pnlEmployeeCPF = new System.Windows.Forms.Panel();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeRegister
            // 
            this.btnEmployeeRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnEmployeeRegister.FlatAppearance.BorderSize = 0;
            this.btnEmployeeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnEmployeeRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeRegister.Image")));
            this.btnEmployeeRegister.Location = new System.Drawing.Point(103, 638);
            this.btnEmployeeRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeRegister.Name = "btnEmployeeRegister";
            this.btnEmployeeRegister.Size = new System.Drawing.Size(189, 53);
            this.btnEmployeeRegister.TabIndex = 14;
            this.btnEmployeeRegister.Text = "Cadastrar";
            this.btnEmployeeRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeRegister.UseVisualStyleBackColor = false;
            this.btnEmployeeRegister.Click += new System.EventHandler(this.btnEmployeeRegister_Click);
            // 
            // lblConsCliCod
            // 
            this.lblConsCliCod.AutoSize = true;
            this.lblConsCliCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliCod.ForeColor = System.Drawing.Color.White;
            this.lblConsCliCod.Location = new System.Drawing.Point(692, 109);
            this.lblConsCliCod.Name = "lblConsCliCod";
            this.lblConsCliCod.Size = new System.Drawing.Size(34, 19);
            this.lblConsCliCod.TabIndex = 183;
            this.lblConsCliCod.Text = "CPF";
            // 
            // lblConsCliNome
            // 
            this.lblConsCliNome.AutoSize = true;
            this.lblConsCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliNome.ForeColor = System.Drawing.Color.White;
            this.lblConsCliNome.Location = new System.Drawing.Point(385, 110);
            this.lblConsCliNome.Name = "lblConsCliNome";
            this.lblConsCliNome.Size = new System.Drawing.Size(154, 19);
            this.lblConsCliNome.TabIndex = 182;
            this.lblConsCliNome.Text = "Nome do Funcionário";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblConsultar.Location = new System.Drawing.Point(383, 72);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(98, 25);
            this.lblConsultar.TabIndex = 181;
            this.lblConsultar.Text = "Consultar";
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblCadastrar.Location = new System.Drawing.Point(37, 72);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(97, 25);
            this.lblCadastrar.TabIndex = 167;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblConsCliCadastrados
            // 
            this.lblConsCliCadastrados.AutoSize = true;
            this.lblConsCliCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliCadastrados.ForeColor = System.Drawing.Color.White;
            this.lblConsCliCadastrados.Location = new System.Drawing.Point(387, 167);
            this.lblConsCliCadastrados.Name = "lblConsCliCadastrados";
            this.lblConsCliCadastrados.Size = new System.Drawing.Size(180, 19);
            this.lblConsCliCadastrados.TabIndex = 186;
            this.lblConsCliCadastrados.Text = "Funcionários Cadastrados";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployee.ColumnHeadersHeight = 29;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployee.Location = new System.Drawing.Point(389, 188);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(755, 427);
            this.dgvEmployee.TabIndex = 19;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 68F;
            this.Column2.HeaderText = "CPF";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 68F;
            this.Column3.HeaderText = "Telefone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "E-mail";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Função";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mktEmployeeCPF
            // 
            this.mktEmployeeCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.mktEmployeeCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mktEmployeeCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mktEmployeeCPF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mktEmployeeCPF.Location = new System.Drawing.Point(43, 188);
            this.mktEmployeeCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mktEmployeeCPF.Mask = "000,000,000-00";
            this.mktEmployeeCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.mktEmployeeCPF.Name = "mktEmployeeCPF";
            this.mktEmployeeCPF.Size = new System.Drawing.Size(144, 22);
            this.mktEmployeeCPF.TabIndex = 1;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtEmployeeEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeEmail.Location = new System.Drawing.Point(43, 301);
            this.txtEmployeeEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeEmail.MaxLength = 200;
            this.txtEmployeeEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(303, 22);
            this.txtEmployeeEmail.TabIndex = 5;
            // 
            // lblCadCliEmail
            // 
            this.lblCadCliEmail.AutoSize = true;
            this.lblCadCliEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliEmail.ForeColor = System.Drawing.Color.White;
            this.lblCadCliEmail.Location = new System.Drawing.Point(39, 278);
            this.lblCadCliEmail.Name = "lblCadCliEmail";
            this.lblCadCliEmail.Size = new System.Drawing.Size(51, 19);
            this.lblCadCliEmail.TabIndex = 179;
            this.lblCadCliEmail.Text = "E-mail";
            // 
            // lblCadCliTel2
            // 
            this.lblCadCliTel2.AutoSize = true;
            this.lblCadCliTel2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel2.ForeColor = System.Drawing.Color.White;
            this.lblCadCliTel2.Location = new System.Drawing.Point(39, 335);
            this.lblCadCliTel2.Name = "lblCadCliTel2";
            this.lblCadCliTel2.Size = new System.Drawing.Size(34, 19);
            this.lblCadCliTel2.TabIndex = 176;
            this.lblCadCliTel2.Text = "CEP";
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtEmployeePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePhone.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePhone.Location = new System.Drawing.Point(43, 245);
            this.txtEmployeePhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeePhone.MaxLength = 11;
            this.txtEmployeePhone.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(144, 22);
            this.txtEmployeePhone.TabIndex = 3;
            // 
            // lblCadCliTel1
            // 
            this.lblCadCliTel1.AutoSize = true;
            this.lblCadCliTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel1.ForeColor = System.Drawing.Color.White;
            this.lblCadCliTel1.Location = new System.Drawing.Point(39, 222);
            this.lblCadCliTel1.Name = "lblCadCliTel1";
            this.lblCadCliTel1.Size = new System.Drawing.Size(66, 19);
            this.lblCadCliTel1.TabIndex = 174;
            this.lblCadCliTel1.Text = "Telefone";
            // 
            // txtEmployeeRG
            // 
            this.txtEmployeeRG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtEmployeeRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeRG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeRG.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeRG.Location = new System.Drawing.Point(202, 188);
            this.txtEmployeeRG.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeRG.MaxLength = 15;
            this.txtEmployeeRG.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeRG.Name = "txtEmployeeRG";
            this.txtEmployeeRG.Size = new System.Drawing.Size(144, 22);
            this.txtEmployeeRG.TabIndex = 2;
            // 
            // lblCadCliRg
            // 
            this.lblCadCliRg.AutoSize = true;
            this.lblCadCliRg.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliRg.ForeColor = System.Drawing.Color.White;
            this.lblCadCliRg.Location = new System.Drawing.Point(197, 166);
            this.lblCadCliRg.Name = "lblCadCliRg";
            this.lblCadCliRg.Size = new System.Drawing.Size(28, 19);
            this.lblCadCliRg.TabIndex = 172;
            this.lblCadCliRg.Text = "RG";
            // 
            // lblCadCliCpf
            // 
            this.lblCadCliCpf.AutoSize = true;
            this.lblCadCliCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliCpf.ForeColor = System.Drawing.Color.White;
            this.lblCadCliCpf.Location = new System.Drawing.Point(39, 166);
            this.lblCadCliCpf.Name = "lblCadCliCpf";
            this.lblCadCliCpf.Size = new System.Drawing.Size(34, 19);
            this.lblCadCliCpf.TabIndex = 170;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeName.Location = new System.Drawing.Point(43, 132);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeName.MaxLength = 100;
            this.txtEmployeeName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(303, 22);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // lblCadCliNome
            // 
            this.lblCadCliNome.AutoSize = true;
            this.lblCadCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliNome.ForeColor = System.Drawing.Color.White;
            this.lblCadCliNome.Location = new System.Drawing.Point(39, 110);
            this.lblCadCliNome.Name = "lblCadCliNome";
            this.lblCadCliNome.Size = new System.Drawing.Size(50, 19);
            this.lblCadCliNome.TabIndex = 168;
            this.lblCadCliNome.Text = "Nome";
            // 
            // txtEmployeeStreet
            // 
            this.txtEmployeeStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtEmployeeStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeStreet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeStreet.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeStreet.Location = new System.Drawing.Point(43, 414);
            this.txtEmployeeStreet.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeStreet.MaxLength = 150;
            this.txtEmployeeStreet.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeStreet.Name = "txtEmployeeStreet";
            this.txtEmployeeStreet.Size = new System.Drawing.Size(303, 22);
            this.txtEmployeeStreet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 194;
            this.label1.Text = "Rua";
            // 
            // txtEmployeeCity
            // 
            this.txtEmployeeCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.txtEmployeeCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeCity.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeCity.Location = new System.Drawing.Point(176, 358);
            this.txtEmployeeCity.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeCity.MaxLength = 100;
            this.txtEmployeeCity.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeCity.Name = "txtEmployeeCity";
            this.txtEmployeeCity.Size = new System.Drawing.Size(170, 22);
            this.txtEmployeeCity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 196;
            this.label2.Text = "Cidade";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtEmployeeNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeNumber.Location = new System.Drawing.Point(43, 472);
            this.txtEmployeeNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeNumber.MaxLength = 7;
            this.txtEmployeeNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(62, 22);
            this.txtEmployeeNumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 198;
            this.label3.Text = "Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(198, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 200;
            this.label4.Text = "Função";
            // 
            // lblCadPassFun2
            // 
            this.lblCadPassFun2.AutoSize = true;
            this.lblCadPassFun2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPassFun2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPassFun2.ForeColor = System.Drawing.Color.White;
            this.lblCadPassFun2.Location = new System.Drawing.Point(199, 507);
            this.lblCadPassFun2.Name = "lblCadPassFun2";
            this.lblCadPassFun2.Size = new System.Drawing.Size(102, 19);
            this.lblCadPassFun2.TabIndex = 204;
            this.lblCadPassFun2.Text = "Repetir Senha";
            // 
            // txtEmployeePassword2
            // 
            this.txtEmployeePassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.txtEmployeePassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword2.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePassword2.Location = new System.Drawing.Point(203, 530);
            this.txtEmployeePassword2.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeePassword2.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeePassword2.Name = "txtEmployeePassword2";
            this.txtEmployeePassword2.Size = new System.Drawing.Size(143, 22);
            this.txtEmployeePassword2.TabIndex = 12;
            this.txtEmployeePassword2.UseSystemPasswordChar = true;
            // 
            // lblCadPassFun
            // 
            this.lblCadPassFun.AutoSize = true;
            this.lblCadPassFun.BackColor = System.Drawing.Color.Transparent;
            this.lblCadPassFun.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPassFun.ForeColor = System.Drawing.Color.White;
            this.lblCadPassFun.Location = new System.Drawing.Point(39, 507);
            this.lblCadPassFun.Name = "lblCadPassFun";
            this.lblCadPassFun.Size = new System.Drawing.Size(49, 19);
            this.lblCadPassFun.TabIndex = 202;
            this.lblCadPassFun.Text = "Senha";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.txtEmployeePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeePassword.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePassword.Location = new System.Drawing.Point(43, 530);
            this.txtEmployeePassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeePassword.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(145, 22);
            this.txtEmployeePassword.TabIndex = 11;
            this.txtEmployeePassword.UseSystemPasswordChar = true;
            // 
            // mktEmployeeCEP
            // 
            this.mktEmployeeCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(226)))));
            this.mktEmployeeCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mktEmployeeCEP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mktEmployeeCEP.Location = new System.Drawing.Point(43, 358);
            this.mktEmployeeCEP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mktEmployeeCEP.Mask = "00000-000";
            this.mktEmployeeCEP.Name = "mktEmployeeCEP";
            this.mktEmployeeCEP.Size = new System.Drawing.Size(118, 22);
            this.mktEmployeeCEP.TabIndex = 6;
            this.mktEmployeeCEP.Leave += new System.EventHandler(this.mktEmployeeCEP_Leave);
            // 
            // cboEmployeePosition
            // 
            this.cboEmployeePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.cboEmployeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeePosition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEmployeePosition.FormattingEnabled = true;
            this.cboEmployeePosition.Location = new System.Drawing.Point(202, 244);
            this.cboEmployeePosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEmployeePosition.Name = "cboEmployeePosition";
            this.cboEmployeePosition.Size = new System.Drawing.Size(144, 25);
            this.cboEmployeePosition.TabIndex = 4;
            // 
            // txtEmployeeDistrict
            // 
            this.txtEmployeeDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.txtEmployeeDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeDistrict.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeDistrict.Location = new System.Drawing.Point(120, 472);
            this.txtEmployeeDistrict.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeDistrict.MaxLength = 150;
            this.txtEmployeeDistrict.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeDistrict.Name = "txtEmployeeDistrict";
            this.txtEmployeeDistrict.Size = new System.Drawing.Size(226, 22);
            this.txtEmployeeDistrict.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(117, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 213;
            this.label6.Text = "Bairro";
            // 
            // btnEmployeeClear
            // 
            this.btnEmployeeClear.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnEmployeeClear.FlatAppearance.BorderSize = 0;
            this.btnEmployeeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnEmployeeClear.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeClear.Image")));
            this.btnEmployeeClear.Location = new System.Drawing.Point(248, 567);
            this.btnEmployeeClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeClear.Name = "btnEmployeeClear";
            this.btnEmployeeClear.Size = new System.Drawing.Size(98, 36);
            this.btnEmployeeClear.TabIndex = 15;
            this.btnEmployeeClear.Text = "Limpar";
            this.btnEmployeeClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeClear.UseVisualStyleBackColor = false;
            this.btnEmployeeClear.Click += new System.EventHandler(this.btnEmployeeClear_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnEmployeeDelete.FlatAppearance.BorderSize = 0;
            this.btnEmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnEmployeeDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeDelete.Image")));
            this.btnEmployeeDelete.Location = new System.Drawing.Point(794, 640);
            this.btnEmployeeDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(138, 47);
            this.btnEmployeeDelete.TabIndex = 19;
            this.btnEmployeeDelete.Text = "Excluir";
            this.btnEmployeeDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeDelete.UseVisualStyleBackColor = false;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // btnEmployeeSelect
            // 
            this.btnEmployeeSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnEmployeeSelect.FlatAppearance.BorderSize = 0;
            this.btnEmployeeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnEmployeeSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeSelect.Image")));
            this.btnEmployeeSelect.Location = new System.Drawing.Point(944, 640);
            this.btnEmployeeSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeSelect.Name = "btnEmployeeSelect";
            this.btnEmployeeSelect.Size = new System.Drawing.Size(138, 47);
            this.btnEmployeeSelect.TabIndex = 18;
            this.btnEmployeeSelect.Text = "Selecionar";
            this.btnEmployeeSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeSelect.UseVisualStyleBackColor = false;
            this.btnEmployeeSelect.Click += new System.EventHandler(this.btnEmployeeSelect_Click);
            // 
            // picEmployeeRefresh
            // 
            this.picEmployeeRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picEmployeeRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEmployeeRefresh.BackgroundImage")));
            this.picEmployeeRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEmployeeRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmployeeRefresh.Location = new System.Drawing.Point(1097, 644);
            this.picEmployeeRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picEmployeeRefresh.Name = "picEmployeeRefresh";
            this.picEmployeeRefresh.Size = new System.Drawing.Size(42, 38);
            this.picEmployeeRefresh.TabIndex = 219;
            this.picEmployeeRefresh.TabStop = false;
            this.picEmployeeRefresh.Click += new System.EventHandler(this.picEmployeeRefresh_Click);
            // 
            // chkEmployeeActive
            // 
            this.chkEmployeeActive.AutoSize = true;
            this.chkEmployeeActive.BackColor = System.Drawing.Color.Transparent;
            this.chkEmployeeActive.Checked = true;
            this.chkEmployeeActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmployeeActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployeeActive.ForeColor = System.Drawing.Color.White;
            this.chkEmployeeActive.Location = new System.Drawing.Point(43, 572);
            this.chkEmployeeActive.Name = "chkEmployeeActive";
            this.chkEmployeeActive.Size = new System.Drawing.Size(64, 23);
            this.chkEmployeeActive.TabIndex = 13;
            this.chkEmployeeActive.Text = "Ativo";
            this.chkEmployeeActive.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblID.Location = new System.Drawing.Point(299, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 225;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(282, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 224;
            this.label7.Text = "ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmployeeSearchName
            // 
            this.txtEmployeeSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtEmployeeSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSearchName.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeSearchName.Location = new System.Drawing.Point(395, 132);
            this.txtEmployeeSearchName.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeSearchName.MaxLength = 11;
            this.txtEmployeeSearchName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeSearchName.Name = "txtEmployeeSearchName";
            this.txtEmployeeSearchName.Size = new System.Drawing.Size(258, 22);
            this.txtEmployeeSearchName.TabIndex = 16;
            this.txtEmployeeSearchName.TextChanged += new System.EventHandler(this.txtEmployeeSearchName_TextChanged);
            this.txtEmployeeSearchName.Enter += new System.EventHandler(this.txtEmployeeSearchName_Enter);
            this.txtEmployeeSearchName.Leave += new System.EventHandler(this.txtEmployeeSearchName_Leave);
            // 
            // pnlEmployeeName
            // 
            this.pnlEmployeeName.BackColor = System.Drawing.Color.White;
            this.pnlEmployeeName.ForeColor = System.Drawing.Color.White;
            this.pnlEmployeeName.Location = new System.Drawing.Point(391, 153);
            this.pnlEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployeeName.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlEmployeeName.Name = "pnlEmployeeName";
            this.pnlEmployeeName.Size = new System.Drawing.Size(270, 1);
            this.pnlEmployeeName.TabIndex = 227;
            // 
            // txtEmployeeSearchCPF
            // 
            this.txtEmployeeSearchCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtEmployeeSearchCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeSearchCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeSearchCPF.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeSearchCPF.Location = new System.Drawing.Point(701, 132);
            this.txtEmployeeSearchCPF.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmployeeSearchCPF.MaxLength = 11;
            this.txtEmployeeSearchCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtEmployeeSearchCPF.Name = "txtEmployeeSearchCPF";
            this.txtEmployeeSearchCPF.Size = new System.Drawing.Size(191, 22);
            this.txtEmployeeSearchCPF.TabIndex = 17;
            this.txtEmployeeSearchCPF.TextChanged += new System.EventHandler(this.txtEmployeeSearchCPF_TextChanged);
            this.txtEmployeeSearchCPF.Enter += new System.EventHandler(this.txtEmployeeSearchCPF_Enter);
            this.txtEmployeeSearchCPF.Leave += new System.EventHandler(this.txtEmployeeSearchCPF_Leave);
            // 
            // pnlEmployeeCPF
            // 
            this.pnlEmployeeCPF.BackColor = System.Drawing.Color.White;
            this.pnlEmployeeCPF.ForeColor = System.Drawing.Color.White;
            this.pnlEmployeeCPF.Location = new System.Drawing.Point(695, 153);
            this.pnlEmployeeCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployeeCPF.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlEmployeeCPF.Name = "pnlEmployeeCPF";
            this.pnlEmployeeCPF.Size = new System.Drawing.Size(206, 1);
            this.pnlEmployeeCPF.TabIndex = 229;
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
            this.lblDot1.Size = new System.Drawing.Size(20, 28);
            this.lblDot1.TabIndex = 231;
            this.lblDot1.Text = "•";
            this.lblDot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(37, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 230;
            this.label5.Text = "Funcionários";
            // 
            // FormRegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlEmployeeCPF);
            this.Controls.Add(this.txtEmployeeSearchCPF);
            this.Controls.Add(this.pnlEmployeeName);
            this.Controls.Add(this.txtEmployeeSearchName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkEmployeeActive);
            this.Controls.Add(this.picEmployeeRefresh);
            this.Controls.Add(this.btnEmployeeDelete);
            this.Controls.Add(this.btnEmployeeSelect);
            this.Controls.Add(this.btnEmployeeClear);
            this.Controls.Add(this.txtEmployeeDistrict);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.lblConsCliCod);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmployeeRegister;
        private System.Windows.Forms.Label lblConsCliCod;
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
        private System.Windows.Forms.Button btnEmployeeSelect;
        private System.Windows.Forms.PictureBox picEmployeeRefresh;
        private System.Windows.Forms.CheckBox chkEmployeeActive;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtEmployeeSearchName;
        private System.Windows.Forms.Panel pnlEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeSearchCPF;
        private System.Windows.Forms.Panel pnlEmployeeCPF;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Label label5;
    }
}