namespace PresentationLayer
{
    partial class FormRegisterRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRoomClear = new System.Windows.Forms.Button();
            this.lblConsFornCadastrados = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRoomSearchID = new System.Windows.Forms.TextBox();
            this.txtRoomSearchNumber = new System.Windows.Forms.TextBox();
            this.lblConsProdCod = new System.Windows.Forms.Label();
            this.lblSearchNumero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRoomRegister = new System.Windows.Forms.Button();
            this.btnRoomSelect = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.lblRoomFloor = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchNumber = new System.Windows.Forms.Panel();
            this.pnlsearchID = new System.Windows.Forms.Panel();
            this.lblCadID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.picRoomRefresh = new System.Windows.Forms.PictureBox();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRoomStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoomClear
            // 
            this.btnRoomClear.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnRoomClear.FlatAppearance.BorderSize = 0;
            this.btnRoomClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnRoomClear.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomClear.Image")));
            this.btnRoomClear.Location = new System.Drawing.Point(178, 383);
            this.btnRoomClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomClear.Name = "btnRoomClear";
            this.btnRoomClear.Size = new System.Drawing.Size(98, 36);
            this.btnRoomClear.TabIndex = 240;
            this.btnRoomClear.Text = "Limpar";
            this.btnRoomClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomClear.UseVisualStyleBackColor = false;
            this.btnRoomClear.Click += new System.EventHandler(this.btnRoomClear_Click);
            // 
            // lblConsFornCadastrados
            // 
            this.lblConsFornCadastrados.AutoSize = true;
            this.lblConsFornCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsFornCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsFornCadastrados.ForeColor = System.Drawing.Color.White;
            this.lblConsFornCadastrados.Location = new System.Drawing.Point(387, 167);
            this.lblConsFornCadastrados.Name = "lblConsFornCadastrados";
            this.lblConsFornCadastrados.Size = new System.Drawing.Size(147, 19);
            this.lblConsFornCadastrados.TabIndex = 237;
            this.lblConsFornCadastrados.Text = "Quartos cadastrados";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvRooms.ColumnHeadersHeight = 29;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnFloor,
            this.ColumnPrice,
            this.ColumnRoomType,
            this.ColumnAvailability});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvRooms.Location = new System.Drawing.Point(389, 188);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvRooms.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(700, 344);
            this.dgvRooms.TabIndex = 238;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellDoubleClick);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Número";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnFloor
            // 
            this.ColumnFloor.HeaderText = "Andar";
            this.ColumnFloor.MinimumWidth = 6;
            this.ColumnFloor.Name = "ColumnFloor";
            this.ColumnFloor.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Preço diária (R$)";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnRoomType
            // 
            this.ColumnRoomType.HeaderText = "Tipo";
            this.ColumnRoomType.MinimumWidth = 6;
            this.ColumnRoomType.Name = "ColumnRoomType";
            this.ColumnRoomType.ReadOnly = true;
            // 
            // ColumnAvailability
            // 
            this.ColumnAvailability.HeaderText = "Status";
            this.ColumnAvailability.MinimumWidth = 6;
            this.ColumnAvailability.Name = "ColumnAvailability";
            this.ColumnAvailability.ReadOnly = true;
            // 
            // txtRoomSearchID
            // 
            this.txtRoomSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtRoomSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomSearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSearchID.ForeColor = System.Drawing.Color.White;
            this.txtRoomSearchID.Location = new System.Drawing.Point(643, 132);
            this.txtRoomSearchID.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomSearchID.MaxLength = 11;
            this.txtRoomSearchID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomSearchID.Name = "txtRoomSearchID";
            this.txtRoomSearchID.Size = new System.Drawing.Size(145, 22);
            this.txtRoomSearchID.TabIndex = 236;
            this.txtRoomSearchID.TextChanged += new System.EventHandler(this.txtRoomSearchID_TextChanged);
            this.txtRoomSearchID.Enter += new System.EventHandler(this.txtRoomSearchID_Enter);
            this.txtRoomSearchID.Leave += new System.EventHandler(this.txtRoomSearchID_Leave);
            // 
            // txtRoomSearchNumber
            // 
            this.txtRoomSearchNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtRoomSearchNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomSearchNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSearchNumber.ForeColor = System.Drawing.Color.White;
            this.txtRoomSearchNumber.Location = new System.Drawing.Point(393, 132);
            this.txtRoomSearchNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomSearchNumber.MaxLength = 11;
            this.txtRoomSearchNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomSearchNumber.Name = "txtRoomSearchNumber";
            this.txtRoomSearchNumber.Size = new System.Drawing.Size(195, 22);
            this.txtRoomSearchNumber.TabIndex = 235;
            this.txtRoomSearchNumber.TextChanged += new System.EventHandler(this.txtRoomSearchNumber_TextChanged);
            this.txtRoomSearchNumber.Enter += new System.EventHandler(this.txtRoomSearchNumber_Enter);
            this.txtRoomSearchNumber.Leave += new System.EventHandler(this.txtRoomSearchNumber_Leave);
            // 
            // lblConsProdCod
            // 
            this.lblConsProdCod.AutoSize = true;
            this.lblConsProdCod.BackColor = System.Drawing.Color.Transparent;
            this.lblConsProdCod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsProdCod.ForeColor = System.Drawing.Color.White;
            this.lblConsProdCod.Location = new System.Drawing.Point(635, 109);
            this.lblConsProdCod.Name = "lblConsProdCod";
            this.lblConsProdCod.Size = new System.Drawing.Size(23, 19);
            this.lblConsProdCod.TabIndex = 234;
            this.lblConsProdCod.Text = "ID";
            // 
            // lblSearchNumero
            // 
            this.lblSearchNumero.AutoSize = true;
            this.lblSearchNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchNumero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchNumero.ForeColor = System.Drawing.Color.White;
            this.lblSearchNumero.Location = new System.Drawing.Point(385, 110);
            this.lblSearchNumero.Name = "lblSearchNumero";
            this.lblSearchNumero.Size = new System.Drawing.Size(64, 19);
            this.lblSearchNumero.TabIndex = 233;
            this.lblSearchNumero.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(383, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 232;
            this.label2.Text = "Consultar";
            // 
            // btnRoomRegister
            // 
            this.btnRoomRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomRegister.FlatAppearance.BorderSize = 0;
            this.btnRoomRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnRoomRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomRegister.Image")));
            this.btnRoomRegister.Location = new System.Drawing.Point(58, 548);
            this.btnRoomRegister.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomRegister.Name = "btnRoomRegister";
            this.btnRoomRegister.Size = new System.Drawing.Size(189, 53);
            this.btnRoomRegister.TabIndex = 229;
            this.btnRoomRegister.Text = "Cadastrar";
            this.btnRoomRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomRegister.UseVisualStyleBackColor = false;
            this.btnRoomRegister.Click += new System.EventHandler(this.btnRoomRegister_Click);
            // 
            // btnRoomSelect
            // 
            this.btnRoomSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomSelect.FlatAppearance.BorderSize = 0;
            this.btnRoomSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnRoomSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomSelect.Image")));
            this.btnRoomSelect.Location = new System.Drawing.Point(898, 558);
            this.btnRoomSelect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomSelect.Name = "btnRoomSelect";
            this.btnRoomSelect.Size = new System.Drawing.Size(138, 47);
            this.btnRoomSelect.TabIndex = 231;
            this.btnRoomSelect.Text = "Selecionar";
            this.btnRoomSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomSelect.UseVisualStyleBackColor = false;
            this.btnRoomSelect.Click += new System.EventHandler(this.btnRoomSelect_Click);
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
            this.lblCadastrar.TabIndex = 224;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.White;
            this.lblRoomNumber.Location = new System.Drawing.Point(39, 110);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(64, 19);
            this.lblRoomNumber.TabIndex = 225;
            this.lblRoomNumber.Text = "Número";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumber.Location = new System.Drawing.Point(43, 132);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomNumber.MaxLength = 100;
            this.txtRoomNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(233, 22);
            this.txtRoomNumber.TabIndex = 226;
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomDelete.FlatAppearance.BorderSize = 0;
            this.btnRoomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnRoomDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomDelete.Image")));
            this.btnRoomDelete.Location = new System.Drawing.Point(748, 558);
            this.btnRoomDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(138, 47);
            this.btnRoomDelete.TabIndex = 230;
            this.btnRoomDelete.Text = "Excluir";
            this.btnRoomDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomDelete.UseVisualStyleBackColor = false;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // lblRoomFloor
            // 
            this.lblRoomFloor.AutoSize = true;
            this.lblRoomFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFloor.ForeColor = System.Drawing.Color.White;
            this.lblRoomFloor.Location = new System.Drawing.Point(39, 166);
            this.lblRoomFloor.Name = "lblRoomFloor";
            this.lblRoomFloor.Size = new System.Drawing.Size(50, 19);
            this.lblRoomFloor.TabIndex = 241;
            this.lblRoomFloor.Text = "Andar";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.White;
            this.lblRoomType.Location = new System.Drawing.Point(39, 222);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(109, 19);
            this.lblRoomType.TabIndex = 243;
            this.lblRoomType.Text = "Tipo de quarto";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(43, 245);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(233, 25);
            this.cmbRoomType.TabIndex = 244;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.White;
            this.lblRoomPrice.Location = new System.Drawing.Point(39, 278);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(91, 19);
            this.lblRoomPrice.TabIndex = 245;
            this.lblRoomPrice.Text = "Preço diária";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPrice.Location = new System.Drawing.Point(73, 301);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomPrice.MaxLength = 100;
            this.txtRoomPrice.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(203, 22);
            this.txtRoomPrice.TabIndex = 246;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 247;
            this.label1.Text = "R$";
            // 
            // pnlSearchNumber
            // 
            this.pnlSearchNumber.BackColor = System.Drawing.Color.White;
            this.pnlSearchNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSearchNumber.Location = new System.Drawing.Point(388, 153);
            this.pnlSearchNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchNumber.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSearchNumber.Name = "pnlSearchNumber";
            this.pnlSearchNumber.Size = new System.Drawing.Size(200, 1);
            this.pnlSearchNumber.TabIndex = 250;
            // 
            // pnlsearchID
            // 
            this.pnlsearchID.BackColor = System.Drawing.Color.White;
            this.pnlsearchID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlsearchID.Location = new System.Drawing.Point(639, 153);
            this.pnlsearchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlsearchID.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlsearchID.Name = "pnlsearchID";
            this.pnlsearchID.Size = new System.Drawing.Size(149, 1);
            this.pnlsearchID.TabIndex = 251;
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.White;
            this.lblCadID.Location = new System.Drawing.Point(196, 109);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(27, 19);
            this.lblCadID.TabIndex = 252;
            this.lblCadID.Text = "ID:";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(229, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 253;
            // 
            // cmbFloor
            // 
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(43, 188);
            this.cmbFloor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(233, 25);
            this.cmbFloor.TabIndex = 256;
            // 
            // picRoomRefresh
            // 
            this.picRoomRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picRoomRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoomRefresh.BackgroundImage")));
            this.picRoomRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRoomRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomRefresh.Location = new System.Drawing.Point(1045, 563);
            this.picRoomRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picRoomRefresh.Name = "picRoomRefresh";
            this.picRoomRefresh.Size = new System.Drawing.Size(42, 38);
            this.picRoomRefresh.TabIndex = 262;
            this.picRoomRefresh.TabStop = false;
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
            this.lblDot1.TabIndex = 264;
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
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 263;
            this.label3.Text = "Quartos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(853, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 265;
            this.label6.Text = "Status";
            // 
            // cmbRoomStatus
            // 
            this.cmbRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomStatus.FormattingEnabled = true;
            this.cmbRoomStatus.Location = new System.Drawing.Point(857, 132);
            this.cmbRoomStatus.Name = "cmbRoomStatus";
            this.cmbRoomStatus.Size = new System.Drawing.Size(121, 25);
            this.cmbRoomStatus.TabIndex = 266;
            this.cmbRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cmbRoomStatus_SelectedIndexChanged);
            // 
            // FormRegisterRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1141, 650);
            this.Controls.Add(this.cmbRoomStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picRoomRefresh);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.pnlsearchID);
            this.Controls.Add(this.pnlSearchNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomFloor);
            this.Controls.Add(this.btnRoomClear);
            this.Controls.Add(this.lblConsFornCadastrados);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.txtRoomSearchID);
            this.Controls.Add(this.txtRoomSearchNumber);
            this.Controls.Add(this.lblConsProdCod);
            this.Controls.Add(this.lblSearchNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRoomRegister);
            this.Controls.Add(this.btnRoomSelect);
            this.Controls.Add(this.lblCadastrar);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.btnRoomDelete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterRoom";
            this.Load += new System.EventHandler(this.FormRegisterRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoomClear;
        private System.Windows.Forms.Label lblConsFornCadastrados;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.TextBox txtRoomSearchID;
        private System.Windows.Forms.TextBox txtRoomSearchNumber;
        private System.Windows.Forms.Label lblConsProdCod;
        private System.Windows.Forms.Label lblSearchNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRoomRegister;
        private System.Windows.Forms.Button btnRoomSelect;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Label lblRoomFloor;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearchNumber;
        private System.Windows.Forms.Panel pnlsearchID;
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.PictureBox picRoomRefresh;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRoomStatus;
    }
}