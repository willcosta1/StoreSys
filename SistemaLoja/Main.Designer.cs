namespace SistemaLoja
{
    partial class Main
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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAltA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAltV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAltC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAltP = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExcP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBemVindo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomeLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpVenda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCodRemove = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblCodP = new System.Windows.Forms.Label();
            this.txtCodRemove = new System.Windows.Forms.TextBox();
            this.txtQuantP = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.ltvProdutos = new System.Windows.Forms.ListView();
            this.colCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
            this.cboForma = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblTelC = new System.Windows.Forms.Label();
            this.lblEndC = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.lblSexoC = new System.Windows.Forms.Label();
            this.rdoFemC = new System.Windows.Forms.RadioButton();
            this.rdoMascC = new System.Windows.Forms.RadioButton();
            this.mskTelC = new System.Windows.Forms.MaskedTextBox();
            this.txtEndC = new System.Windows.Forms.TextBox();
            this.mskCpfC = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblCpfC = new System.Windows.Forms.Label();
            this.mnPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.tsmSair});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(758, 24);
            this.mnPrincipal.TabIndex = 0;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadA,
            this.tsmCadV,
            this.tsmCadC,
            this.tsmCadP,
            this.tsmCadVenda});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "&Cadastrar";
            // 
            // tsmCadA
            // 
            this.tsmCadA.Enabled = false;
            this.tsmCadA.Name = "tsmCadA";
            this.tsmCadA.Size = new System.Drawing.Size(150, 22);
            this.tsmCadA.Text = "Administrador";
            this.tsmCadA.Click += new System.EventHandler(this.tsmCadA_Click);
            // 
            // tsmCadV
            // 
            this.tsmCadV.Enabled = false;
            this.tsmCadV.Name = "tsmCadV";
            this.tsmCadV.Size = new System.Drawing.Size(150, 22);
            this.tsmCadV.Text = "Vendedor";
            this.tsmCadV.Click += new System.EventHandler(this.tsmCadV_Click);
            // 
            // tsmCadC
            // 
            this.tsmCadC.Name = "tsmCadC";
            this.tsmCadC.Size = new System.Drawing.Size(150, 22);
            this.tsmCadC.Text = "Cliente";
            this.tsmCadC.Click += new System.EventHandler(this.tsmCadC_Click);
            // 
            // tsmCadP
            // 
            this.tsmCadP.Name = "tsmCadP";
            this.tsmCadP.Size = new System.Drawing.Size(150, 22);
            this.tsmCadP.Text = "Produto";
            this.tsmCadP.Click += new System.EventHandler(this.tsmCadP_Click);
            // 
            // tsmCadVenda
            // 
            this.tsmCadVenda.Enabled = false;
            this.tsmCadVenda.Name = "tsmCadVenda";
            this.tsmCadVenda.Size = new System.Drawing.Size(150, 22);
            this.tsmCadVenda.Text = "Venda";
            this.tsmCadVenda.Click += new System.EventHandler(this.tsmCadVenda_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConA,
            this.tsmConV,
            this.tsmConC,
            this.tsmConP,
            this.tsmConVenda});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "C&onsultar";
            // 
            // tsmConA
            // 
            this.tsmConA.Enabled = false;
            this.tsmConA.Name = "tsmConA";
            this.tsmConA.Size = new System.Drawing.Size(150, 22);
            this.tsmConA.Text = "Administrador";
            this.tsmConA.Click += new System.EventHandler(this.tsmConA_Click);
            // 
            // tsmConV
            // 
            this.tsmConV.Enabled = false;
            this.tsmConV.Name = "tsmConV";
            this.tsmConV.Size = new System.Drawing.Size(150, 22);
            this.tsmConV.Text = "Vendedor";
            this.tsmConV.Click += new System.EventHandler(this.tsmConV_Click);
            // 
            // tsmConC
            // 
            this.tsmConC.Name = "tsmConC";
            this.tsmConC.Size = new System.Drawing.Size(150, 22);
            this.tsmConC.Text = "Cliente";
            this.tsmConC.Click += new System.EventHandler(this.tsmConC_Click);
            // 
            // tsmConP
            // 
            this.tsmConP.Name = "tsmConP";
            this.tsmConP.Size = new System.Drawing.Size(150, 22);
            this.tsmConP.Text = "Produto";
            this.tsmConP.Click += new System.EventHandler(this.tsmConP_Click);
            // 
            // tsmConVenda
            // 
            this.tsmConVenda.Name = "tsmConVenda";
            this.tsmConVenda.Size = new System.Drawing.Size(150, 22);
            this.tsmConVenda.Text = "Venda";
            this.tsmConVenda.Click += new System.EventHandler(this.tsmConVenda_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAltA,
            this.tsmAltV,
            this.tsmAltC,
            this.tsmAltP});
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "&Alterar";
            // 
            // tsmAltA
            // 
            this.tsmAltA.Enabled = false;
            this.tsmAltA.Name = "tsmAltA";
            this.tsmAltA.Size = new System.Drawing.Size(150, 22);
            this.tsmAltA.Text = "Administrador";
            this.tsmAltA.Click += new System.EventHandler(this.tsmAltA_Click);
            // 
            // tsmAltV
            // 
            this.tsmAltV.Enabled = false;
            this.tsmAltV.Name = "tsmAltV";
            this.tsmAltV.Size = new System.Drawing.Size(150, 22);
            this.tsmAltV.Text = "Vendedor";
            this.tsmAltV.Click += new System.EventHandler(this.tsmAltV_Click);
            // 
            // tsmAltC
            // 
            this.tsmAltC.Name = "tsmAltC";
            this.tsmAltC.Size = new System.Drawing.Size(150, 22);
            this.tsmAltC.Text = "Cliente";
            this.tsmAltC.Click += new System.EventHandler(this.tsmAltC_Click);
            // 
            // tsmAltP
            // 
            this.tsmAltP.Name = "tsmAltP";
            this.tsmAltP.Size = new System.Drawing.Size(150, 22);
            this.tsmAltP.Text = "Produto";
            this.tsmAltP.Click += new System.EventHandler(this.tsmAltP_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExcA,
            this.tsmExcV,
            this.tsmExcC,
            this.tsmExcP});
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.excluirToolStripMenuItem.Text = "&Excluir";
            // 
            // tsmExcA
            // 
            this.tsmExcA.Enabled = false;
            this.tsmExcA.Name = "tsmExcA";
            this.tsmExcA.Size = new System.Drawing.Size(150, 22);
            this.tsmExcA.Text = "Administrador";
            this.tsmExcA.Click += new System.EventHandler(this.tsmExcA_Click);
            // 
            // tsmExcV
            // 
            this.tsmExcV.Enabled = false;
            this.tsmExcV.Name = "tsmExcV";
            this.tsmExcV.Size = new System.Drawing.Size(150, 22);
            this.tsmExcV.Text = "Vendedor";
            this.tsmExcV.Click += new System.EventHandler(this.tsmExcV_Click);
            // 
            // tsmExcC
            // 
            this.tsmExcC.Enabled = false;
            this.tsmExcC.Name = "tsmExcC";
            this.tsmExcC.Size = new System.Drawing.Size(150, 22);
            this.tsmExcC.Text = "Cliente";
            this.tsmExcC.Click += new System.EventHandler(this.tsmExcC_Click);
            // 
            // tsmExcP
            // 
            this.tsmExcP.Name = "tsmExcP";
            this.tsmExcP.Size = new System.Drawing.Size(150, 22);
            this.tsmExcP.Text = "Produto";
            this.tsmExcP.Click += new System.EventHandler(this.tsmExcP_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(38, 20);
            this.tsmSair.Text = "&Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBemVindo,
            this.lblData,
            this.lblHora,
            this.lblNomeLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(123, 17);
            this.lblBemVindo.Text = "Bem vindo ao sistema";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 17);
            this.lblData.Text = "lblData";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 17);
            this.lblHora.Text = "lblTime";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNomeLogin
            // 
            this.lblNomeLogin.Name = "lblNomeLogin";
            this.lblNomeLogin.Size = new System.Drawing.Size(53, 17);
            this.lblNomeLogin.Text = "lblNome";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grpVenda
            // 
            this.grpVenda.Controls.Add(this.label1);
            this.grpVenda.Controls.Add(this.txtTotal);
            this.grpVenda.Controls.Add(this.lblCodRemove);
            this.grpVenda.Controls.Add(this.lblQuant);
            this.grpVenda.Controls.Add(this.lblCodP);
            this.grpVenda.Controls.Add(this.txtCodRemove);
            this.grpVenda.Controls.Add(this.txtQuantP);
            this.grpVenda.Controls.Add(this.txtIdP);
            this.grpVenda.Controls.Add(this.btnAdd);
            this.grpVenda.Controls.Add(this.btnRemover);
            this.grpVenda.Controls.Add(this.ltvProdutos);
            this.grpVenda.Controls.Add(this.lblProdutos);
            this.grpVenda.Controls.Add(this.lblDados);
            this.grpVenda.Controls.Add(this.lblForma);
            this.grpVenda.Controls.Add(this.cboForma);
            this.grpVenda.Controls.Add(this.btnVoltar);
            this.grpVenda.Controls.Add(this.btnConfirmar);
            this.grpVenda.Controls.Add(this.lblTelC);
            this.grpVenda.Controls.Add(this.lblEndC);
            this.grpVenda.Controls.Add(this.lblNomeC);
            this.grpVenda.Controls.Add(this.lblSexoC);
            this.grpVenda.Controls.Add(this.rdoFemC);
            this.grpVenda.Controls.Add(this.rdoMascC);
            this.grpVenda.Controls.Add(this.mskTelC);
            this.grpVenda.Controls.Add(this.txtEndC);
            this.grpVenda.Controls.Add(this.mskCpfC);
            this.grpVenda.Controls.Add(this.txtNomeC);
            this.grpVenda.Controls.Add(this.btnVerificar);
            this.grpVenda.Controls.Add(this.lblCpfC);
            this.grpVenda.Location = new System.Drawing.Point(13, 28);
            this.grpVenda.Name = "grpVenda";
            this.grpVenda.Size = new System.Drawing.Size(733, 414);
            this.grpVenda.TabIndex = 2;
            this.grpVenda.TabStop = false;
            this.grpVenda.Text = "Cadastrar Venda";
            this.grpVenda.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total - R$";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(280, 377);
            this.txtTotal.MaxLength = 20;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(109, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // lblCodRemove
            // 
            this.lblCodRemove.AutoSize = true;
            this.lblCodRemove.Location = new System.Drawing.Point(184, 135);
            this.lblCodRemove.Name = "lblCodRemove";
            this.lblCodRemove.Size = new System.Drawing.Size(69, 13);
            this.lblCodRemove.TabIndex = 39;
            this.lblCodRemove.Text = "Cod. Produto";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(214, 86);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(39, 13);
            this.lblQuant.TabIndex = 38;
            this.lblQuant.Text = "Quant.";
            // 
            // lblCodP
            // 
            this.lblCodP.AutoSize = true;
            this.lblCodP.Location = new System.Drawing.Point(62, 86);
            this.lblCodP.Name = "lblCodP";
            this.lblCodP.Size = new System.Drawing.Size(69, 13);
            this.lblCodP.TabIndex = 37;
            this.lblCodP.Text = "Cod. Produto";
            // 
            // txtCodRemove
            // 
            this.txtCodRemove.Location = new System.Drawing.Point(255, 132);
            this.txtCodRemove.MaxLength = 15;
            this.txtCodRemove.Name = "txtCodRemove";
            this.txtCodRemove.Size = new System.Drawing.Size(53, 20);
            this.txtCodRemove.TabIndex = 3;
            // 
            // txtQuantP
            // 
            this.txtQuantP.Location = new System.Drawing.Point(255, 83);
            this.txtQuantP.MaxLength = 6;
            this.txtQuantP.Name = "txtQuantP";
            this.txtQuantP.Size = new System.Drawing.Size(53, 20);
            this.txtQuantP.TabIndex = 1;
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(137, 83);
            this.txtIdP.MaxLength = 15;
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(53, 20);
            this.txtIdP.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(314, 129);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // ltvProdutos
            // 
            this.ltvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCod,
            this.colNome,
            this.colPreco,
            this.colQuant,
            this.colSubT});
            this.ltvProdutos.FullRowSelect = true;
            this.ltvProdutos.GridLines = true;
            this.ltvProdutos.Location = new System.Drawing.Point(6, 158);
            this.ltvProdutos.Name = "ltvProdutos";
            this.ltvProdutos.Size = new System.Drawing.Size(383, 204);
            this.ltvProdutos.TabIndex = 30;
            this.ltvProdutos.TabStop = false;
            this.ltvProdutos.UseCompatibleStateImageBehavior = false;
            this.ltvProdutos.View = System.Windows.Forms.View.Details;
            // 
            // colCod
            // 
            this.colCod.Text = "Cód.";
            this.colCod.Width = 51;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 103;
            // 
            // colPreco
            // 
            this.colPreco.DisplayIndex = 3;
            this.colPreco.Text = "Preço";
            this.colPreco.Width = 85;
            // 
            // colQuant
            // 
            this.colQuant.DisplayIndex = 2;
            this.colQuant.Text = "Quantidade";
            this.colQuant.Width = 51;
            // 
            // colSubT
            // 
            this.colSubT.Text = "SubTotal";
            this.colSubT.Width = 87;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Location = new System.Drawing.Point(150, 35);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(49, 13);
            this.lblProdutos.TabIndex = 29;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(579, 35);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 28;
            this.lblDados.Text = "Dados";
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(443, 288);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(76, 13);
            this.lblForma.TabIndex = 27;
            this.lblForma.Text = "Forma de Pag.";
            // 
            // cboForma
            // 
            this.cboForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForma.FormattingEnabled = true;
            this.cboForma.Items.AddRange(new object[] {
            "Dinheiro - À Vista",
            "Cartão de Crédito",
            "Cartão de Débito"});
            this.cboForma.Location = new System.Drawing.Point(525, 285);
            this.cboForma.Name = "cboForma";
            this.cboForma.Size = new System.Drawing.Size(173, 21);
            this.cboForma.TabIndex = 8;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(525, 375);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(623, 375);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Location = new System.Drawing.Point(470, 201);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(49, 13);
            this.lblTelC.TabIndex = 23;
            this.lblTelC.Text = "Telefone";
            // 
            // lblEndC
            // 
            this.lblEndC.AutoSize = true;
            this.lblEndC.Location = new System.Drawing.Point(484, 163);
            this.lblEndC.Name = "lblEndC";
            this.lblEndC.Size = new System.Drawing.Size(29, 13);
            this.lblEndC.TabIndex = 22;
            this.lblEndC.Text = "End.";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Location = new System.Drawing.Point(484, 124);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(35, 13);
            this.lblNomeC.TabIndex = 21;
            this.lblNomeC.Text = "Nome";
            // 
            // lblSexoC
            // 
            this.lblSexoC.AutoSize = true;
            this.lblSexoC.Location = new System.Drawing.Point(488, 239);
            this.lblSexoC.Name = "lblSexoC";
            this.lblSexoC.Size = new System.Drawing.Size(31, 13);
            this.lblSexoC.TabIndex = 20;
            this.lblSexoC.Text = "Sexo";
            // 
            // rdoFemC
            // 
            this.rdoFemC.AutoSize = true;
            this.rdoFemC.Enabled = false;
            this.rdoFemC.Location = new System.Drawing.Point(631, 237);
            this.rdoFemC.Name = "rdoFemC";
            this.rdoFemC.Size = new System.Drawing.Size(67, 17);
            this.rdoFemC.TabIndex = 19;
            this.rdoFemC.Text = "Feminino";
            this.rdoFemC.UseVisualStyleBackColor = true;
            // 
            // rdoMascC
            // 
            this.rdoMascC.AutoSize = true;
            this.rdoMascC.Enabled = false;
            this.rdoMascC.Location = new System.Drawing.Point(525, 237);
            this.rdoMascC.Name = "rdoMascC";
            this.rdoMascC.Size = new System.Drawing.Size(73, 17);
            this.rdoMascC.TabIndex = 18;
            this.rdoMascC.Text = "Masculino";
            this.rdoMascC.UseVisualStyleBackColor = true;
            // 
            // mskTelC
            // 
            this.mskTelC.Location = new System.Drawing.Point(525, 198);
            this.mskTelC.Mask = "(99)\\ 9999\\-9999";
            this.mskTelC.Name = "mskTelC";
            this.mskTelC.PromptChar = ' ';
            this.mskTelC.ReadOnly = true;
            this.mskTelC.Size = new System.Drawing.Size(173, 20);
            this.mskTelC.TabIndex = 6;
            this.mskTelC.TabStop = false;
            this.mskTelC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtEndC
            // 
            this.txtEndC.Location = new System.Drawing.Point(525, 160);
            this.txtEndC.MaxLength = 50;
            this.txtEndC.Name = "txtEndC";
            this.txtEndC.ReadOnly = true;
            this.txtEndC.Size = new System.Drawing.Size(173, 20);
            this.txtEndC.TabIndex = 5;
            this.txtEndC.TabStop = false;
            // 
            // mskCpfC
            // 
            this.mskCpfC.Location = new System.Drawing.Point(525, 80);
            this.mskCpfC.Mask = "999\\.999\\.999\\-99";
            this.mskCpfC.Name = "mskCpfC";
            this.mskCpfC.PromptChar = ' ';
            this.mskCpfC.Size = new System.Drawing.Size(92, 20);
            this.mskCpfC.TabIndex = 6;
            this.mskCpfC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(525, 121);
            this.txtNomeC.MaxLength = 50;
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.ReadOnly = true;
            this.txtNomeC.Size = new System.Drawing.Size(173, 20);
            this.txtNomeC.TabIndex = 3;
            this.txtNomeC.TabStop = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(623, 78);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblCpfC
            // 
            this.lblCpfC.AutoSize = true;
            this.lblCpfC.Location = new System.Drawing.Point(457, 83);
            this.lblCpfC.Name = "lblCpfC";
            this.lblCpfC.Size = new System.Drawing.Size(62, 13);
            this.lblCpfC.TabIndex = 0;
            this.lblCpfC.Text = "CPF Cliente";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 467);
            this.Controls.Add(this.grpVenda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnPrincipal;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Loja - Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpVenda.ResumeLayout(false);
            this.grpVenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBemVindo;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadA;
        private System.Windows.Forms.ToolStripMenuItem tsmCadV;
        private System.Windows.Forms.ToolStripMenuItem tsmCadC;
        private System.Windows.Forms.ToolStripMenuItem tsmCadP;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmConA;
        private System.Windows.Forms.ToolStripMenuItem tsmConV;
        private System.Windows.Forms.ToolStripMenuItem tsmConC;
        private System.Windows.Forms.ToolStripMenuItem tsmConP;
        private System.Windows.Forms.ToolStripMenuItem tsmConVenda;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAltA;
        private System.Windows.Forms.ToolStripMenuItem tsmAltV;
        private System.Windows.Forms.ToolStripMenuItem tsmAltC;
        private System.Windows.Forms.ToolStripMenuItem tsmAltP;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExcA;
        private System.Windows.Forms.ToolStripMenuItem tsmExcV;
        private System.Windows.Forms.ToolStripMenuItem tsmExcC;
        private System.Windows.Forms.ToolStripMenuItem tsmExcP;
        private System.Windows.Forms.ToolStripMenuItem tsmCadVenda;
        private System.Windows.Forms.ToolStripStatusLabel lblNomeLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.GroupBox grpVenda;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblCpfC;
        private System.Windows.Forms.TextBox txtEndC;
        private System.Windows.Forms.MaskedTextBox mskCpfC;
        private System.Windows.Forms.MaskedTextBox mskTelC;
        private System.Windows.Forms.Label lblSexoC;
        private System.Windows.Forms.RadioButton rdoFemC;
        private System.Windows.Forms.RadioButton rdoMascC;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.Label lblEndC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.ComboBox cboForma;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView ltvProdutos;
        private System.Windows.Forms.ColumnHeader colCod;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.ColumnHeader colQuant;
        private System.Windows.Forms.ColumnHeader colSubT;
        private System.Windows.Forms.TextBox txtQuantP;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblCodRemove;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblCodP;
        private System.Windows.Forms.TextBox txtCodRemove;
    }
}