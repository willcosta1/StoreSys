namespace SistemaLoja
{
    partial class frmCadastrar
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
            this.grpAdm = new System.Windows.Forms.GroupBox();
            this.btnVoltarA = new System.Windows.Forms.Button();
            this.btnSalvarA = new System.Windows.Forms.Button();
            this.txtSenhaA = new System.Windows.Forms.TextBox();
            this.txtNomeA = new System.Windows.Forms.TextBox();
            this.mskCpfA = new System.Windows.Forms.MaskedTextBox();
            this.lblSenhaA = new System.Windows.Forms.Label();
            this.lblCpfA = new System.Windows.Forms.Label();
            this.lblNomeA = new System.Windows.Forms.Label();
            this.grpVend = new System.Windows.Forms.GroupBox();
            this.btnVoltarV = new System.Windows.Forms.Button();
            this.btnSalvarV = new System.Windows.Forms.Button();
            this.txtSenhaV = new System.Windows.Forms.TextBox();
            this.txtNomeV = new System.Windows.Forms.TextBox();
            this.mskCpfV = new System.Windows.Forms.MaskedTextBox();
            this.lblSenhaV = new System.Windows.Forms.Label();
            this.lblCpfV = new System.Windows.Forms.Label();
            this.lblNomeV = new System.Windows.Forms.Label();
            this.grpCli = new System.Windows.Forms.GroupBox();
            this.mskTelC = new System.Windows.Forms.MaskedTextBox();
            this.lblSexoC = new System.Windows.Forms.Label();
            this.rdoFemC = new System.Windows.Forms.RadioButton();
            this.rdoMascC = new System.Windows.Forms.RadioButton();
            this.txtEndC = new System.Windows.Forms.TextBox();
            this.lblEndC = new System.Windows.Forms.Label();
            this.btnVoltarC = new System.Windows.Forms.Button();
            this.btnSalvarC = new System.Windows.Forms.Button();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.mskCpfC = new System.Windows.Forms.MaskedTextBox();
            this.lblTelC = new System.Windows.Forms.Label();
            this.lblCpfC = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.grpPro = new System.Windows.Forms.GroupBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.lblCodP = new System.Windows.Forms.Label();
            this.btnVoltarP = new System.Windows.Forms.Button();
            this.btnSalvarP = new System.Windows.Forms.Button();
            this.txtPrecoP = new System.Windows.Forms.TextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.lblPrecoP = new System.Windows.Forms.Label();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.grpAdm.SuspendLayout();
            this.grpVend.SuspendLayout();
            this.grpCli.SuspendLayout();
            this.grpPro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdm
            // 
            this.grpAdm.Controls.Add(this.btnVoltarA);
            this.grpAdm.Controls.Add(this.btnSalvarA);
            this.grpAdm.Controls.Add(this.txtSenhaA);
            this.grpAdm.Controls.Add(this.txtNomeA);
            this.grpAdm.Controls.Add(this.mskCpfA);
            this.grpAdm.Controls.Add(this.lblSenhaA);
            this.grpAdm.Controls.Add(this.lblCpfA);
            this.grpAdm.Controls.Add(this.lblNomeA);
            this.grpAdm.Location = new System.Drawing.Point(12, 12);
            this.grpAdm.Name = "grpAdm";
            this.grpAdm.Size = new System.Drawing.Size(307, 257);
            this.grpAdm.TabIndex = 0;
            this.grpAdm.TabStop = false;
            this.grpAdm.Text = "Cadastro de Administradores";
            this.grpAdm.Visible = false;
            // 
            // btnVoltarA
            // 
            this.btnVoltarA.Location = new System.Drawing.Point(64, 207);
            this.btnVoltarA.Name = "btnVoltarA";
            this.btnVoltarA.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarA.TabIndex = 3;
            this.btnVoltarA.Text = "Voltar";
            this.btnVoltarA.UseVisualStyleBackColor = true;
            this.btnVoltarA.Click += new System.EventHandler(this.btnVoltarA_Click);
            // 
            // btnSalvarA
            // 
            this.btnSalvarA.Location = new System.Drawing.Point(172, 207);
            this.btnSalvarA.Name = "btnSalvarA";
            this.btnSalvarA.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarA.TabIndex = 4;
            this.btnSalvarA.Text = "Salvar";
            this.btnSalvarA.UseVisualStyleBackColor = true;
            this.btnSalvarA.Click += new System.EventHandler(this.btnSalvarA_Click);
            // 
            // txtSenhaA
            // 
            this.txtSenhaA.Location = new System.Drawing.Point(64, 122);
            this.txtSenhaA.MaxLength = 12;
            this.txtSenhaA.Name = "txtSenhaA";
            this.txtSenhaA.Size = new System.Drawing.Size(183, 20);
            this.txtSenhaA.TabIndex = 2;
            // 
            // txtNomeA
            // 
            this.txtNomeA.Location = new System.Drawing.Point(64, 43);
            this.txtNomeA.MaxLength = 50;
            this.txtNomeA.Name = "txtNomeA";
            this.txtNomeA.Size = new System.Drawing.Size(184, 20);
            this.txtNomeA.TabIndex = 0;
            // 
            // mskCpfA
            // 
            this.mskCpfA.Location = new System.Drawing.Point(64, 83);
            this.mskCpfA.Mask = "999\\.999\\.999\\-99";
            this.mskCpfA.Name = "mskCpfA";
            this.mskCpfA.PromptChar = ' ';
            this.mskCpfA.Size = new System.Drawing.Size(184, 20);
            this.mskCpfA.TabIndex = 1;
            this.mskCpfA.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblSenhaA
            // 
            this.lblSenhaA.AutoSize = true;
            this.lblSenhaA.Location = new System.Drawing.Point(23, 125);
            this.lblSenhaA.Name = "lblSenhaA";
            this.lblSenhaA.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaA.TabIndex = 7;
            this.lblSenhaA.Text = "Senha";
            // 
            // lblCpfA
            // 
            this.lblCpfA.AutoSize = true;
            this.lblCpfA.Location = new System.Drawing.Point(23, 86);
            this.lblCpfA.Name = "lblCpfA";
            this.lblCpfA.Size = new System.Drawing.Size(27, 13);
            this.lblCpfA.TabIndex = 6;
            this.lblCpfA.Text = "CPF";
            // 
            // lblNomeA
            // 
            this.lblNomeA.AutoSize = true;
            this.lblNomeA.Location = new System.Drawing.Point(23, 46);
            this.lblNomeA.Name = "lblNomeA";
            this.lblNomeA.Size = new System.Drawing.Size(35, 13);
            this.lblNomeA.TabIndex = 5;
            this.lblNomeA.Text = "Nome";
            // 
            // grpVend
            // 
            this.grpVend.Controls.Add(this.btnVoltarV);
            this.grpVend.Controls.Add(this.btnSalvarV);
            this.grpVend.Controls.Add(this.txtSenhaV);
            this.grpVend.Controls.Add(this.txtNomeV);
            this.grpVend.Controls.Add(this.mskCpfV);
            this.grpVend.Controls.Add(this.lblSenhaV);
            this.grpVend.Controls.Add(this.lblCpfV);
            this.grpVend.Controls.Add(this.lblNomeV);
            this.grpVend.Location = new System.Drawing.Point(336, 12);
            this.grpVend.Name = "grpVend";
            this.grpVend.Size = new System.Drawing.Size(307, 257);
            this.grpVend.TabIndex = 1;
            this.grpVend.TabStop = false;
            this.grpVend.Text = "Cadastro de Vendedores";
            this.grpVend.Visible = false;
            // 
            // btnVoltarV
            // 
            this.btnVoltarV.Location = new System.Drawing.Point(64, 207);
            this.btnVoltarV.Name = "btnVoltarV";
            this.btnVoltarV.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarV.TabIndex = 3;
            this.btnVoltarV.Text = "Voltar";
            this.btnVoltarV.UseVisualStyleBackColor = true;
            this.btnVoltarV.Click += new System.EventHandler(this.btnVoltarV_Click);
            // 
            // btnSalvarV
            // 
            this.btnSalvarV.Location = new System.Drawing.Point(172, 207);
            this.btnSalvarV.Name = "btnSalvarV";
            this.btnSalvarV.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarV.TabIndex = 4;
            this.btnSalvarV.Text = "Salvar";
            this.btnSalvarV.UseVisualStyleBackColor = true;
            this.btnSalvarV.Click += new System.EventHandler(this.btnSalvarV_Click);
            // 
            // txtSenhaV
            // 
            this.txtSenhaV.Location = new System.Drawing.Point(64, 122);
            this.txtSenhaV.MaxLength = 12;
            this.txtSenhaV.Name = "txtSenhaV";
            this.txtSenhaV.Size = new System.Drawing.Size(183, 20);
            this.txtSenhaV.TabIndex = 2;
            // 
            // txtNomeV
            // 
            this.txtNomeV.Location = new System.Drawing.Point(64, 43);
            this.txtNomeV.MaxLength = 50;
            this.txtNomeV.Name = "txtNomeV";
            this.txtNomeV.Size = new System.Drawing.Size(184, 20);
            this.txtNomeV.TabIndex = 0;
            // 
            // mskCpfV
            // 
            this.mskCpfV.Location = new System.Drawing.Point(64, 83);
            this.mskCpfV.Mask = "999\\.999\\.999\\-99";
            this.mskCpfV.Name = "mskCpfV";
            this.mskCpfV.PromptChar = ' ';
            this.mskCpfV.Size = new System.Drawing.Size(184, 20);
            this.mskCpfV.TabIndex = 1;
            this.mskCpfV.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblSenhaV
            // 
            this.lblSenhaV.AutoSize = true;
            this.lblSenhaV.Location = new System.Drawing.Point(23, 125);
            this.lblSenhaV.Name = "lblSenhaV";
            this.lblSenhaV.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaV.TabIndex = 7;
            this.lblSenhaV.Text = "Senha";
            // 
            // lblCpfV
            // 
            this.lblCpfV.AutoSize = true;
            this.lblCpfV.Location = new System.Drawing.Point(23, 86);
            this.lblCpfV.Name = "lblCpfV";
            this.lblCpfV.Size = new System.Drawing.Size(27, 13);
            this.lblCpfV.TabIndex = 6;
            this.lblCpfV.Text = "CPF";
            // 
            // lblNomeV
            // 
            this.lblNomeV.AutoSize = true;
            this.lblNomeV.Location = new System.Drawing.Point(23, 46);
            this.lblNomeV.Name = "lblNomeV";
            this.lblNomeV.Size = new System.Drawing.Size(35, 13);
            this.lblNomeV.TabIndex = 5;
            this.lblNomeV.Text = "Nome";
            // 
            // grpCli
            // 
            this.grpCli.Controls.Add(this.mskTelC);
            this.grpCli.Controls.Add(this.lblSexoC);
            this.grpCli.Controls.Add(this.rdoFemC);
            this.grpCli.Controls.Add(this.rdoMascC);
            this.grpCli.Controls.Add(this.txtEndC);
            this.grpCli.Controls.Add(this.lblEndC);
            this.grpCli.Controls.Add(this.btnVoltarC);
            this.grpCli.Controls.Add(this.btnSalvarC);
            this.grpCli.Controls.Add(this.txtNomeC);
            this.grpCli.Controls.Add(this.mskCpfC);
            this.grpCli.Controls.Add(this.lblTelC);
            this.grpCli.Controls.Add(this.lblCpfC);
            this.grpCli.Controls.Add(this.lblNomeC);
            this.grpCli.Location = new System.Drawing.Point(12, 275);
            this.grpCli.Name = "grpCli";
            this.grpCli.Size = new System.Drawing.Size(307, 257);
            this.grpCli.TabIndex = 2;
            this.grpCli.TabStop = false;
            this.grpCli.Text = "Cadastro de Clientes";
            this.grpCli.Visible = false;
            // 
            // mskTelC
            // 
            this.mskTelC.Location = new System.Drawing.Point(78, 83);
            this.mskTelC.Mask = "(99)\\ 9999\\-9999";
            this.mskTelC.Name = "mskTelC";
            this.mskTelC.PromptChar = ' ';
            this.mskTelC.Size = new System.Drawing.Size(169, 20);
            this.mskTelC.TabIndex = 2;
            this.mskTelC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblSexoC
            // 
            this.lblSexoC.AutoSize = true;
            this.lblSexoC.Location = new System.Drawing.Point(41, 156);
            this.lblSexoC.Name = "lblSexoC";
            this.lblSexoC.Size = new System.Drawing.Size(31, 13);
            this.lblSexoC.TabIndex = 17;
            this.lblSexoC.Text = "Sexo";
            // 
            // rdoFemC
            // 
            this.rdoFemC.AutoSize = true;
            this.rdoFemC.Location = new System.Drawing.Point(163, 154);
            this.rdoFemC.Name = "rdoFemC";
            this.rdoFemC.Size = new System.Drawing.Size(67, 17);
            this.rdoFemC.TabIndex = 5;
            this.rdoFemC.TabStop = true;
            this.rdoFemC.Text = "Feminino";
            this.rdoFemC.UseVisualStyleBackColor = true;
            // 
            // rdoMascC
            // 
            this.rdoMascC.AutoSize = true;
            this.rdoMascC.Location = new System.Drawing.Point(78, 154);
            this.rdoMascC.Name = "rdoMascC";
            this.rdoMascC.Size = new System.Drawing.Size(73, 17);
            this.rdoMascC.TabIndex = 4;
            this.rdoMascC.TabStop = true;
            this.rdoMascC.Text = "Masculino";
            this.rdoMascC.UseVisualStyleBackColor = true;
            // 
            // txtEndC
            // 
            this.txtEndC.Location = new System.Drawing.Point(78, 119);
            this.txtEndC.MaxLength = 50;
            this.txtEndC.Name = "txtEndC";
            this.txtEndC.Size = new System.Drawing.Size(170, 20);
            this.txtEndC.TabIndex = 3;
            // 
            // lblEndC
            // 
            this.lblEndC.AutoSize = true;
            this.lblEndC.Location = new System.Drawing.Point(23, 119);
            this.lblEndC.Name = "lblEndC";
            this.lblEndC.Size = new System.Drawing.Size(53, 13);
            this.lblEndC.TabIndex = 13;
            this.lblEndC.Text = "Endereço";
            // 
            // btnVoltarC
            // 
            this.btnVoltarC.Location = new System.Drawing.Point(64, 207);
            this.btnVoltarC.Name = "btnVoltarC";
            this.btnVoltarC.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarC.TabIndex = 6;
            this.btnVoltarC.Text = "Voltar";
            this.btnVoltarC.UseVisualStyleBackColor = true;
            this.btnVoltarC.Click += new System.EventHandler(this.btnVoltarC_Click);
            // 
            // btnSalvarC
            // 
            this.btnSalvarC.Location = new System.Drawing.Point(172, 207);
            this.btnSalvarC.Name = "btnSalvarC";
            this.btnSalvarC.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarC.TabIndex = 7;
            this.btnSalvarC.Text = "Salvar";
            this.btnSalvarC.UseVisualStyleBackColor = true;
            this.btnSalvarC.Click += new System.EventHandler(this.btnSalvarC_Click);
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(58, 28);
            this.txtNomeC.MaxLength = 50;
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(190, 20);
            this.txtNomeC.TabIndex = 0;
            // 
            // mskCpfC
            // 
            this.mskCpfC.Location = new System.Drawing.Point(64, 57);
            this.mskCpfC.Mask = "999\\.999\\.999\\-99";
            this.mskCpfC.Name = "mskCpfC";
            this.mskCpfC.PromptChar = ' ';
            this.mskCpfC.Size = new System.Drawing.Size(184, 20);
            this.mskCpfC.TabIndex = 1;
            this.mskCpfC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Location = new System.Drawing.Point(24, 86);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(49, 13);
            this.lblTelC.TabIndex = 7;
            this.lblTelC.Text = "Telefone";
            // 
            // lblCpfC
            // 
            this.lblCpfC.AutoSize = true;
            this.lblCpfC.Location = new System.Drawing.Point(24, 57);
            this.lblCpfC.Name = "lblCpfC";
            this.lblCpfC.Size = new System.Drawing.Size(27, 13);
            this.lblCpfC.TabIndex = 6;
            this.lblCpfC.Text = "CPF";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Location = new System.Drawing.Point(23, 31);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(35, 13);
            this.lblNomeC.TabIndex = 5;
            this.lblNomeC.Text = "Nome";
            // 
            // grpPro
            // 
            this.grpPro.Controls.Add(this.txtEstoque);
            this.grpPro.Controls.Add(this.lblEstoque);
            this.grpPro.Controls.Add(this.txtCodP);
            this.grpPro.Controls.Add(this.lblCodP);
            this.grpPro.Controls.Add(this.btnVoltarP);
            this.grpPro.Controls.Add(this.btnSalvarP);
            this.grpPro.Controls.Add(this.txtPrecoP);
            this.grpPro.Controls.Add(this.txtNomeP);
            this.grpPro.Controls.Add(this.lblPrecoP);
            this.grpPro.Controls.Add(this.lblNomeP);
            this.grpPro.Location = new System.Drawing.Point(336, 274);
            this.grpPro.Name = "grpPro";
            this.grpPro.Size = new System.Drawing.Size(307, 257);
            this.grpPro.TabIndex = 3;
            this.grpPro.TabStop = false;
            this.grpPro.Text = "Cadastro de Produtos";
            this.grpPro.Visible = false;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(77, 109);
            this.txtEstoque.MaxLength = 6;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(62, 20);
            this.txtEstoque.TabIndex = 3;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(25, 112);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 15;
            this.lblEstoque.Text = "Estoque";
            // 
            // txtCodP
            // 
            this.txtCodP.Location = new System.Drawing.Point(63, 28);
            this.txtCodP.MaxLength = 15;
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.Size = new System.Drawing.Size(184, 20);
            this.txtCodP.TabIndex = 0;
            // 
            // lblCodP
            // 
            this.lblCodP.AutoSize = true;
            this.lblCodP.Location = new System.Drawing.Point(25, 31);
            this.lblCodP.Name = "lblCodP";
            this.lblCodP.Size = new System.Drawing.Size(40, 13);
            this.lblCodP.TabIndex = 13;
            this.lblCodP.Text = "Código";
            // 
            // btnVoltarP
            // 
            this.btnVoltarP.Location = new System.Drawing.Point(64, 207);
            this.btnVoltarP.Name = "btnVoltarP";
            this.btnVoltarP.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarP.TabIndex = 4;
            this.btnVoltarP.Text = "Voltar";
            this.btnVoltarP.UseVisualStyleBackColor = true;
            this.btnVoltarP.Click += new System.EventHandler(this.btnVoltarP_Click);
            // 
            // btnSalvarP
            // 
            this.btnSalvarP.Location = new System.Drawing.Point(172, 207);
            this.btnSalvarP.Name = "btnSalvarP";
            this.btnSalvarP.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarP.TabIndex = 5;
            this.btnSalvarP.Text = "Salvar";
            this.btnSalvarP.UseVisualStyleBackColor = true;
            this.btnSalvarP.Click += new System.EventHandler(this.btnSalvarP_Click);
            // 
            // txtPrecoP
            // 
            this.txtPrecoP.Location = new System.Drawing.Point(64, 83);
            this.txtPrecoP.MaxLength = 20;
            this.txtPrecoP.Name = "txtPrecoP";
            this.txtPrecoP.Size = new System.Drawing.Size(130, 20);
            this.txtPrecoP.TabIndex = 2;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(64, 54);
            this.txtNomeP.MaxLength = 50;
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(184, 20);
            this.txtNomeP.TabIndex = 1;
            // 
            // lblPrecoP
            // 
            this.lblPrecoP.AutoSize = true;
            this.lblPrecoP.Location = new System.Drawing.Point(26, 86);
            this.lblPrecoP.Name = "lblPrecoP";
            this.lblPrecoP.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoP.TabIndex = 7;
            this.lblPrecoP.Text = "Preço";
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(26, 57);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(35, 13);
            this.lblNomeP.TabIndex = 5;
            this.lblNomeP.Text = "Nome";
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 279);
            this.Controls.Add(this.grpVend);
            this.Controls.Add(this.grpCli);
            this.Controls.Add(this.grpAdm);
            this.Controls.Add(this.grpPro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.grpAdm.ResumeLayout(false);
            this.grpAdm.PerformLayout();
            this.grpVend.ResumeLayout(false);
            this.grpVend.PerformLayout();
            this.grpCli.ResumeLayout(false);
            this.grpCli.PerformLayout();
            this.grpPro.ResumeLayout(false);
            this.grpPro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdm;
        private System.Windows.Forms.Button btnSalvarA;
        private System.Windows.Forms.TextBox txtSenhaA;
        private System.Windows.Forms.TextBox txtNomeA;
        private System.Windows.Forms.MaskedTextBox mskCpfA;
        private System.Windows.Forms.Label lblSenhaA;
        private System.Windows.Forms.Label lblCpfA;
        private System.Windows.Forms.Label lblNomeA;
        private System.Windows.Forms.Button btnVoltarA;
        private System.Windows.Forms.GroupBox grpVend;
        private System.Windows.Forms.Button btnVoltarV;
        private System.Windows.Forms.Button btnSalvarV;
        private System.Windows.Forms.TextBox txtSenhaV;
        private System.Windows.Forms.TextBox txtNomeV;
        private System.Windows.Forms.MaskedTextBox mskCpfV;
        private System.Windows.Forms.Label lblSenhaV;
        private System.Windows.Forms.Label lblCpfV;
        private System.Windows.Forms.Label lblNomeV;
        private System.Windows.Forms.GroupBox grpCli;
        private System.Windows.Forms.Button btnVoltarC;
        private System.Windows.Forms.Button btnSalvarC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.MaskedTextBox mskCpfC;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.Label lblCpfC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.RadioButton rdoFemC;
        private System.Windows.Forms.RadioButton rdoMascC;
        private System.Windows.Forms.Label lblEndC;
        private System.Windows.Forms.GroupBox grpPro;
        private System.Windows.Forms.Button btnVoltarP;
        private System.Windows.Forms.Button btnSalvarP;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label lblPrecoP;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Label lblSexoC;
        private System.Windows.Forms.MaskedTextBox mskTelC;
        private System.Windows.Forms.TextBox txtEndC;
        private System.Windows.Forms.TextBox txtPrecoP;
        private System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.Label lblCodP;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
    }
}