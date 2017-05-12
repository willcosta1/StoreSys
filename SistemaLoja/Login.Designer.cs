namespace SistemaLoja
{
    partial class frmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.mskCpfLogin = new System.Windows.Forms.MaskedTextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblDesenv = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(101, 43);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "  CPF";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(103, 87);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(50, 105);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(148, 22);
            this.txtSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(98, 146);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(55, 25);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // mskCpfLogin
            // 
            this.mskCpfLogin.Location = new System.Drawing.Point(50, 62);
            this.mskCpfLogin.Mask = "999\\.999\\.999\\-99";
            this.mskCpfLogin.Name = "mskCpfLogin";
            this.mskCpfLogin.PromptChar = ' ';
            this.mskCpfLogin.Size = new System.Drawing.Size(148, 22);
            this.mskCpfLogin.TabIndex = 0;
            this.mskCpfLogin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlLogin.Controls.Add(this.mskCpfLogin);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.lblSenha);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Location = new System.Drawing.Point(48, 44);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(247, 205);
            this.pnlLogin.TabIndex = 3;
            // 
            // lblDesenv
            // 
            this.lblDesenv.AutoSize = true;
            this.lblDesenv.BackColor = System.Drawing.Color.Yellow;
            this.lblDesenv.Location = new System.Drawing.Point(64, 267);
            this.lblDesenv.Name = "lblDesenv";
            this.lblDesenv.Size = new System.Drawing.Size(215, 16);
            this.lblDesenv.TabIndex = 4;
            this.lblDesenv.Text = "Desenvolvido por Willian da Costa";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(341, 292);
            this.Controls.Add(this.lblDesenv);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Loja - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.MaskedTextBox mskCpfLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblDesenv;
    }
}

