namespace PresentationLayer
{
    partial class FormCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckIn));
            this.lblID = new System.Windows.Forms.Label();
            this.btnClientClear = new System.Windows.Forms.Button();
            this.lblCadID = new System.Windows.Forms.Label();
            this.txtClientCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblCadCliEmail = new System.Windows.Forms.Label();
            this.txtClientPhone1 = new System.Windows.Forms.TextBox();
            this.lblCadCliTel1 = new System.Windows.Forms.Label();
            this.lblCadCliCpf = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblCadCliNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecSupp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomFloor = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClientRegister = new System.Windows.Forms.Button();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.lblID.Location = new System.Drawing.Point(309, 117);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 209;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClientClear
            // 
            this.btnClientClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClientClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClientClear.FlatAppearance.BorderSize = 0;
            this.btnClientClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnClientClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClientClear.Image")));
            this.btnClientClear.Location = new System.Drawing.Point(43, 285);
            this.btnClientClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientClear.Name = "btnClientClear";
            this.btnClientClear.Size = new System.Drawing.Size(98, 36);
            this.btnClientClear.TabIndex = 200;
            this.btnClientClear.Text = "Limpar";
            this.btnClientClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientClear.UseVisualStyleBackColor = false;
            // 
            // lblCadID
            // 
            this.lblCadID.AutoSize = true;
            this.lblCadID.BackColor = System.Drawing.Color.Transparent;
            this.lblCadID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadID.ForeColor = System.Drawing.Color.White;
            this.lblCadID.Location = new System.Drawing.Point(117, 86);
            this.lblCadID.Name = "lblCadID";
            this.lblCadID.Size = new System.Drawing.Size(50, 23);
            this.lblCadID.TabIndex = 207;
            this.lblCadID.Text = "<id>";
            this.lblCadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClientCPF
            // 
            this.txtClientCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.txtClientCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientCPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClientCPF.Location = new System.Drawing.Point(44, 196);
            this.txtClientCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientCPF.Mask = "000,000,000-00";
            this.txtClientCPF.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientCPF.Name = "txtClientCPF";
            this.txtClientCPF.Size = new System.Drawing.Size(144, 27);
            this.txtClientCPF.TabIndex = 195;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.txtClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEmail.ForeColor = System.Drawing.Color.Black;
            this.txtClientEmail.Location = new System.Drawing.Point(44, 254);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientEmail.MaxLength = 200;
            this.txtClientEmail.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(303, 27);
            this.txtClientEmail.TabIndex = 199;
            // 
            // lblCadCliEmail
            // 
            this.lblCadCliEmail.AutoSize = true;
            this.lblCadCliEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliEmail.ForeColor = System.Drawing.Color.White;
            this.lblCadCliEmail.Location = new System.Drawing.Point(40, 231);
            this.lblCadCliEmail.Name = "lblCadCliEmail";
            this.lblCadCliEmail.Size = new System.Drawing.Size(61, 23);
            this.lblCadCliEmail.TabIndex = 208;
            this.lblCadCliEmail.Text = "E-mail";
            // 
            // txtClientPhone1
            // 
            this.txtClientPhone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
            this.txtClientPhone1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone1.ForeColor = System.Drawing.Color.Black;
            this.txtClientPhone1.Location = new System.Drawing.Point(203, 196);
            this.txtClientPhone1.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientPhone1.MaxLength = 11;
            this.txtClientPhone1.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientPhone1.Name = "txtClientPhone1";
            this.txtClientPhone1.Size = new System.Drawing.Size(144, 27);
            this.txtClientPhone1.TabIndex = 197;
            // 
            // lblCadCliTel1
            // 
            this.lblCadCliTel1.AutoSize = true;
            this.lblCadCliTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliTel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliTel1.ForeColor = System.Drawing.Color.White;
            this.lblCadCliTel1.Location = new System.Drawing.Point(199, 173);
            this.lblCadCliTel1.Name = "lblCadCliTel1";
            this.lblCadCliTel1.Size = new System.Drawing.Size(77, 23);
            this.lblCadCliTel1.TabIndex = 205;
            this.lblCadCliTel1.Text = "Telefone";
            // 
            // lblCadCliCpf
            // 
            this.lblCadCliCpf.AutoSize = true;
            this.lblCadCliCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliCpf.ForeColor = System.Drawing.Color.White;
            this.lblCadCliCpf.Location = new System.Drawing.Point(40, 174);
            this.lblCadCliCpf.Name = "lblCadCliCpf";
            this.lblCadCliCpf.Size = new System.Drawing.Size(40, 23);
            this.lblCadCliCpf.TabIndex = 203;
            this.lblCadCliCpf.Text = "CPF";
            // 
            // txtClientName
            // 
            this.txtClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.Black;
            this.txtClientName.Location = new System.Drawing.Point(44, 140);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(0);
            this.txtClientName.MaxLength = 100;
            this.txtClientName.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(303, 27);
            this.txtClientName.TabIndex = 194;
            // 
            // lblCadCliNome
            // 
            this.lblCadCliNome.AutoSize = true;
            this.lblCadCliNome.BackColor = System.Drawing.Color.Transparent;
            this.lblCadCliNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliNome.ForeColor = System.Drawing.Color.White;
            this.lblCadCliNome.Location = new System.Drawing.Point(40, 118);
            this.lblCadCliNome.Name = "lblCadCliNome";
            this.lblCadCliNome.Size = new System.Drawing.Size(58, 23);
            this.lblCadCliNome.TabIndex = 202;
            this.lblCadCliNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 210;
            this.label1.Text = "Cliente:";
            // 
            // btnSelecSupp
            // 
            this.btnSelecSupp.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecSupp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSelecSupp.FlatAppearance.BorderSize = 0;
            this.btnSelecSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecSupp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSelecSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecSupp.Image")));
            this.btnSelecSupp.Location = new System.Drawing.Point(178, 81);
            this.btnSelecSupp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecSupp.Name = "btnSelecSupp";
            this.btnSelecSupp.Size = new System.Drawing.Size(169, 35);
            this.btnSelecSupp.TabIndex = 231;
            this.btnSelecSupp.Text = "Selecionar Cliente";
            this.btnSelecSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecSupp.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(667, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 265;
            this.label3.Text = "R$";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.txtRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPrice.Location = new System.Drawing.Point(701, 206);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomPrice.MaxLength = 100;
            this.txtRoomPrice.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(114, 27);
            this.txtRoomPrice.TabIndex = 264;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.White;
            this.lblRoomPrice.Location = new System.Drawing.Point(667, 183);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(105, 23);
            this.lblRoomPrice.TabIndex = 263;
            this.lblRoomPrice.Text = "Preço diária";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.White;
            this.lblRoomType.Location = new System.Drawing.Point(508, 183);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(130, 23);
            this.lblRoomType.TabIndex = 261;
            this.lblRoomType.Text = "Tipo de quarto";
            // 
            // lblRoomFloor
            // 
            this.lblRoomFloor.AutoSize = true;
            this.lblRoomFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFloor.ForeColor = System.Drawing.Color.White;
            this.lblRoomFloor.Location = new System.Drawing.Point(667, 125);
            this.lblRoomFloor.Name = "lblRoomFloor";
            this.lblRoomFloor.Size = new System.Drawing.Size(59, 23);
            this.lblRoomFloor.TabIndex = 260;
            this.lblRoomFloor.Text = "Andar";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumber.Location = new System.Drawing.Point(512, 147);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtRoomNumber.MaxLength = 100;
            this.txtRoomNumber.MinimumSize = new System.Drawing.Size(0, 24);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(144, 27);
            this.txtRoomNumber.TabIndex = 259;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(646, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 35);
            this.button1.TabIndex = 274;
            this.button1.Text = "Selecionar Quarto";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(506, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 273;
            this.label5.Text = "Quarto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(508, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 270;
            this.label8.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(585, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 275;
            this.label2.Text = "<id>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(671, 147);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 100;
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 27);
            this.textBox1.TabIndex = 276;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(511, 206);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.MaxLength = 100;
            this.textBox2.MinimumSize = new System.Drawing.Size(0, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 27);
            this.textBox2.TabIndex = 277;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 281;
            this.label4.Text = "Data de Entrada:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 28);
            this.label10.TabIndex = 288;
            this.label10.Text = "Data de Saída:";
            // 
            // btnClientRegister
            // 
            this.btnClientRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnClientRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnClientRegister.FlatAppearance.BorderSize = 0;
            this.btnClientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnClientRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnClientRegister.Image")));
            this.btnClientRegister.Location = new System.Drawing.Point(144, 521);
            this.btnClientRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientRegister.Name = "btnClientRegister";
            this.btnClientRegister.Size = new System.Drawing.Size(189, 53);
            this.btnClientRegister.TabIndex = 292;
            this.btnClientRegister.Text = "Cadastrar";
            this.btnClientRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientRegister.UseVisualStyleBackColor = false;
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
            this.lblDot1.TabIndex = 294;
            this.lblDot1.Text = "•";
            this.lblDot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.label12.Location = new System.Drawing.Point(37, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 35);
            this.label12.TabIndex = 293;
            this.label12.Text = "Check In";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(389, 30);
            this.dateTimePicker1.TabIndex = 295;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(45, 462);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(389, 30);
            this.dateTimePicker2.TabIndex = 296;
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1141, 650);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClientRegister);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomFloor);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.btnSelecSupp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnClientClear);
            this.Controls.Add(this.lblCadID);
            this.Controls.Add(this.txtClientCPF);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.lblCadCliEmail);
            this.Controls.Add(this.txtClientPhone1);
            this.Controls.Add(this.lblCadCliTel1);
            this.Controls.Add(this.lblCadCliCpf);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblCadCliNome);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCheckIn";
            this.Text = "FormCheckIn";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClientClear;
        private System.Windows.Forms.Label lblCadID;
        private System.Windows.Forms.MaskedTextBox txtClientCPF;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblCadCliEmail;
        private System.Windows.Forms.TextBox txtClientPhone1;
        private System.Windows.Forms.Label lblCadCliTel1;
        private System.Windows.Forms.Label lblCadCliCpf;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblCadCliNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecSupp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomFloor;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClientRegister;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}