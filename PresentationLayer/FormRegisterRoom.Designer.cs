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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterRoom));
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
            this.picRoomClose = new System.Windows.Forms.PictureBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.lblRoomFloor = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckAvailability = new System.Windows.Forms.CheckBox();
            this.pnlSearchNumber = new System.Windows.Forms.Panel();
            this.pnlsearchID = new System.Windows.Forms.Panel();
            this.lblCadID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.picRoomRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomClose)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoomClear
            // 
            this.btnRoomClear.BackColor = System.Drawing.Color.Transparent;
            this.btnRoomClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnRoomClear.FlatAppearance.BorderSize = 3;
            this.btnRoomClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnRoomClear.Location = new System.Drawing.Point(119, 375);
            this.btnRoomClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomClear.Name = "btnRoomClear";
            this.btnRoomClear.Size = new System.Drawing.Size(98, 36);
            this.btnRoomClear.TabIndex = 240;
            this.btnRoomClear.Text = "Limpar";
            this.btnRoomClear.UseVisualStyleBackColor = false;
            this.btnRoomClear.Click += new System.EventHandler(this.btnRoomClear_Click);
            // 
            // lblConsFornCadastrados
            // 
            this.lblConsFornCadastrados.AutoSize = true;
            this.lblConsFornCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsFornCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsFornCadastrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsFornCadastrados.Location = new System.Drawing.Point(260, 155);
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRooms.ColumnHeadersHeight = 29;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnFloor,
            this.ColumnPrice,
            this.ColumnRoomType,
            this.ColumnAvailability});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRooms.Location = new System.Drawing.Point(262, 176);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvRooms.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.ColumnAvailability.HeaderText = "Disponível";
            this.ColumnAvailability.MinimumWidth = 6;
            this.ColumnAvailability.Name = "ColumnAvailability";
            this.ColumnAvailability.ReadOnly = true;
            // 
            // txtRoomSearchID
            // 
            this.txtRoomSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtRoomSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomSearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSearchID.ForeColor = System.Drawing.Color.Black;
            this.txtRoomSearchID.Location = new System.Drawing.Point(573, 120);
            this.txtRoomSearchID.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomSearchID.MaxLength = 11;
            this.txtRoomSearchID.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomSearchID.Name = "txtRoomSearchID";
            this.txtRoomSearchID.Size = new System.Drawing.Size(120, 22);
            this.txtRoomSearchID.TabIndex = 236;
            this.txtRoomSearchID.Click += new System.EventHandler(this.txtRoomSearchID_Click);
            this.txtRoomSearchID.TextChanged += new System.EventHandler(this.txtRoomSearchID_TextChanged);
            this.txtRoomSearchID.Leave += new System.EventHandler(this.txtRoomSearchID_Leave);
            // 
            // txtRoomSearchNumber
            // 
            this.txtRoomSearchNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtRoomSearchNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomSearchNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomSearchNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRoomSearchNumber.Location = new System.Drawing.Point(266, 120);
            this.txtRoomSearchNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomSearchNumber.MaxLength = 11;
            this.txtRoomSearchNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomSearchNumber.Name = "txtRoomSearchNumber";
            this.txtRoomSearchNumber.Size = new System.Drawing.Size(301, 22);
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
            this.lblConsProdCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblConsProdCod.Location = new System.Drawing.Point(565, 97);
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
            this.lblSearchNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblSearchNumero.Location = new System.Drawing.Point(258, 98);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(256, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 232;
            this.label2.Text = "Consultar";
            // 
            // btnRoomRegister
            // 
            this.btnRoomRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomRegister.FlatAppearance.BorderSize = 3;
            this.btnRoomRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomRegister.ForeColor = System.Drawing.Color.White;
            this.btnRoomRegister.Location = new System.Drawing.Point(39, 536);
            this.btnRoomRegister.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomRegister.Name = "btnRoomRegister";
            this.btnRoomRegister.Size = new System.Drawing.Size(189, 53);
            this.btnRoomRegister.TabIndex = 229;
            this.btnRoomRegister.Text = "Cadastrar";
            this.btnRoomRegister.UseVisualStyleBackColor = false;
            this.btnRoomRegister.Click += new System.EventHandler(this.btnRoomRegister_Click);
            // 
            // btnRoomSelect
            // 
            this.btnRoomSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomSelect.FlatAppearance.BorderSize = 3;
            this.btnRoomSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSelect.ForeColor = System.Drawing.Color.White;
            this.btnRoomSelect.Location = new System.Drawing.Point(771, 546);
            this.btnRoomSelect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomSelect.Name = "btnRoomSelect";
            this.btnRoomSelect.Size = new System.Drawing.Size(138, 47);
            this.btnRoomSelect.TabIndex = 231;
            this.btnRoomSelect.Text = "Selecionar";
            this.btnRoomSelect.UseVisualStyleBackColor = false;
            this.btnRoomSelect.Click += new System.EventHandler(this.btnRoomSelect_Click);
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
            this.lblCadastrar.TabIndex = 224;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 98);
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
            this.txtRoomNumber.Location = new System.Drawing.Point(24, 120);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomNumber.MaxLength = 100;
            this.txtRoomNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(193, 22);
            this.txtRoomNumber.TabIndex = 226;
            // 
            // picRoomClose
            // 
            this.picRoomClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRoomClose.BackColor = System.Drawing.Color.Transparent;
            this.picRoomClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoomClose.BackgroundImage")));
            this.picRoomClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRoomClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomClose.Location = new System.Drawing.Point(949, 8);
            this.picRoomClose.Margin = new System.Windows.Forms.Padding(0);
            this.picRoomClose.Name = "picRoomClose";
            this.picRoomClose.Size = new System.Drawing.Size(29, 24);
            this.picRoomClose.TabIndex = 172;
            this.picRoomClose.TabStop = false;
            this.picRoomClose.Click += new System.EventHandler(this.picRoomClose_Click);
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
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(993, 40);
            this.pnlTopBar.TabIndex = 223;
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 8);
            this.picIcone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lblNomeFarmacia.Size = new System.Drawing.Size(66, 21);
            this.lblNomeFarmacia.TabIndex = 0;
            this.lblNomeFarmacia.Text = "Quartos";
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnRoomDelete.FlatAppearance.BorderSize = 3;
            this.btnRoomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDelete.ForeColor = System.Drawing.Color.White;
            this.btnRoomDelete.Location = new System.Drawing.Point(621, 546);
            this.btnRoomDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(138, 47);
            this.btnRoomDelete.TabIndex = 230;
            this.btnRoomDelete.Text = "Excluir";
            this.btnRoomDelete.UseVisualStyleBackColor = false;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // lblRoomFloor
            // 
            this.lblRoomFloor.AutoSize = true;
            this.lblRoomFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblRoomFloor.Location = new System.Drawing.Point(20, 154);
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
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblRoomType.Location = new System.Drawing.Point(20, 210);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(109, 19);
            this.lblRoomType.TabIndex = 243;
            this.lblRoomType.Text = "Tipo de quarto";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(24, 233);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(193, 25);
            this.cmbRoomType.TabIndex = 244;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblRoomPrice.Location = new System.Drawing.Point(20, 266);
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
            this.txtRoomPrice.Location = new System.Drawing.Point(54, 289);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomPrice.MaxLength = 100;
            this.txtRoomPrice.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(163, 22);
            this.txtRoomPrice.TabIndex = 246;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(20, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 247;
            this.label1.Text = "R$";
            // 
            // ckAvailability
            // 
            this.ckAvailability.AutoSize = true;
            this.ckAvailability.BackColor = System.Drawing.Color.Transparent;
            this.ckAvailability.Location = new System.Drawing.Point(24, 320);
            this.ckAvailability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckAvailability.Name = "ckAvailability";
            this.ckAvailability.Size = new System.Drawing.Size(91, 23);
            this.ckAvailability.TabIndex = 249;
            this.ckAvailability.Text = "Disponível";
            this.ckAvailability.UseVisualStyleBackColor = false;
            // 
            // pnlSearchNumber
            // 
            this.pnlSearchNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlSearchNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlSearchNumber.Location = new System.Drawing.Point(261, 141);
            this.pnlSearchNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchNumber.MaximumSize = new System.Drawing.Size(564, 1);
            this.pnlSearchNumber.Name = "pnlSearchNumber";
            this.pnlSearchNumber.Size = new System.Drawing.Size(270, 1);
            this.pnlSearchNumber.TabIndex = 250;
            // 
            // pnlsearchID
            // 
            this.pnlsearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlsearchID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlsearchID.Location = new System.Drawing.Point(569, 141);
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
            this.lblCadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblCadID.Location = new System.Drawing.Point(144, 97);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(27, 19);
            this.lblCadID.TabIndex = 252;
            this.lblCadID.Text = "ID:";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(293, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 253;
            // 
            // cmbFloor
            // 
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.FormattingEnabled = true;
            this.cmbFloor.Location = new System.Drawing.Point(24, 176);
            this.cmbFloor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(193, 25);
            this.cmbFloor.TabIndex = 256;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(746, 120);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 23);
            this.checkBox1.TabIndex = 258;
            this.checkBox1.Text = "Quartos disponíveis";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picRoomRefresh
            // 
            this.picRoomRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRoomRefresh.BackColor = System.Drawing.Color.Transparent;
            this.picRoomRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRoomRefresh.BackgroundImage")));
            this.picRoomRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRoomRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRoomRefresh.Location = new System.Drawing.Point(918, 551);
            this.picRoomRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picRoomRefresh.Name = "picRoomRefresh";
            this.picRoomRefresh.Size = new System.Drawing.Size(42, 38);
            this.picRoomRefresh.TabIndex = 262;
            this.picRoomRefresh.TabStop = false;
            // 
            // FormRegisterRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(993, 610);
            this.Controls.Add(this.picRoomRefresh);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.pnlsearchID);
            this.Controls.Add(this.pnlSearchNumber);
            this.Controls.Add(this.ckAvailability);
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
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.btnRoomDelete);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegisterRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterRoom";
            this.Load += new System.EventHandler(this.FormRegisterRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomClose)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
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
        private System.Windows.Forms.PictureBox picRoomClose;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Label lblRoomFloor;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckAvailability;
        private System.Windows.Forms.Panel pnlSearchNumber;
        private System.Windows.Forms.Panel pnlsearchID;
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailability;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox picRoomRefresh;
    }
}