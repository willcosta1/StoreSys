namespace SistemaLoja
{
    partial class frmConsultar
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
            this.btnProcurarA = new System.Windows.Forms.Button();
            this.lblProcurarA = new System.Windows.Forms.Label();
            this.mskProcurarA = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltarA = new System.Windows.Forms.Button();
            this.txtSenhaA = new System.Windows.Forms.TextBox();
            this.txtNomeA = new System.Windows.Forms.TextBox();
            this.mskCpfA = new System.Windows.Forms.MaskedTextBox();
            this.lblSenhaA = new System.Windows.Forms.Label();
            this.lblCpfA = new System.Windows.Forms.Label();
            this.lblNomeA = new System.Windows.Forms.Label();
            this.grpPro = new System.Windows.Forms.GroupBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.btnProcurarP = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblProcurarP = new System.Windows.Forms.Label();
            this.txtProcurarP = new System.Windows.Forms.TextBox();
            this.txtCodP = new System.Windows.Forms.TextBox();
            this.lblCodP = new System.Windows.Forms.Label();
            this.btnVoltarP = new System.Windows.Forms.Button();
            this.txtPrecoP = new System.Windows.Forms.TextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.lblPrecoP = new System.Windows.Forms.Label();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.grpVend = new System.Windows.Forms.GroupBox();
            this.btnProcurarV = new System.Windows.Forms.Button();
            this.lblProcurarV = new System.Windows.Forms.Label();
            this.mskProcurarV = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltarV = new System.Windows.Forms.Button();
            this.txtSenhaV = new System.Windows.Forms.TextBox();
            this.txtNomeV = new System.Windows.Forms.TextBox();
            this.mskCpfV = new System.Windows.Forms.MaskedTextBox();
            this.lblSenhaV = new System.Windows.Forms.Label();
            this.lblCpfV = new System.Windows.Forms.Label();
            this.lblNomeV = new System.Windows.Forms.Label();
            this.grpCli = new System.Windows.Forms.GroupBox();
            this.btnProcurarC = new System.Windows.Forms.Button();
            this.lvlProcurarC = new System.Windows.Forms.Label();
            this.mskProcurarC = new System.Windows.Forms.MaskedTextBox();
            this.mskTelC = new System.Windows.Forms.MaskedTextBox();
            this.lblSexoC = new System.Windows.Forms.Label();
            this.rdoFemC = new System.Windows.Forms.RadioButton();
            this.rdoMascC = new System.Windows.Forms.RadioButton();
            this.txtEndC = new System.Windows.Forms.TextBox();
            this.lblEndC = new System.Windows.Forms.Label();
            this.btnVoltarC = new System.Windows.Forms.Button();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.mskCpfC = new System.Windows.Forms.MaskedTextBox();
            this.lblTelC = new System.Windows.Forms.Label();
            this.lblCpfC = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.grpAdm.SuspendLayout();
            this.grpPro.SuspendLayout();
            this.grpVend.SuspendLayout();
            this.grpCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdm
            // 
            this.grpAdm.Controls.Add(this.btnProcurarA);
            this.grpAdm.Controls.Add(this.lblProcurarA);
            this.grpAdm.Controls.Add(this.mskProcurarA);
            this.grpAdm.Controls.Add(this.btnVoltarA);
            this.grpAdm.Controls.Add(this.txtSenhaA);
            this.grpAdm.Controls.Add(this.txtNomeA);
            this.grpAdm.Controls.Add(this.mskCpfA);
            this.grpAdm.Controls.Add(this.lblSenhaA);
            this.grpAdm.Controls.Add(this.lblCpfA);
            this.grpAdm.Controls.Add(this.lblNomeA);
            this.grpAdm.Location = new System.Drawing.Point(12, 12);
            this.grpAdm.Name = "grpAdm";
            this.grpAdm.Size = new System.Drawing.Size(307, 257);
            this.grpAdm.TabIndex = 1;
            this.grpAdm.TabStop = false;
            this.grpAdm.Text = "Consulta de Administradores";
            this.grpAdm.Visible = false;
            // 
            // btnProcurarA
            // 
            this.btnProcurarA.Location = new System.Drawing.Point(186, 37);
            this.btnProcurarA.Name = "btnProcurarA";
            this.btnProcurarA.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarA.TabIndex = 1;
            this.btnProcurarA.Text = "Ir";
            this.btnProcurarA.UseVisualStyleBackColor = true;
            this.btnProcurarA.Click += new System.EventHandler(this.btnProcurarA_Click);
            // 
            // lblProcurarA
            // 
            this.lblProcurarA.AutoSize = true;
            this.lblProcurarA.Location = new System.Drawing.Point(13, 42);
            this.lblProcurarA.Name = "lblProcurarA";
            this.lblProcurarA.Size = new System.Drawing.Size(47, 13);
            this.lblProcurarA.TabIndex = 14;
            this.lblProcurarA.Text = "Procurar";
            // 
            // mskProcurarA
            // 
            this.mskProcurarA.Location = new System.Drawing.Point(62, 39);
            this.mskProcurarA.Mask = "999\\.999\\.999\\-99";
            this.mskProcurarA.Name = "mskProcurarA";
            this.mskProcurarA.PromptChar = ' ';
            this.mskProcurarA.Size = new System.Drawing.Size(118, 20);
            this.mskProcurarA.TabIndex = 0;
            this.mskProcurarA.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // btnVoltarA
            // 
            this.btnVoltarA.Location = new System.Drawing.Point(172, 207);
            this.btnVoltarA.Name = "btnVoltarA";
            this.btnVoltarA.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarA.TabIndex = 5;
            this.btnVoltarA.Text = "Voltar";
            this.btnVoltarA.UseVisualStyleBackColor = true;
            this.btnVoltarA.Click += new System.EventHandler(this.btnVoltarA_Click);
            // 
            // txtSenhaA
            // 
            this.txtSenhaA.Location = new System.Drawing.Point(63, 176);
            this.txtSenhaA.Name = "txtSenhaA";
            this.txtSenhaA.ReadOnly = true;
            this.txtSenhaA.Size = new System.Drawing.Size(183, 20);
            this.txtSenhaA.TabIndex = 4;
            this.txtSenhaA.TabStop = false;
            // 
            // txtNomeA
            // 
            this.txtNomeA.Location = new System.Drawing.Point(63, 97);
            this.txtNomeA.Name = "txtNomeA";
            this.txtNomeA.ReadOnly = true;
            this.txtNomeA.Size = new System.Drawing.Size(184, 20);
            this.txtNomeA.TabIndex = 2;
            this.txtNomeA.TabStop = false;
            // 
            // mskCpfA
            // 
            this.mskCpfA.Location = new System.Drawing.Point(63, 137);
            this.mskCpfA.Mask = "999\\.999\\.999\\-99";
            this.mskCpfA.Name = "mskCpfA";
            this.mskCpfA.PromptChar = ' ';
            this.mskCpfA.ReadOnly = true;
            this.mskCpfA.Size = new System.Drawing.Size(184, 20);
            this.mskCpfA.TabIndex = 3;
            this.mskCpfA.TabStop = false;
            this.mskCpfA.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblSenhaA
            // 
            this.lblSenhaA.AutoSize = true;
            this.lblSenhaA.Location = new System.Drawing.Point(22, 179);
            this.lblSenhaA.Name = "lblSenhaA";
            this.lblSenhaA.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaA.TabIndex = 7;
            this.lblSenhaA.Text = "Senha";
            // 
            // lblCpfA
            // 
            this.lblCpfA.AutoSize = true;
            this.lblCpfA.Location = new System.Drawing.Point(22, 140);
            this.lblCpfA.Name = "lblCpfA";
            this.lblCpfA.Size = new System.Drawing.Size(27, 13);
            this.lblCpfA.TabIndex = 6;
            this.lblCpfA.Text = "CPF";
            // 
            // lblNomeA
            // 
            this.lblNomeA.AutoSize = true;
            this.lblNomeA.Location = new System.Drawing.Point(22, 100);
            this.lblNomeA.Name = "lblNomeA";
            this.lblNomeA.Size = new System.Drawing.Size(35, 13);
            this.lblNomeA.TabIndex = 5;
            this.lblNomeA.Text = "Nome";
            // 
            // grpPro
            // 
            this.grpPro.Controls.Add(this.txtEstoque);
            this.grpPro.Controls.Add(this.btnProcurarP);
            this.grpPro.Controls.Add(this.lblEstoque);
            this.grpPro.Controls.Add(this.lblProcurarP);
            this.grpPro.Controls.Add(this.txtProcurarP);
            this.grpPro.Controls.Add(this.txtCodP);
            this.grpPro.Controls.Add(this.lblCodP);
            this.grpPro.Controls.Add(this.btnVoltarP);
            this.grpPro.Controls.Add(this.txtPrecoP);
            this.grpPro.Controls.Add(this.txtNomeP);
            this.grpPro.Controls.Add(this.lblPrecoP);
            this.grpPro.Controls.Add(this.lblNomeP);
            this.grpPro.Location = new System.Drawing.Point(325, 285);
            this.grpPro.Name = "grpPro";
            this.grpPro.Size = new System.Drawing.Size(307, 257);
            this.grpPro.TabIndex = 4;
            this.grpPro.TabStop = false;
            this.grpPro.Text = "Consulta de Produtos";
            this.grpPro.Visible = false;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(66, 177);
            this.txtEstoque.MaxLength = 6;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(62, 20);
            this.txtEstoque.TabIndex = 5;
            this.txtEstoque.TabStop = false;
            // 
            // btnProcurarP
            // 
            this.btnProcurarP.Location = new System.Drawing.Point(202, 32);
            this.btnProcurarP.Name = "btnProcurarP";
            this.btnProcurarP.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarP.TabIndex = 1;
            this.btnProcurarP.Text = "Ir";
            this.btnProcurarP.UseVisualStyleBackColor = true;
            this.btnProcurarP.Click += new System.EventHandler(this.btnProcurarP_Click);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(14, 180);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 17;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblProcurarP
            // 
            this.lblProcurarP.AutoSize = true;
            this.lblProcurarP.Location = new System.Drawing.Point(16, 37);
            this.lblProcurarP.Name = "lblProcurarP";
            this.lblProcurarP.Size = new System.Drawing.Size(47, 13);
            this.lblProcurarP.TabIndex = 16;
            this.lblProcurarP.Text = "Procurar";
            // 
            // txtProcurarP
            // 
            this.txtProcurarP.Location = new System.Drawing.Point(65, 34);
            this.txtProcurarP.MaxLength = 15;
            this.txtProcurarP.Name = "txtProcurarP";
            this.txtProcurarP.Size = new System.Drawing.Size(131, 20);
            this.txtProcurarP.TabIndex = 0;
            // 
            // txtCodP
            // 
            this.txtCodP.Location = new System.Drawing.Point(65, 96);
            this.txtCodP.Name = "txtCodP";
            this.txtCodP.ReadOnly = true;
            this.txtCodP.Size = new System.Drawing.Size(184, 20);
            this.txtCodP.TabIndex = 2;
            this.txtCodP.TabStop = false;
            // 
            // lblCodP
            // 
            this.lblCodP.AutoSize = true;
            this.lblCodP.Location = new System.Drawing.Point(27, 99);
            this.lblCodP.Name = "lblCodP";
            this.lblCodP.Size = new System.Drawing.Size(40, 13);
            this.lblCodP.TabIndex = 13;
            this.lblCodP.Text = "Código";
            // 
            // btnVoltarP
            // 
            this.btnVoltarP.Location = new System.Drawing.Point(173, 207);
            this.btnVoltarP.Name = "btnVoltarP";
            this.btnVoltarP.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarP.TabIndex = 6;
            this.btnVoltarP.Text = "Voltar";
            this.btnVoltarP.UseVisualStyleBackColor = true;
            this.btnVoltarP.Click += new System.EventHandler(this.btnVoltarP_Click);
            // 
            // txtPrecoP
            // 
            this.txtPrecoP.Location = new System.Drawing.Point(66, 151);
            this.txtPrecoP.Name = "txtPrecoP";
            this.txtPrecoP.ReadOnly = true;
            this.txtPrecoP.Size = new System.Drawing.Size(130, 20);
            this.txtPrecoP.TabIndex = 4;
            this.txtPrecoP.TabStop = false;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(66, 122);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.ReadOnly = true;
            this.txtNomeP.Size = new System.Drawing.Size(184, 20);
            this.txtNomeP.TabIndex = 3;
            this.txtNomeP.TabStop = false;
            // 
            // lblPrecoP
            // 
            this.lblPrecoP.AutoSize = true;
            this.lblPrecoP.Location = new System.Drawing.Point(28, 154);
            this.lblPrecoP.Name = "lblPrecoP";
            this.lblPrecoP.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoP.TabIndex = 7;
            this.lblPrecoP.Text = "Preço";
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(28, 125);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(35, 13);
            this.lblNomeP.TabIndex = 5;
            this.lblNomeP.Text = "Nome";
            // 
            // grpVend
            // 
            this.grpVend.Controls.Add(this.btnProcurarV);
            this.grpVend.Controls.Add(this.lblProcurarV);
            this.grpVend.Controls.Add(this.mskProcurarV);
            this.grpVend.Controls.Add(this.btnVoltarV);
            this.grpVend.Controls.Add(this.txtSenhaV);
            this.grpVend.Controls.Add(this.txtNomeV);
            this.grpVend.Controls.Add(this.mskCpfV);
            this.grpVend.Controls.Add(this.lblSenhaV);
            this.grpVend.Controls.Add(this.lblCpfV);
            this.grpVend.Controls.Add(this.lblNomeV);
            this.grpVend.Location = new System.Drawing.Point(325, 22);
            this.grpVend.Name = "grpVend";
            this.grpVend.Size = new System.Drawing.Size(307, 257);
            this.grpVend.TabIndex = 15;
            this.grpVend.TabStop = false;
            this.grpVend.Text = "Consulta de Vendedores";
            this.grpVend.Visible = false;
            // 
            // btnProcurarV
            // 
            this.btnProcurarV.Location = new System.Drawing.Point(188, 37);
            this.btnProcurarV.Name = "btnProcurarV";
            this.btnProcurarV.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarV.TabIndex = 1;
            this.btnProcurarV.Text = "Ir";
            this.btnProcurarV.UseVisualStyleBackColor = true;
            this.btnProcurarV.Click += new System.EventHandler(this.btnProcurarV_Click);
            // 
            // lblProcurarV
            // 
            this.lblProcurarV.AutoSize = true;
            this.lblProcurarV.Location = new System.Drawing.Point(16, 42);
            this.lblProcurarV.Name = "lblProcurarV";
            this.lblProcurarV.Size = new System.Drawing.Size(47, 13);
            this.lblProcurarV.TabIndex = 17;
            this.lblProcurarV.Text = "Procurar";
            // 
            // mskProcurarV
            // 
            this.mskProcurarV.Location = new System.Drawing.Point(64, 39);
            this.mskProcurarV.Mask = "999\\.999\\.999\\-99";
            this.mskProcurarV.Name = "mskProcurarV";
            this.mskProcurarV.PromptChar = ' ';
            this.mskProcurarV.Size = new System.Drawing.Size(118, 20);
            this.mskProcurarV.TabIndex = 0;
            this.mskProcurarV.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // btnVoltarV
            // 
            this.btnVoltarV.Location = new System.Drawing.Point(173, 207);
            this.btnVoltarV.Name = "btnVoltarV";
            this.btnVoltarV.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarV.TabIndex = 5;
            this.btnVoltarV.Text = "Voltar";
            this.btnVoltarV.UseVisualStyleBackColor = true;
            this.btnVoltarV.Click += new System.EventHandler(this.btnVoltarV_Click);
            // 
            // txtSenhaV
            // 
            this.txtSenhaV.Location = new System.Drawing.Point(64, 172);
            this.txtSenhaV.Name = "txtSenhaV";
            this.txtSenhaV.ReadOnly = true;
            this.txtSenhaV.Size = new System.Drawing.Size(183, 20);
            this.txtSenhaV.TabIndex = 4;
            this.txtSenhaV.TabStop = false;
            // 
            // txtNomeV
            // 
            this.txtNomeV.Location = new System.Drawing.Point(64, 93);
            this.txtNomeV.Name = "txtNomeV";
            this.txtNomeV.ReadOnly = true;
            this.txtNomeV.Size = new System.Drawing.Size(184, 20);
            this.txtNomeV.TabIndex = 2;
            this.txtNomeV.TabStop = false;
            // 
            // mskCpfV
            // 
            this.mskCpfV.Location = new System.Drawing.Point(64, 133);
            this.mskCpfV.Mask = "999\\.999\\.999\\-99";
            this.mskCpfV.Name = "mskCpfV";
            this.mskCpfV.PromptChar = ' ';
            this.mskCpfV.ReadOnly = true;
            this.mskCpfV.Size = new System.Drawing.Size(184, 20);
            this.mskCpfV.TabIndex = 3;
            this.mskCpfV.TabStop = false;
            this.mskCpfV.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblSenhaV
            // 
            this.lblSenhaV.AutoSize = true;
            this.lblSenhaV.Location = new System.Drawing.Point(23, 175);
            this.lblSenhaV.Name = "lblSenhaV";
            this.lblSenhaV.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaV.TabIndex = 7;
            this.lblSenhaV.Text = "Senha";
            // 
            // lblCpfV
            // 
            this.lblCpfV.AutoSize = true;
            this.lblCpfV.Location = new System.Drawing.Point(23, 136);
            this.lblCpfV.Name = "lblCpfV";
            this.lblCpfV.Size = new System.Drawing.Size(27, 13);
            this.lblCpfV.TabIndex = 6;
            this.lblCpfV.Text = "CPF";
            // 
            // lblNomeV
            // 
            this.lblNomeV.AutoSize = true;
            this.lblNomeV.Location = new System.Drawing.Point(23, 96);
            this.lblNomeV.Name = "lblNomeV";
            this.lblNomeV.Size = new System.Drawing.Size(35, 13);
            this.lblNomeV.TabIndex = 5;
            this.lblNomeV.Text = "Nome";
            // 
            // grpCli
            // 
            this.grpCli.Controls.Add(this.btnProcurarC);
            this.grpCli.Controls.Add(this.lvlProcurarC);
            this.grpCli.Controls.Add(this.mskProcurarC);
            this.grpCli.Controls.Add(this.mskTelC);
            this.grpCli.Controls.Add(this.lblSexoC);
            this.grpCli.Controls.Add(this.rdoFemC);
            this.grpCli.Controls.Add(this.rdoMascC);
            this.grpCli.Controls.Add(this.txtEndC);
            this.grpCli.Controls.Add(this.lblEndC);
            this.grpCli.Controls.Add(this.btnVoltarC);
            this.grpCli.Controls.Add(this.txtNomeC);
            this.grpCli.Controls.Add(this.mskCpfC);
            this.grpCli.Controls.Add(this.lblTelC);
            this.grpCli.Controls.Add(this.lblCpfC);
            this.grpCli.Controls.Add(this.lblNomeC);
            this.grpCli.Location = new System.Drawing.Point(12, 285);
            this.grpCli.Name = "grpCli";
            this.grpCli.Size = new System.Drawing.Size(307, 257);
            this.grpCli.TabIndex = 15;
            this.grpCli.TabStop = false;
            this.grpCli.Text = "Consulta de Clientes";
            this.grpCli.Visible = false;
            // 
            // btnProcurarC
            // 
            this.btnProcurarC.Location = new System.Drawing.Point(180, 29);
            this.btnProcurarC.Name = "btnProcurarC";
            this.btnProcurarC.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarC.TabIndex = 1;
            this.btnProcurarC.Text = "Ir";
            this.btnProcurarC.UseVisualStyleBackColor = true;
            this.btnProcurarC.Click += new System.EventHandler(this.btnProcurarC_Click);
            // 
            // lvlProcurarC
            // 
            this.lvlProcurarC.AutoSize = true;
            this.lvlProcurarC.Location = new System.Drawing.Point(3, 34);
            this.lvlProcurarC.Name = "lvlProcurarC";
            this.lvlProcurarC.Size = new System.Drawing.Size(47, 13);
            this.lvlProcurarC.TabIndex = 20;
            this.lvlProcurarC.Text = "Procurar";
            // 
            // mskProcurarC
            // 
            this.mskProcurarC.Location = new System.Drawing.Point(56, 31);
            this.mskProcurarC.Mask = "999\\.999\\.999\\-99";
            this.mskProcurarC.Name = "mskProcurarC";
            this.mskProcurarC.PromptChar = ' ';
            this.mskProcurarC.Size = new System.Drawing.Size(118, 20);
            this.mskProcurarC.TabIndex = 0;
            this.mskProcurarC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // mskTelC
            // 
            this.mskTelC.Location = new System.Drawing.Point(76, 125);
            this.mskTelC.Mask = "(99)\\ 9999\\-9999";
            this.mskTelC.Name = "mskTelC";
            this.mskTelC.PromptChar = ' ';
            this.mskTelC.ReadOnly = true;
            this.mskTelC.Size = new System.Drawing.Size(169, 20);
            this.mskTelC.TabIndex = 4;
            this.mskTelC.TabStop = false;
            this.mskTelC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblSexoC
            // 
            this.lblSexoC.AutoSize = true;
            this.lblSexoC.Location = new System.Drawing.Point(39, 198);
            this.lblSexoC.Name = "lblSexoC";
            this.lblSexoC.Size = new System.Drawing.Size(31, 13);
            this.lblSexoC.TabIndex = 17;
            this.lblSexoC.Text = "Sexo";
            // 
            // rdoFemC
            // 
            this.rdoFemC.AutoSize = true;
            this.rdoFemC.Enabled = false;
            this.rdoFemC.Location = new System.Drawing.Point(161, 196);
            this.rdoFemC.Name = "rdoFemC";
            this.rdoFemC.Size = new System.Drawing.Size(67, 17);
            this.rdoFemC.TabIndex = 7;
            this.rdoFemC.Text = "Feminino";
            this.rdoFemC.UseVisualStyleBackColor = true;
            // 
            // rdoMascC
            // 
            this.rdoMascC.AutoSize = true;
            this.rdoMascC.Enabled = false;
            this.rdoMascC.Location = new System.Drawing.Point(76, 196);
            this.rdoMascC.Name = "rdoMascC";
            this.rdoMascC.Size = new System.Drawing.Size(73, 17);
            this.rdoMascC.TabIndex = 6;
            this.rdoMascC.Text = "Masculino";
            this.rdoMascC.UseVisualStyleBackColor = true;
            // 
            // txtEndC
            // 
            this.txtEndC.Location = new System.Drawing.Point(76, 161);
            this.txtEndC.Name = "txtEndC";
            this.txtEndC.ReadOnly = true;
            this.txtEndC.Size = new System.Drawing.Size(223, 20);
            this.txtEndC.TabIndex = 5;
            this.txtEndC.TabStop = false;
            // 
            // lblEndC
            // 
            this.lblEndC.AutoSize = true;
            this.lblEndC.Location = new System.Drawing.Point(21, 161);
            this.lblEndC.Name = "lblEndC";
            this.lblEndC.Size = new System.Drawing.Size(53, 13);
            this.lblEndC.TabIndex = 13;
            this.lblEndC.Text = "Endereço";
            // 
            // btnVoltarC
            // 
            this.btnVoltarC.Location = new System.Drawing.Point(172, 222);
            this.btnVoltarC.Name = "btnVoltarC";
            this.btnVoltarC.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarC.TabIndex = 8;
            this.btnVoltarC.Text = "Voltar";
            this.btnVoltarC.UseVisualStyleBackColor = true;
            this.btnVoltarC.Click += new System.EventHandler(this.btnVoltarC_Click);
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(56, 70);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.ReadOnly = true;
            this.txtNomeC.Size = new System.Drawing.Size(190, 20);
            this.txtNomeC.TabIndex = 2;
            this.txtNomeC.TabStop = false;
            // 
            // mskCpfC
            // 
            this.mskCpfC.Location = new System.Drawing.Point(62, 99);
            this.mskCpfC.Mask = "999\\.999\\.999\\-99";
            this.mskCpfC.Name = "mskCpfC";
            this.mskCpfC.PromptChar = ' ';
            this.mskCpfC.ReadOnly = true;
            this.mskCpfC.Size = new System.Drawing.Size(184, 20);
            this.mskCpfC.TabIndex = 3;
            this.mskCpfC.TabStop = false;
            this.mskCpfC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Location = new System.Drawing.Point(22, 128);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(49, 13);
            this.lblTelC.TabIndex = 7;
            this.lblTelC.Text = "Telefone";
            // 
            // lblCpfC
            // 
            this.lblCpfC.AutoSize = true;
            this.lblCpfC.Location = new System.Drawing.Point(22, 99);
            this.lblCpfC.Name = "lblCpfC";
            this.lblCpfC.Size = new System.Drawing.Size(27, 13);
            this.lblCpfC.TabIndex = 6;
            this.lblCpfC.Text = "CPF";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Location = new System.Drawing.Point(21, 73);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(35, 13);
            this.lblNomeC.TabIndex = 5;
            this.lblNomeC.Text = "Nome";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 281);
            this.Controls.Add(this.grpCli);
            this.Controls.Add(this.grpVend);
            this.Controls.Add(this.grpPro);
            this.Controls.Add(this.grpAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.grpAdm.ResumeLayout(false);
            this.grpAdm.PerformLayout();
            this.grpPro.ResumeLayout(false);
            this.grpPro.PerformLayout();
            this.grpVend.ResumeLayout(false);
            this.grpVend.PerformLayout();
            this.grpCli.ResumeLayout(false);
            this.grpCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdm;
        private System.Windows.Forms.Button btnVoltarA;
        private System.Windows.Forms.TextBox txtSenhaA;
        private System.Windows.Forms.TextBox txtNomeA;
        private System.Windows.Forms.MaskedTextBox mskCpfA;
        private System.Windows.Forms.Label lblSenhaA;
        private System.Windows.Forms.Label lblCpfA;
        private System.Windows.Forms.Label lblNomeA;
        private System.Windows.Forms.GroupBox grpPro;
        private System.Windows.Forms.TextBox txtCodP;
        private System.Windows.Forms.Label lblCodP;
        private System.Windows.Forms.Button btnVoltarP;
        private System.Windows.Forms.TextBox txtPrecoP;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label lblPrecoP;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.GroupBox grpVend;
        private System.Windows.Forms.Button btnVoltarV;
        private System.Windows.Forms.TextBox txtSenhaV;
        private System.Windows.Forms.TextBox txtNomeV;
        private System.Windows.Forms.MaskedTextBox mskCpfV;
        private System.Windows.Forms.Label lblSenhaV;
        private System.Windows.Forms.Label lblCpfV;
        private System.Windows.Forms.Label lblNomeV;
        private System.Windows.Forms.GroupBox grpCli;
        private System.Windows.Forms.MaskedTextBox mskTelC;
        private System.Windows.Forms.Label lblSexoC;
        private System.Windows.Forms.RadioButton rdoFemC;
        private System.Windows.Forms.RadioButton rdoMascC;
        private System.Windows.Forms.TextBox txtEndC;
        private System.Windows.Forms.Label lblEndC;
        private System.Windows.Forms.Button btnVoltarC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.MaskedTextBox mskCpfC;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.Label lblCpfC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Button btnProcurarA;
        private System.Windows.Forms.Label lblProcurarA;
        private System.Windows.Forms.MaskedTextBox mskProcurarA;
        private System.Windows.Forms.Button btnProcurarP;
        private System.Windows.Forms.Label lblProcurarP;
        private System.Windows.Forms.TextBox txtProcurarP;
        private System.Windows.Forms.Button btnProcurarV;
        private System.Windows.Forms.Label lblProcurarV;
        private System.Windows.Forms.MaskedTextBox mskProcurarV;
        private System.Windows.Forms.Button btnProcurarC;
        private System.Windows.Forms.Label lvlProcurarC;
        private System.Windows.Forms.MaskedTextBox mskProcurarC;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
    }
}