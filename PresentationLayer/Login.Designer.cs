namespace PresentationLayer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.lblNomeFarmacia = new System.Windows.Forms.Label();
            this.picCloseButton = new System.Windows.Forms.PictureBox();
            this.lblAttencion = new System.Windows.Forms.Label();
            this.picAttencion = new System.Windows.Forms.PictureBox();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlTopBar.Controls.Add(this.picIcone);
            this.pnlTopBar.Controls.Add(this.lblNomeFarmacia);
            this.pnlTopBar.Controls.Add(this.picCloseButton);
            this.pnlTopBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(529, 40);
            this.pnlTopBar.TabIndex = 2;
            // 
            // picIcone
            // 
            this.picIcone.BackColor = System.Drawing.Color.Transparent;
            this.picIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picIcone.BackgroundImage")));
            this.picIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIcone.Location = new System.Drawing.Point(12, 12);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(16, 16);
            this.picIcone.TabIndex = 10;
            this.picIcone.TabStop = false;
            // 
            // lblNomeFarmacia
            // 
            this.lblNomeFarmacia.AutoSize = true;
            this.lblNomeFarmacia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNomeFarmacia.ForeColor = System.Drawing.Color.White;
            this.lblNomeFarmacia.Location = new System.Drawing.Point(34, 4);
            this.lblNomeFarmacia.Name = "lblNomeFarmacia";
            this.lblNomeFarmacia.Size = new System.Drawing.Size(127, 28);
            this.lblNomeFarmacia.TabIndex = 0;
            this.lblNomeFarmacia.Text = "Hotel System";
            // 
            // picCloseButton
            // 
            this.picCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.picCloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCloseButton.BackgroundImage")));
            this.picCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseButton.Location = new System.Drawing.Point(494, 7);
            this.picCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.picCloseButton.Name = "picCloseButton";
            this.picCloseButton.Size = new System.Drawing.Size(26, 26);
            this.picCloseButton.TabIndex = 7;
            this.picCloseButton.TabStop = false;
            this.picCloseButton.Click += new System.EventHandler(this.picCloseButton_Click);
            // 
            // lblAttencion
            // 
            this.lblAttencion.AutoSize = true;
            this.lblAttencion.BackColor = System.Drawing.Color.Transparent;
            this.lblAttencion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(34)))));
            this.lblAttencion.Location = new System.Drawing.Point(90, 71);
            this.lblAttencion.MinimumSize = new System.Drawing.Size(348, 0);
            this.lblAttencion.Name = "lblAttencion";
            this.lblAttencion.Size = new System.Drawing.Size(348, 23);
            this.lblAttencion.TabIndex = 34;
            this.lblAttencion.Text = "Dados incorretos";
            this.lblAttencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAttencion
            // 
            this.picAttencion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAttencion.BackColor = System.Drawing.Color.Transparent;
            this.picAttencion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAttencion.BackgroundImage")));
            this.picAttencion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAttencion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picAttencion.Location = new System.Drawing.Point(250, 42);
            this.picAttencion.Margin = new System.Windows.Forms.Padding(0);
            this.picAttencion.Name = "picAttencion";
            this.picAttencion.Size = new System.Drawing.Size(26, 26);
            this.picAttencion.TabIndex = 43;
            this.picAttencion.TabStop = false;
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlSenha.Location = new System.Drawing.Point(187, 180);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(185, 1);
            this.pnlSenha.TabIndex = 38;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(192, 156);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtSenha.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(180, 27);
            this.txtSenha.TabIndex = 37;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlUsuario.Location = new System.Drawing.Point(187, 123);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(185, 1);
            this.pnlUsuario.TabIndex = 36;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(150, 242);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(222, 53);
            this.btnLogin.TabIndex = 40;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkMostrarSenha
            // 
            this.chkMostrarSenha.AutoSize = true;
            this.chkMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrarSenha.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.chkMostrarSenha.FlatAppearance.BorderSize = 2;
            this.chkMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkMostrarSenha.Location = new System.Drawing.Point(192, 195);
            this.chkMostrarSenha.Name = "chkMostrarSenha";
            this.chkMostrarSenha.Size = new System.Drawing.Size(123, 21);
            this.chkMostrarSenha.TabIndex = 39;
            this.chkMostrarSenha.Text = "Mostrar Senha";
            this.chkMostrarSenha.UseVisualStyleBackColor = false;
            this.chkMostrarSenha.CheckedChanged += new System.EventHandler(this.chkMostrarSenha_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(192, 99);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsuario.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 27);
            this.txtUsuario.TabIndex = 35;
            // 
            // picSenha
            // 
            this.picSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSenha.BackColor = System.Drawing.Color.Transparent;
            this.picSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSenha.BackgroundImage")));
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picSenha.Location = new System.Drawing.Point(150, 157);
            this.picSenha.Margin = new System.Windows.Forms.Padding(0);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(26, 26);
            this.picSenha.TabIndex = 42;
            this.picSenha.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUsuario.BackgroundImage")));
            this.picUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picUsuario.Location = new System.Drawing.Point(150, 100);
            this.picUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(26, 26);
            this.picUsuario.TabIndex = 41;
            this.picUsuario.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(529, 329);
            this.Controls.Add(this.lblAttencion);
            this.Controls.Add(this.picAttencion);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkMostrarSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel System";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label lblNomeFarmacia;
        private System.Windows.Forms.PictureBox picCloseButton;
        private System.Windows.Forms.Label lblAttencion;
        private System.Windows.Forms.PictureBox picAttencion;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkMostrarSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.PictureBox picUsuario;
    }
}

