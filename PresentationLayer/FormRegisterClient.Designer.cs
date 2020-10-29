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
            this.pnlConsCliCod = new System.Windows.Forms.Panel();
            this.lblConsCliCod = new System.Windows.Forms.Label();
            this.btnClient_Search = new System.Windows.Forms.Button();
            this.txtConsCliNome = new System.Windows.Forms.TextBox();
            this.lblConsCliNome = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblConsCliCadastrados = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.txtCadCliCpf = new System.Windows.Forms.MaskedTextBox();
            this.chkCadCliEstado = new System.Windows.Forms.CheckBox();
            this.txtCadCliEmail = new System.Windows.Forms.TextBox();
            this.lblCadCliEmail = new System.Windows.Forms.Label();
            this.txtCadCliTel2 = new System.Windows.Forms.TextBox();
            this.lblCadCliTel2 = new System.Windows.Forms.Label();
            this.txtCadCliTel1 = new System.Windows.Forms.TextBox();
            this.lblCadCliTel1 = new System.Windows.Forms.Label();
            this.txtCadCliRg = new System.Windows.Forms.TextBox();
            this.lblCadCliRg = new System.Windows.Forms.Label();
            this.lblCadCliCpf = new System.Windows.Forms.Label();
            this.txtCadCliNome = new System.Windows.Forms.TextBox();
            this.lblCadCliNome = new System.Windows.Forms.Label();
            this.picBtnClose = new System.Windows.Forms.PictureBox();
            this.lblNomeTabela = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnClient_New = new System.Windows.Forms.Button();
            this.btnClient_Register = new System.Windows.Forms.Button();
            this.btnClient_Edit = new System.Windows.Forms.Button();
            this.btnClient_Delete = new System.Windows.Forms.Button();
            this.btnClient_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadID.Location = new System.Drawing.Point(278, 84);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(33, 23);
            this.lblCadID.TabIndex = 141;
            this.lblCadID.Text = "ID:";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlConsCliCod
            // 
            this.pnlConsCliCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlConsCliCod.Location = new System.Drawing.Point(680, 129);
            this.pnlConsCliCod.MaximumSize = new System.Drawing.Size(500, 1);
            this.pnlConsCliCod.Name = "pnlConsCliCod";
            this.pnlConsCliCod.Size = new System.Drawing.Size(152, 1);
            this.pnlConsCliCod.TabIndex = 153;
            // 
            // lblConsCliCod
            // 
            this.lblConsCliCod.AutoSize = true;
            this.lblConsCliCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliCod.Location = new System.Drawing.Point(676, 85);
            this.lblConsCliCod.Name = "lblConsCliCod";
            this.lblConsCliCod.Size = new System.Drawing.Size(68, 23);
            this.lblConsCliCod.TabIndex = 152;
            this.lblConsCliCod.Text = "Código";
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
            this.btnClient_Search.Location = new System.Drawing.Point(852, 91);
            this.btnClient_Search.Name = "btnClient_Search";
            this.btnClient_Search.Size = new System.Drawing.Size(144, 53);
            this.btnClient_Search.TabIndex = 154;
            this.btnClient_Search.Text = "Pesquisar";
            this.btnClient_Search.UseVisualStyleBackColor = false;
            // 
            // txtConsCliNome
            // 
            this.txtConsCliNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.txtConsCliNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsCliNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsCliNome.ForeColor = System.Drawing.Color.Black;
            this.txtConsCliNome.Location = new System.Drawing.Point(402, 106);
            this.txtConsCliNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtConsCliNome.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtConsCliNome.Name = "txtConsCliNome";
            this.txtConsCliNome.Size = new System.Drawing.Size(265, 27);
            this.txtConsCliNome.TabIndex = 151;
            // 
            // lblConsCliNome
            // 
            this.lblConsCliNome.AutoSize = true;
            this.lblConsCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblConsCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsCliNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsCliNome.Location = new System.Drawing.Point(398, 85);
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
            this.lblConsCliCadastrados.Location = new System.Drawing.Point(398, 150);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeight = 29;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Location = new System.Drawing.Point(402, 172);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvClients.Size = new System.Drawing.Size(594, 313);
            this.dgvClients.TabIndex = 156;
            // 
            // txtCadCliCpf
            // 
            this.txtCadCliCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtCadCliCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadCliCpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCadCliCpf.Location = new System.Drawing.Point(39, 169);
            this.txtCadCliCpf.Mask = "000,000,000-00";
            this.txtCadCliCpf.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtCadCliCpf.Name = "txtCadCliCpf";
            this.txtCadCliCpf.Size = new System.Drawing.Size(157, 27);
            this.txtCadCliCpf.TabIndex = 135;
            // 
            // chkCadCliEstado
            // 
            this.chkCadCliEstado.AutoSize = true;
            this.chkCadCliEstado.BackColor = System.Drawing.Color.Transparent;
            this.chkCadCliEstado.Checked = true;
            this.chkCadCliEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCadCliEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCadCliEstado.Location = new System.Drawing.Point(35, 339);
            this.chkCadCliEstado.Name = "chkCadCliEstado";
            this.chkCadCliEstado.Size = new System.Drawing.Size(75, 27);
            this.chkCadCliEstado.TabIndex = 146;
            this.chkCadCliEstado.Text = "Ativo";
            this.chkCadCliEstado.UseVisualStyleBackColor = false;
            // 
            // txtCadCliEmail
            // 
            this.txtCadCliEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.txtCadCliEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadCliEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCliEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCadCliEmail.Location = new System.Drawing.Point(35, 298);
            this.txtCadCliEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadCliEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtCadCliEmail.Name = "txtCadCliEmail";
            this.txtCadCliEmail.Size = new System.Drawing.Size(325, 27);
            this.txtCadCliEmail.TabIndex = 144;
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
            // txtCadCliTel2
            // 
            this.txtCadCliTel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtCadCliTel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadCliTel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCliTel2.ForeColor = System.Drawing.Color.Black;
            this.txtCadCliTel2.Location = new System.Drawing.Point(210, 235);
            this.txtCadCliTel2.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadCliTel2.MaxLength = 11;
            this.txtCadCliTel2.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtCadCliTel2.Name = "txtCadCliTel2";
            this.txtCadCliTel2.Size = new System.Drawing.Size(150, 27);
            this.txtCadCliTel2.TabIndex = 142;
            // 
            // lblCadCliTel2
            // 
            this.lblCadCliTel2.AutoSize = true;
            this.lblCadCliTel2.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel2.Location = new System.Drawing.Point(202, 214);
            this.lblCadCliTel2.Name = "lblCadCliTel2";
            this.lblCadCliTel2.Size = new System.Drawing.Size(171, 23);
            this.lblCadCliTel2.TabIndex = 140;
            this.lblCadCliTel2.Text = "Telefone Secundário";
            // 
            // txtCadCliTel1
            // 
            this.txtCadCliTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtCadCliTel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCliTel1.ForeColor = System.Drawing.Color.Black;
            this.txtCadCliTel1.Location = new System.Drawing.Point(35, 235);
            this.txtCadCliTel1.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadCliTel1.MaxLength = 11;
            this.txtCadCliTel1.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtCadCliTel1.Name = "txtCadCliTel1";
            this.txtCadCliTel1.Size = new System.Drawing.Size(161, 27);
            this.txtCadCliTel1.TabIndex = 139;
            // 
            // lblCadCliTel1
            // 
            this.lblCadCliTel1.AutoSize = true;
            this.lblCadCliTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliTel1.Location = new System.Drawing.Point(31, 214);
            this.lblCadCliTel1.Name = "lblCadCliTel1";
            this.lblCadCliTel1.Size = new System.Drawing.Size(152, 23);
            this.lblCadCliTel1.TabIndex = 138;
            this.lblCadCliTel1.Text = "Telefone Principal";
            // 
            // txtCadCliRg
            // 
            this.txtCadCliRg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtCadCliRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadCliRg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCliRg.ForeColor = System.Drawing.Color.Black;
            this.txtCadCliRg.Location = new System.Drawing.Point(210, 167);
            this.txtCadCliRg.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadCliRg.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtCadCliRg.Name = "txtCadCliRg";
            this.txtCadCliRg.Size = new System.Drawing.Size(150, 27);
            this.txtCadCliRg.TabIndex = 137;
            // 
            // lblCadCliRg
            // 
            this.lblCadCliRg.AutoSize = true;
            this.lblCadCliRg.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliRg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadCliRg.Location = new System.Drawing.Point(202, 146);
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
            this.lblCadCliCpf.Location = new System.Drawing.Point(31, 146);
            this.lblCadCliCpf.Name = "lblCadCliCpf";
            this.lblCadCliCpf.Size = new System.Drawing.Size(40, 23);
            this.lblCadCliCpf.TabIndex = 134;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // txtCadCliNome
            // 
            this.txtCadCliNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtCadCliNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadCliNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadCliNome.ForeColor = System.Drawing.Color.Black;
            this.txtCadCliNome.Location = new System.Drawing.Point(35, 108);
            this.txtCadCliNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtCadCliNome.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtCadCliNome.Name = "txtCadCliNome";
            this.txtCadCliNome.Size = new System.Drawing.Size(325, 27);
            this.txtCadCliNome.TabIndex = 133;
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
            this.picBtnClose.Location = new System.Drawing.Point(1026, 7);
            this.picBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.picBtnClose.Name = "picBtnClose";
            this.picBtnClose.Size = new System.Drawing.Size(26, 26);
            this.picBtnClose.TabIndex = 7;
            this.picBtnClose.TabStop = false;
            this.picBtnClose.Click += new System.EventHandler(this.picBtnClose_Click);
            // 
            // lblNomeTabela
            // 
            this.lblNomeTabela.AutoSize = true;
            this.lblNomeTabela.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeTabela.ForeColor = System.Drawing.Color.White;
            this.lblNomeTabela.Location = new System.Drawing.Point(34, 9);
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
            this.pnlTopBar.Size = new System.Drawing.Size(1061, 40);
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
            this.btnClient_New.Location = new System.Drawing.Point(89, 516);
            this.btnClient_New.Name = "btnClient_New";
            this.btnClient_New.Size = new System.Drawing.Size(222, 53);
            this.btnClient_New.TabIndex = 158;
            this.btnClient_New.Text = "Novo";
            this.btnClient_New.UseVisualStyleBackColor = false;
            // 
            // btnClient_Register
            // 
            this.btnClient_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient_Register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Register.FlatAppearance.BorderSize = 3;
            this.btnClient_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient_Register.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient_Register.ForeColor = System.Drawing.Color.White;
            this.btnClient_Register.Location = new System.Drawing.Point(378, 516);
            this.btnClient_Register.Name = "btnClient_Register";
            this.btnClient_Register.Size = new System.Drawing.Size(144, 53);
            this.btnClient_Register.TabIndex = 159;
            this.btnClient_Register.Text = "Cadastrar";
            this.btnClient_Register.UseVisualStyleBackColor = false;
            this.btnClient_Register.Click += new System.EventHandler(this.btnClient_Register_Click);
            // 
            // btnClient_Edit
            // 
            this.btnClient_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Edit.FlatAppearance.BorderSize = 3;
            this.btnClient_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient_Edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient_Edit.ForeColor = System.Drawing.Color.White;
            this.btnClient_Edit.Location = new System.Drawing.Point(541, 516);
            this.btnClient_Edit.Name = "btnClient_Edit";
            this.btnClient_Edit.Size = new System.Drawing.Size(144, 53);
            this.btnClient_Edit.TabIndex = 160;
            this.btnClient_Edit.Text = "Editar";
            this.btnClient_Edit.UseVisualStyleBackColor = false;
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
            this.btnClient_Delete.Location = new System.Drawing.Point(702, 516);
            this.btnClient_Delete.Name = "btnClient_Delete";
            this.btnClient_Delete.Size = new System.Drawing.Size(144, 53);
            this.btnClient_Delete.TabIndex = 161;
            this.btnClient_Delete.Text = "Excluir";
            this.btnClient_Delete.UseVisualStyleBackColor = false;
            // 
            // btnClient_Update
            // 
            this.btnClient_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClient_Update.FlatAppearance.BorderSize = 3;
            this.btnClient_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient_Update.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient_Update.ForeColor = System.Drawing.Color.White;
            this.btnClient_Update.Location = new System.Drawing.Point(864, 516);
            this.btnClient_Update.Name = "btnClient_Update";
            this.btnClient_Update.Size = new System.Drawing.Size(144, 53);
            this.btnClient_Update.TabIndex = 162;
            this.btnClient_Update.Text = "Atualizar";
            this.btnClient_Update.UseVisualStyleBackColor = false;
            // 
            // FormRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1061, 594);
            this.Controls.Add(this.btnClient_Update);
            this.Controls.Add(this.btnClient_Delete);
            this.Controls.Add(this.btnClient_Edit);
            this.Controls.Add(this.btnClient_Register);
            this.Controls.Add(this.btnClient_New);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.pnlConsCliCod);
            this.Controls.Add(this.lblConsCliCod);
            this.Controls.Add(this.btnClient_Search);
            this.Controls.Add(this.txtConsCliNome);
            this.Controls.Add(this.lblConsCliNome);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblConsCliCadastrados);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.txtCadCliCpf);
            this.Controls.Add(this.chkCadCliEstado);
            this.Controls.Add(this.txtCadCliEmail);
            this.Controls.Add(this.lblCadCliEmail);
            this.Controls.Add(this.txtCadCliTel2);
            this.Controls.Add(this.lblCadCliTel2);
            this.Controls.Add(this.txtCadCliTel1);
            this.Controls.Add(this.lblCadCliTel1);
            this.Controls.Add(this.txtCadCliRg);
            this.Controls.Add(this.lblCadCliRg);
            this.Controls.Add(this.lblCadCliCpf);
            this.Controls.Add(this.txtCadCliNome);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Panel pnlConsCliCod;
        private System.Windows.Forms.Label lblConsCliCod;
        private System.Windows.Forms.Button btnClient_Search;
        private System.Windows.Forms.TextBox txtConsCliNome;
        private System.Windows.Forms.Label lblConsCliNome;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblConsCliCadastrados;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.MaskedTextBox txtCadCliCpf;
        private System.Windows.Forms.CheckBox chkCadCliEstado;
        private System.Windows.Forms.TextBox txtCadCliEmail;
        private System.Windows.Forms.Label lblCadCliEmail;
        private System.Windows.Forms.TextBox txtCadCliTel2;
        private System.Windows.Forms.Label lblCadCliTel2;
        private System.Windows.Forms.TextBox txtCadCliTel1;
        private System.Windows.Forms.Label lblCadCliTel1;
        private System.Windows.Forms.TextBox txtCadCliRg;
        private System.Windows.Forms.Label lblCadCliRg;
        private System.Windows.Forms.Label lblCadCliCpf;
        private System.Windows.Forms.TextBox txtCadCliNome;
        private System.Windows.Forms.Label lblCadCliNome;
        private System.Windows.Forms.PictureBox picBtnClose;
        private System.Windows.Forms.Label lblNomeTabela;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnClient_New;
        private System.Windows.Forms.Button btnClient_Register;
        private System.Windows.Forms.Button btnClient_Edit;
        private System.Windows.Forms.Button btnClient_Delete;
        private System.Windows.Forms.Button btnClient_Update;
    }
}