namespace PresentationLayer
{
    partial class FormProdMain
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
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnCadIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.Transparent;
            this.btnCadProd.FlatAppearance.BorderSize = 0;
            this.btnCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.btnCadProd.Location = new System.Drawing.Point(201, 227);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(272, 138);
            this.btnCadProd.TabIndex = 0;
            this.btnCadProd.Text = "Cadastrar/pesquisar produto";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnCadIncome
            // 
            this.btnCadIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnCadIncome.FlatAppearance.BorderSize = 0;
            this.btnCadIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.btnCadIncome.Location = new System.Drawing.Point(627, 238);
            this.btnCadIncome.Name = "btnCadIncome";
            this.btnCadIncome.Size = new System.Drawing.Size(272, 138);
            this.btnCadIncome.TabIndex = 1;
            this.btnCadIncome.Text = "Cadastrar/pesquisar entrada de produto";
            this.btnCadIncome.UseVisualStyleBackColor = false;
            this.btnCadIncome.Click += new System.EventHandler(this.btnCadIncome_Click);
            // 
            // FormProdMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1141, 650);
            this.Controls.Add(this.btnCadIncome);
            this.Controls.Add(this.btnCadProd);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProdMain";
            this.Text = "FormProdMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnCadIncome;
    }
}