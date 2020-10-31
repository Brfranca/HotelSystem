﻿namespace PresentationLayer
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlEmployeeTopBar = new System.Windows.Forms.Panel();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picLoginClose = new System.Windows.Forms.PictureBox();
            this.lblAttencion = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picAttencion = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnlEmployeeTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlUser.Location = new System.Drawing.Point(87, 132);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(208, 1);
            this.pnlUser.TabIndex = 36;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(52, 247);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(247, 53);
            this.btnLogin.TabIndex = 40;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.chkShowPassword.FlatAppearance.BorderSize = 2;
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkShowPassword.Location = new System.Drawing.Point(109, 201);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(143, 27);
            this.chkShowPassword.TabIndex = 39;
            this.chkShowPassword.Text = "Mostrar Senha";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(89, 108);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtUser.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(202, 27);
            this.txtUser.TabIndex = 35;
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // pnlEmployeeTopBar
            // 
            this.pnlEmployeeTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(85)))), ((int)(((byte)(77)))));
            this.pnlEmployeeTopBar.Controls.Add(this.picIcone);
            this.pnlEmployeeTopBar.Controls.Add(this.label5);
            this.pnlEmployeeTopBar.Controls.Add(this.picLoginClose);
            this.pnlEmployeeTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlEmployeeTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployeeTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeTopBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEmployeeTopBar.Name = "pnlEmployeeTopBar";
            this.pnlEmployeeTopBar.Size = new System.Drawing.Size(350, 40);
            this.pnlEmployeeTopBar.TabIndex = 213;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hotel System";
            // 
            // picLoginClose
            // 
            this.picLoginClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoginClose.BackColor = System.Drawing.Color.Transparent;
            this.picLoginClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoginClose.BackgroundImage")));
            this.picLoginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLoginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoginClose.Location = new System.Drawing.Point(312, 8);
            this.picLoginClose.Margin = new System.Windows.Forms.Padding(0);
            this.picLoginClose.Name = "picLoginClose";
            this.picLoginClose.Size = new System.Drawing.Size(29, 24);
            this.picLoginClose.TabIndex = 7;
            this.picLoginClose.TabStop = false;
            this.picLoginClose.Click += new System.EventHandler(this.picLoginClose_Click);
            // 
            // lblAttencion
            // 
            this.lblAttencion.AutoSize = true;
            this.lblAttencion.BackColor = System.Drawing.Color.Transparent;
            this.lblAttencion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.lblAttencion.Location = new System.Drawing.Point(4, 83);
            this.lblAttencion.MinimumSize = new System.Drawing.Size(348, 0);
            this.lblAttencion.Name = "lblAttencion";
            this.lblAttencion.Size = new System.Drawing.Size(348, 23);
            this.lblAttencion.TabIndex = 216;
            this.lblAttencion.Text = "Dados incorretos";
            this.lblAttencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlPassword.Location = new System.Drawing.Point(88, 191);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(208, 1);
            this.pnlPassword.TabIndex = 219;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(90, 165);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 27);
            this.txtPassword.TabIndex = 218;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // picAttencion
            // 
            this.picAttencion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAttencion.BackColor = System.Drawing.Color.Transparent;
            this.picAttencion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAttencion.BackgroundImage")));
            this.picAttencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAttencion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picAttencion.Location = new System.Drawing.Point(161, 53);
            this.picAttencion.Margin = new System.Windows.Forms.Padding(0);
            this.picAttencion.Name = "picAttencion";
            this.picAttencion.Size = new System.Drawing.Size(26, 26);
            this.picAttencion.TabIndex = 222;
            this.picAttencion.TabStop = false;
            // 
            // picPassword
            // 
            this.picPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPassword.BackgroundImage")));
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picPassword.Location = new System.Drawing.Point(52, 156);
            this.picPassword.Margin = new System.Windows.Forms.Padding(0);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(29, 37);
            this.picPassword.TabIndex = 221;
            this.picPassword.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picUser.Location = new System.Drawing.Point(49, 106);
            this.picUser.Margin = new System.Windows.Forms.Padding(0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(33, 30);
            this.picUser.TabIndex = 220;
            this.picUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.picAttencion);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblAttencion);
            this.Controls.Add(this.pnlEmployeeTopBar);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtUser);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pnlEmployeeTopBar.ResumeLayout(false);
            this.pnlEmployeeTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlEmployeeTopBar;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picLoginClose;
        private System.Windows.Forms.Label lblAttencion;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picAttencion;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picUser;
    }
}
