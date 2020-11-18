namespace PresentationLayer
{
    partial class FormReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservation));
            this.lblDot1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReservationRegister = new System.Windows.Forms.Button();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomFloor = new System.Windows.Forms.Label();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblClientCpf = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeachReservation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lblDot1.TabIndex = 323;
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
            this.label12.Size = new System.Drawing.Size(96, 28);
            this.label12.TabIndex = 322;
            this.label12.Text = "Reservas";
            // 
            // btnReservationRegister
            // 
            this.btnReservationRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnReservationRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservationRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnReservationRegister.FlatAppearance.BorderSize = 0;
            this.btnReservationRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnReservationRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationRegister.Image")));
            this.btnReservationRegister.Location = new System.Drawing.Point(127, 449);
            this.btnReservationRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReservationRegister.Name = "btnReservationRegister";
            this.btnReservationRegister.Size = new System.Drawing.Size(189, 53);
            this.btnReservationRegister.TabIndex = 321;
            this.btnReservationRegister.Text = "Cadastrar";
            this.btnReservationRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservationRegister.UseVisualStyleBackColor = false;
            this.btnReservationRegister.Click += new System.EventHandler(this.btnReservationRegister_Click);
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectRoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSelectRoom.FlatAppearance.BorderSize = 0;
            this.btnSelectRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSelectRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectRoom.Image")));
            this.btnSelectRoom.Location = new System.Drawing.Point(632, 75);
            this.btnSelectRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(186, 35);
            this.btnSelectRoom.TabIndex = 316;
            this.btnSelectRoom.Text = "Selecionar Quarto";
            this.btnSelectRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectRoom.UseVisualStyleBackColor = false;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblRoom.Location = new System.Drawing.Point(483, 81);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(67, 21);
            this.lblRoom.TabIndex = 315;
            this.lblRoom.Text = "Quarto:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.White;
            this.lblRoomNumber.Location = new System.Drawing.Point(485, 120);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(72, 19);
            this.lblRoomNumber.TabIndex = 314;
            this.lblRoomNumber.Text = "Número: ";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.White;
            this.lblRoomPrice.Location = new System.Drawing.Point(485, 211);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(95, 19);
            this.lblRoomPrice.TabIndex = 311;
            this.lblRoomPrice.Text = "Preço diária:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.White;
            this.lblRoomType.Location = new System.Drawing.Point(485, 181);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(114, 19);
            this.lblRoomType.TabIndex = 310;
            this.lblRoomType.Text = "Tipo do quarto:";
            // 
            // lblRoomFloor
            // 
            this.lblRoomFloor.AutoSize = true;
            this.lblRoomFloor.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomFloor.ForeColor = System.Drawing.Color.White;
            this.lblRoomFloor.Location = new System.Drawing.Point(485, 151);
            this.lblRoomFloor.Name = "lblRoomFloor";
            this.lblRoomFloor.Size = new System.Drawing.Size(55, 19);
            this.lblRoomFloor.TabIndex = 309;
            this.lblRoomFloor.Text = "Andar:";
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSelectClient.FlatAppearance.BorderSize = 0;
            this.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectClient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSelectClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectClient.Image")));
            this.btnSelectClient.Location = new System.Drawing.Point(187, 75);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(185, 35);
            this.btnSelectClient.TabIndex = 307;
            this.btnSelectClient.Text = "Selecionar Cliente";
            this.btnSelectClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectClient.UseVisualStyleBackColor = false;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblClient.Location = new System.Drawing.Point(38, 81);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(68, 21);
            this.lblClient.TabIndex = 306;
            this.lblClient.Text = "Cliente:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(482, 380);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 36);
            this.btnClear.TabIndex = 301;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblClientEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEmail.ForeColor = System.Drawing.Color.White;
            this.lblClientEmail.Location = new System.Drawing.Point(40, 212);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(55, 19);
            this.lblClientEmail.TabIndex = 305;
            this.lblClientEmail.Text = "E-mail:";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblClientPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhone.ForeColor = System.Drawing.Color.White;
            this.lblClientPhone.Location = new System.Drawing.Point(40, 182);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(70, 19);
            this.lblClientPhone.TabIndex = 304;
            this.lblClientPhone.Text = "Telefone:";
            // 
            // lblClientCpf
            // 
            this.lblClientCpf.AutoSize = true;
            this.lblClientCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblClientCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCpf.ForeColor = System.Drawing.Color.White;
            this.lblClientCpf.Location = new System.Drawing.Point(40, 152);
            this.lblClientCpf.Name = "lblClientCpf";
            this.lblClientCpf.Size = new System.Drawing.Size(38, 19);
            this.lblClientCpf.TabIndex = 303;
            this.lblClientCpf.Text = "CPF:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(40, 122);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(58, 19);
            this.lblClientName.TabIndex = 302;
            this.lblClientName.Text = "Nome: ";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Location = new System.Drawing.Point(45, 383);
            this.dtCheckOut.MinDate = new System.DateTime(2020, 11, 18, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(389, 25);
            this.dtCheckOut.TabIndex = 327;
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Enabled = false;
            this.dtCheckIn.Location = new System.Drawing.Point(45, 306);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(389, 25);
            this.dtCheckIn.TabIndex = 326;
            this.dtCheckIn.Value = new System.DateTime(2020, 11, 18, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 21);
            this.label10.TabIndex = 325;
            this.label10.Text = "Data de Saída:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 324;
            this.label4.Text = "Data de Entrada:";
            // 
            // btnSeachReservation
            // 
            this.btnSeachReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnSeachReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeachReservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSeachReservation.FlatAppearance.BorderSize = 0;
            this.btnSeachReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeachReservation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeachReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.btnSeachReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnSeachReservation.Image")));
            this.btnSeachReservation.Location = new System.Drawing.Point(553, 449);
            this.btnSeachReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeachReservation.Name = "btnSeachReservation";
            this.btnSeachReservation.Size = new System.Drawing.Size(189, 53);
            this.btnSeachReservation.TabIndex = 328;
            this.btnSeachReservation.Text = "Selecionar Reservas";
            this.btnSeachReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeachReservation.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(322, 449);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 53);
            this.btnDelete.TabIndex = 329;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1141, 650);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSeachReservation);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReservationRegister);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomFloor);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblClientEmail);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.lblClientCpf);
            this.Controls.Add(this.lblClientName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReservation";
            this.Text = "FomReservation";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReservationRegister;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomFloor;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblClientCpf;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSeachReservation;
        private System.Windows.Forms.Button btnDelete;
    }
}