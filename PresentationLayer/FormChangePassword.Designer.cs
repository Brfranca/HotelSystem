﻿namespace PresentationLayer
{
    partial class FormChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.pnlNewPassword2 = new System.Windows.Forms.Panel();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.pnlNewPassword1 = new System.Windows.Forms.Panel();
            this.txtNewPass1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.pnlActual = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEmployeeName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(48, 0);
            this.lblEmployeeName.MaximumSize = new System.Drawing.Size(220, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(137, 22);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "<funcionario>";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHello.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.Silver;
            this.lblHello.Location = new System.Drawing.Point(0, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(48, 22);
            this.lblHello.TabIndex = 2;
            this.lblHello.Text = "Olá,";
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPassword.BackgroundImage")));
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picPassword.Location = new System.Drawing.Point(165, 189);
            this.picPassword.Margin = new System.Windows.Forms.Padding(0);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(29, 37);
            this.picPassword.TabIndex = 231;
            this.picPassword.TabStop = false;
            // 
            // pnlNewPassword2
            // 
            this.pnlNewPassword2.BackColor = System.Drawing.Color.White;
            this.pnlNewPassword2.Location = new System.Drawing.Point(209, 221);
            this.pnlNewPassword2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNewPassword2.Name = "pnlNewPassword2";
            this.pnlNewPassword2.Size = new System.Drawing.Size(208, 1);
            this.pnlNewPassword2.TabIndex = 229;
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtNewPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass2.ForeColor = System.Drawing.Color.White;
            this.txtNewPass2.Location = new System.Drawing.Point(215, 195);
            this.txtNewPass2.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPass2.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(202, 27);
            this.txtNewPass2.TabIndex = 2;
            this.txtNewPass2.UseSystemPasswordChar = true;
            this.txtNewPass2.Enter += new System.EventHandler(this.txtNewPass2_Enter);
            this.txtNewPass2.Leave += new System.EventHandler(this.txtNewPass2_Leave);
            // 
            // pnlNewPassword1
            // 
            this.pnlNewPassword1.BackColor = System.Drawing.Color.White;
            this.pnlNewPassword1.Location = new System.Drawing.Point(209, 169);
            this.pnlNewPassword1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNewPassword1.Name = "pnlNewPassword1";
            this.pnlNewPassword1.Size = new System.Drawing.Size(208, 1);
            this.pnlNewPassword1.TabIndex = 224;
            // 
            // txtNewPass1
            // 
            this.txtNewPass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtNewPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass1.ForeColor = System.Drawing.Color.White;
            this.txtNewPass1.Location = new System.Drawing.Point(211, 145);
            this.txtNewPass1.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPass1.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.Size = new System.Drawing.Size(206, 27);
            this.txtNewPass1.TabIndex = 1;
            this.txtNewPass1.UseSystemPasswordChar = true;
            this.txtNewPass1.Enter += new System.EventHandler(this.txtNewPass1_Enter);
            this.txtNewPass1.Leave += new System.EventHandler(this.txtNewPass1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(165, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 37);
            this.pictureBox1.TabIndex = 232;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 234;
            this.label2.Text = "Senha nova: ";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(127)))), ((int)(((byte)(75)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(246)))), ((int)(((byte)(109)))));
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.Location = new System.Drawing.Point(160, 298);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(189, 53);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Alterar senha";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 233;
            this.label1.Text = "Senha atual:";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtCurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.White;
            this.txtCurrentPass.Location = new System.Drawing.Point(211, 73);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtCurrentPass.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(202, 27);
            this.txtCurrentPass.TabIndex = 0;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            this.txtCurrentPass.Enter += new System.EventHandler(this.txtCurrentPass_Enter);
            this.txtCurrentPass.Leave += new System.EventHandler(this.txtCurrentPass_Leave);
            // 
            // pnlActual
            // 
            this.pnlActual.BackColor = System.Drawing.Color.White;
            this.pnlActual.Location = new System.Drawing.Point(209, 99);
            this.pnlActual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlActual.Name = "pnlActual";
            this.pnlActual.Size = new System.Drawing.Size(208, 1);
            this.pnlActual.TabIndex = 231;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Location = new System.Drawing.Point(165, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 37);
            this.pictureBox2.TabIndex = 236;
            this.pictureBox2.TabStop = false;
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlActual);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.pnlNewPassword2);
            this.Controls.Add(this.txtNewPass2);
            this.Controls.Add(this.pnlNewPassword1);
            this.Controls.Add(this.txtNewPass1);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblHello);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Panel pnlNewPassword2;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Panel pnlNewPassword1;
        private System.Windows.Forms.TextBox txtNewPass1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Panel pnlActual;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}