namespace PresentationLayer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnProduc = new System.Windows.Forms.Button();
            this.btnBegining = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.picMainClose = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlLeftBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlLeftBar.Controls.Add(this.label5);
            this.pnlLeftBar.Controls.Add(this.lblLogout);
            this.pnlLeftBar.Controls.Add(this.lblDateTime);
            this.pnlLeftBar.Controls.Add(this.btnIncome);
            this.pnlLeftBar.Controls.Add(this.btnEmployee);
            this.pnlLeftBar.Controls.Add(this.btnSupplier);
            this.pnlLeftBar.Controls.Add(this.btnRoom);
            this.pnlLeftBar.Controls.Add(this.btnProduc);
            this.pnlLeftBar.Controls.Add(this.btnBegining);
            this.pnlLeftBar.Controls.Add(this.lblEmployeeName);
            this.pnlLeftBar.Controls.Add(this.lblHello);
            this.pnlLeftBar.Controls.Add(this.lblClient);
            this.pnlLeftBar.Controls.Add(this.lblDot1);
            this.pnlLeftBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 40);
            this.pnlLeftBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftBar.MinimumSize = new System.Drawing.Size(80, 20);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(300, 548);
            this.pnlLeftBar.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(2, 520);
            this.label5.MinimumSize = new System.Drawing.Size(298, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Desenvolvido por Beatriz e Kátia • 2020";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblLogout.Location = new System.Drawing.Point(95, 474);
            this.lblLogout.MinimumSize = new System.Drawing.Size(114, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(114, 17);
            this.lblLogout.TabIndex = 21;
            this.lblLogout.Text = "Sair do Sistema";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(3, 435);
            this.lblDateTime.MinimumSize = new System.Drawing.Size(298, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(298, 17);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "<hora>";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(16, 301);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(197, 42);
            this.btnIncome.TabIndex = 28;
            this.btnIncome.Text = "Entrada de produtos";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            this.btnIncome.MouseLeave += new System.EventHandler(this.btnIncome_MouseLeave);
            this.btnIncome.MouseHover += new System.EventHandler(this.btnIncome_MouseHover);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(16, 221);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(197, 42);
            this.btnEmployee.TabIndex = 27;
            this.btnEmployee.Text = "Funcionários";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            this.btnEmployee.MouseLeave += new System.EventHandler(this.btnEmployee_MouseLeave);
            this.btnEmployee.MouseHover += new System.EventHandler(this.btnEmployee_MouseHover);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(16, 261);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(197, 42);
            this.btnSupplier.TabIndex = 26;
            this.btnSupplier.Text = "Fornecedores";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            this.btnSupplier.MouseLeave += new System.EventHandler(this.btnSupplier_MouseLeave);
            this.btnSupplier.MouseHover += new System.EventHandler(this.btnSupplier_MouseHover);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(16, 181);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(197, 42);
            this.btnRoom.TabIndex = 25;
            this.btnRoom.Text = "Quartos";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnRoom.MouseLeave += new System.EventHandler(this.btnRoom_MouseLeave);
            this.btnRoom.MouseHover += new System.EventHandler(this.btnRoom_MouseHover);
            // 
            // btnProduc
            // 
            this.btnProduc.BackColor = System.Drawing.Color.Transparent;
            this.btnProduc.FlatAppearance.BorderSize = 0;
            this.btnProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduc.ForeColor = System.Drawing.Color.White;
            this.btnProduc.Image = ((System.Drawing.Image)(resources.GetObject("btnProduc.Image")));
            this.btnProduc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduc.Location = new System.Drawing.Point(16, 141);
            this.btnProduc.Name = "btnProduc";
            this.btnProduc.Size = new System.Drawing.Size(197, 38);
            this.btnProduc.TabIndex = 24;
            this.btnProduc.Text = "Produtos";
            this.btnProduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduc.UseVisualStyleBackColor = false;
            this.btnProduc.Click += new System.EventHandler(this.btnProduc_Click);
            this.btnProduc.MouseLeave += new System.EventHandler(this.btnProduc_MouseLeave);
            this.btnProduc.MouseHover += new System.EventHandler(this.btnProduc_MouseHover);
            // 
            // btnBegining
            // 
            this.btnBegining.BackColor = System.Drawing.Color.Transparent;
            this.btnBegining.FlatAppearance.BorderSize = 0;
            this.btnBegining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegining.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegining.ForeColor = System.Drawing.Color.White;
            this.btnBegining.Image = ((System.Drawing.Image)(resources.GetObject("btnBegining.Image")));
            this.btnBegining.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBegining.Location = new System.Drawing.Point(16, 91);
            this.btnBegining.Name = "btnBegining";
            this.btnBegining.Size = new System.Drawing.Size(197, 42);
            this.btnBegining.TabIndex = 23;
            this.btnBegining.Text = "Início";
            this.btnBegining.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBegining.UseVisualStyleBackColor = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 27);
            this.lblEmployeeName.MaximumSize = new System.Drawing.Size(220, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(110, 20);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "<funcionario>";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.Silver;
            this.lblHello.Location = new System.Drawing.Point(12, 8);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(39, 20);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Olá,";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(49, 218);
            this.lblClient.MinimumSize = new System.Drawing.Size(80, 20);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(80, 20);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Clientes";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClient.Click += new System.EventHandler(this.lblClient_Click);
            this.lblClient.MouseLeave += new System.EventHandler(this.lblClient_MouseLeave);
            this.lblClient.MouseHover += new System.EventHandler(this.lblClient_MouseHover);
            // 
            // lblDot1
            // 
            this.lblDot1.AutoSize = true;
            this.lblDot1.BackColor = System.Drawing.Color.Transparent;
            this.lblDot1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDot1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.lblDot1.Location = new System.Drawing.Point(28, 219);
            this.lblDot1.MinimumSize = new System.Drawing.Size(5, 10);
            this.lblDot1.Name = "lblDot1";
            this.lblDot1.Size = new System.Drawing.Size(15, 19);
            this.lblDot1.TabIndex = 3;
            this.lblDot1.Text = "•";
            this.lblDot1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlTopBar.Controls.Add(this.picIcone);
            this.pnlTopBar.Controls.Add(this.lblNomeFarmacia);
            this.pnlTopBar.Controls.Add(this.picMainClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1272, 40);
            this.pnlTopBar.TabIndex = 2;
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(3, 8);
            this.picIcone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(32, 25);
            this.picIcone.TabIndex = 175;
            this.picIcone.TabStop = false;
            // 
            // lblNomeFarmacia
            // 
            this.lblNomeFarmacia.AutoSize = true;
            this.lblNomeFarmacia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeFarmacia.ForeColor = System.Drawing.Color.White;
            this.lblNomeFarmacia.Location = new System.Drawing.Point(34, 10);
            this.lblNomeFarmacia.Name = "lblNomeFarmacia";
            this.lblNomeFarmacia.Size = new System.Drawing.Size(102, 21);
            this.lblNomeFarmacia.TabIndex = 174;
            this.lblNomeFarmacia.Text = "Hotel System";
            // 
            // picMainClose
            // 
            this.picMainClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMainClose.BackColor = System.Drawing.Color.Transparent;
            this.picMainClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMainClose.BackgroundImage")));
            this.picMainClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMainClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMainClose.Location = new System.Drawing.Point(1233, 8);
            this.picMainClose.Margin = new System.Windows.Forms.Padding(0);
            this.picMainClose.Name = "picMainClose";
            this.picMainClose.Size = new System.Drawing.Size(29, 24);
            this.picMainClose.TabIndex = 173;
            this.picMainClose.TabStop = false;
            this.picMainClose.Click += new System.EventHandler(this.picMainClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(300, 40);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(972, 548);
            this.pnlDisplay.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1272, 588);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlLeftBar.ResumeLayout(false);
            this.pnlLeftBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picMainClose;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Button btnBegining;
        private System.Windows.Forms.Button btnProduc;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnIncome;
    }
}