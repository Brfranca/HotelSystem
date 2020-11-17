namespace PresentationLayer
{
    partial class FormCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckOut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.btnSelectCheckIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.lblConsFornCadastrados = new System.Windows.Forms.Label();
            this.btnSalesSelect = new System.Windows.Forms.Button();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Location = new System.Drawing.Point(50, 352);
            this.dtCheckOut.MinDate = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(261, 25);
            this.dtCheckOut.TabIndex = 325;
            // 
            // lblDot1
            // 
            this.lblDot1.AutoSize = true;
            this.lblDot1.BackColor = System.Drawing.Color.Transparent;
            this.lblDot1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDot1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblDot1.Location = new System.Drawing.Point(26, 17);
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
            this.label12.Location = new System.Drawing.Point(45, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 28);
            this.label12.TabIndex = 322;
            this.label12.Text = "Check Out";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.Location = new System.Drawing.Point(188, 520);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(189, 53);
            this.btnCheckOut.TabIndex = 321;
            this.btnCheckOut.Text = "Finalizar estadia";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(45, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 19);
            this.label10.TabIndex = 320;
            this.label10.Text = "Data de Saída:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(45, 202);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(72, 19);
            this.lblNumber.TabIndex = 314;
            this.lblNumber.Text = "Número: ";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.White;
            this.lblRoomPrice.Location = new System.Drawing.Point(45, 263);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(116, 19);
            this.lblRoomPrice.TabIndex = 311;
            this.lblRoomPrice.Text = "Preço diária: R$";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.White;
            this.lblRoomType.Location = new System.Drawing.Point(46, 230);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(117, 19);
            this.lblRoomType.TabIndex = 310;
            this.lblRoomType.Text = "Tipo de quarto: ";
            // 
            // btnSelectCheckIn
            // 
            this.btnSelectCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSelectCheckIn.FlatAppearance.BorderSize = 0;
            this.btnSelectCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCheckIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSelectCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCheckIn.Image")));
            this.btnSelectCheckIn.Location = new System.Drawing.Point(212, 71);
            this.btnSelectCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectCheckIn.Name = "btnSelectCheckIn";
            this.btnSelectCheckIn.Size = new System.Drawing.Size(185, 35);
            this.btnSelectCheckIn.TabIndex = 307;
            this.btnSelectCheckIn.Text = "Selecionar CheckIn";
            this.btnSelectCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectCheckIn.UseVisualStyleBackColor = false;
            this.btnSelectCheckIn.Click += new System.EventHandler(this.btnSelectCheckIn_Click);
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
            this.btnClear.Location = new System.Drawing.Point(12, 520);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 36);
            this.btnClear.TabIndex = 301;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(46, 173);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 19);
            this.lblPhone.TabIndex = 304;
            this.lblPhone.Text = "Telefone: ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(48, 138);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 19);
            this.lblCPF.TabIndex = 303;
            this.lblCPF.Text = "CPF: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(48, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 19);
            this.lblNome.TabIndex = 302;
            this.lblNome.Text = "Nome: ";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeColumns = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRooms.ColumnHeadersHeight = 29;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnFloor,
            this.ColumnPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRooms.Location = new System.Drawing.Point(453, 105);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.dgvRooms.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRooms.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(444, 381);
            this.dgvRooms.TabIndex = 326;
            // 
            // lblConsFornCadastrados
            // 
            this.lblConsFornCadastrados.AutoSize = true;
            this.lblConsFornCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblConsFornCadastrados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsFornCadastrados.ForeColor = System.Drawing.Color.White;
            this.lblConsFornCadastrados.Location = new System.Drawing.Point(449, 71);
            this.lblConsFornCadastrados.Name = "lblConsFornCadastrados";
            this.lblConsFornCadastrados.Size = new System.Drawing.Size(209, 19);
            this.lblConsFornCadastrados.TabIndex = 327;
            this.lblConsFornCadastrados.Text = "Serviços/produtos adquiridos";
            // 
            // btnSalesSelect
            // 
            this.btnSalesSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnSalesSelect.FlatAppearance.BorderSize = 0;
            this.btnSalesSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnSalesSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesSelect.Image")));
            this.btnSalesSelect.Location = new System.Drawing.Point(759, 496);
            this.btnSalesSelect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalesSelect.Name = "btnSalesSelect";
            this.btnSalesSelect.Size = new System.Drawing.Size(138, 47);
            this.btnSalesSelect.TabIndex = 328;
            this.btnSalesSelect.Text = "Selecionar";
            this.btnSalesSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesSelect.UseVisualStyleBackColor = false;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.FillWeight = 40F;
            this.ColumnNumber.HeaderText = "ID";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // ColumnFloor
            // 
            this.ColumnFloor.HeaderText = "Data";
            this.ColumnFloor.MinimumWidth = 6;
            this.ColumnFloor.Name = "ColumnFloor";
            this.ColumnFloor.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Valor total";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalValue.Location = new System.Drawing.Point(48, 409);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(106, 19);
            this.lblTotalValue.TabIndex = 329;
            this.lblTotalValue.Text = "Valor Total: R$";
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.btnSalesSelect);
            this.Controls.Add(this.lblConsFornCadastrados);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.btnSelectCheckIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Button btnSelectCheckIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblConsFornCadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Button btnSalesSelect;
        private System.Windows.Forms.Label lblTotalValue;
    }
}