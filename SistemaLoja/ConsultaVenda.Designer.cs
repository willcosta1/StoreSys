namespace SistemaLoja
{
    partial class frmConVenda
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
            this.lblDados = new System.Windows.Forms.Label();
            this.lblForma = new System.Windows.Forms.Label();
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
            this.lblCpfC = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ltvProdutos = new System.Windows.Forms.ListView();
            this.colCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtForma = new System.Windows.Forms.TextBox();
            this.mskCpfV = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfV = new System.Windows.Forms.Label();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(543, 15);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 43;
            this.lblDados.Text = "Dados";
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(401, 294);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(76, 13);
            this.lblForma.TabIndex = 42;
            this.lblForma.Text = "Forma de Pag.";
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Location = new System.Drawing.Point(428, 204);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(49, 13);
            this.lblTelC.TabIndex = 40;
            this.lblTelC.Text = "Telefone";
            // 
            // lblEndC
            // 
            this.lblEndC.AutoSize = true;
            this.lblEndC.Location = new System.Drawing.Point(442, 166);
            this.lblEndC.Name = "lblEndC";
            this.lblEndC.Size = new System.Drawing.Size(29, 13);
            this.lblEndC.TabIndex = 39;
            this.lblEndC.Text = "End.";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.Location = new System.Drawing.Point(442, 127);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(35, 13);
            this.lblNomeC.TabIndex = 38;
            this.lblNomeC.Text = "Nome";
            // 
            // lblSexoC
            // 
            this.lblSexoC.AutoSize = true;
            this.lblSexoC.Location = new System.Drawing.Point(446, 242);
            this.lblSexoC.Name = "lblSexoC";
            this.lblSexoC.Size = new System.Drawing.Size(31, 13);
            this.lblSexoC.TabIndex = 37;
            this.lblSexoC.Text = "Sexo";
            // 
            // rdoFemC
            // 
            this.rdoFemC.AutoSize = true;
            this.rdoFemC.Enabled = false;
            this.rdoFemC.Location = new System.Drawing.Point(589, 240);
            this.rdoFemC.Name = "rdoFemC";
            this.rdoFemC.Size = new System.Drawing.Size(67, 17);
            this.rdoFemC.TabIndex = 36;
            this.rdoFemC.Text = "Feminino";
            this.rdoFemC.UseVisualStyleBackColor = true;
            // 
            // rdoMascC
            // 
            this.rdoMascC.AutoSize = true;
            this.rdoMascC.Enabled = false;
            this.rdoMascC.Location = new System.Drawing.Point(483, 240);
            this.rdoMascC.Name = "rdoMascC";
            this.rdoMascC.Size = new System.Drawing.Size(73, 17);
            this.rdoMascC.TabIndex = 35;
            this.rdoMascC.Text = "Masculino";
            this.rdoMascC.UseVisualStyleBackColor = true;
            // 
            // mskTelC
            // 
            this.mskTelC.Location = new System.Drawing.Point(483, 201);
            this.mskTelC.Mask = "(99)\\ 9999\\-9999";
            this.mskTelC.Name = "mskTelC";
            this.mskTelC.PromptChar = ' ';
            this.mskTelC.ReadOnly = true;
            this.mskTelC.Size = new System.Drawing.Size(173, 20);
            this.mskTelC.TabIndex = 34;
            this.mskTelC.TabStop = false;
            this.mskTelC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtEndC
            // 
            this.txtEndC.Location = new System.Drawing.Point(483, 163);
            this.txtEndC.MaxLength = 50;
            this.txtEndC.Name = "txtEndC";
            this.txtEndC.ReadOnly = true;
            this.txtEndC.Size = new System.Drawing.Size(173, 20);
            this.txtEndC.TabIndex = 33;
            this.txtEndC.TabStop = false;
            // 
            // mskCpfC
            // 
            this.mskCpfC.Location = new System.Drawing.Point(483, 88);
            this.mskCpfC.Mask = "999\\.999\\.999\\-99";
            this.mskCpfC.Name = "mskCpfC";
            this.mskCpfC.PromptChar = ' ';
            this.mskCpfC.ReadOnly = true;
            this.mskCpfC.Size = new System.Drawing.Size(173, 20);
            this.mskCpfC.TabIndex = 32;
            this.mskCpfC.TabStop = false;
            this.mskCpfC.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(483, 124);
            this.txtNomeC.MaxLength = 50;
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.ReadOnly = true;
            this.txtNomeC.Size = new System.Drawing.Size(173, 20);
            this.txtNomeC.TabIndex = 31;
            this.txtNomeC.TabStop = false;
            // 
            // lblCpfC
            // 
            this.lblCpfC.AutoSize = true;
            this.lblCpfC.Location = new System.Drawing.Point(415, 91);
            this.lblCpfC.Name = "lblCpfC";
            this.lblCpfC.Size = new System.Drawing.Size(62, 13);
            this.lblCpfC.TabIndex = 29;
            this.lblCpfC.Text = "CPF Cliente";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(226, 294);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 13);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total - R$";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(286, 291);
            this.txtTotal.MaxLength = 20;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(109, 20);
            this.txtTotal.TabIndex = 45;
            this.txtTotal.TabStop = false;
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
            this.ltvProdutos.Location = new System.Drawing.Point(12, 38);
            this.ltvProdutos.Name = "ltvProdutos";
            this.ltvProdutos.Size = new System.Drawing.Size(383, 240);
            this.ltvProdutos.TabIndex = 44;
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
            // txtForma
            // 
            this.txtForma.Location = new System.Drawing.Point(483, 291);
            this.txtForma.MaxLength = 50;
            this.txtForma.Name = "txtForma";
            this.txtForma.ReadOnly = true;
            this.txtForma.Size = new System.Drawing.Size(173, 20);
            this.txtForma.TabIndex = 47;
            this.txtForma.TabStop = false;
            // 
            // mskCpfV
            // 
            this.mskCpfV.Location = new System.Drawing.Point(483, 50);
            this.mskCpfV.Mask = "999\\.999\\.999\\-99";
            this.mskCpfV.Name = "mskCpfV";
            this.mskCpfV.PromptChar = ' ';
            this.mskCpfV.ReadOnly = true;
            this.mskCpfV.Size = new System.Drawing.Size(173, 20);
            this.mskCpfV.TabIndex = 49;
            this.mskCpfV.TabStop = false;
            this.mskCpfV.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblCpfV
            // 
            this.lblCpfV.AutoSize = true;
            this.lblCpfV.Location = new System.Drawing.Point(401, 53);
            this.lblCpfV.Name = "lblCpfV";
            this.lblCpfV.Size = new System.Drawing.Size(76, 13);
            this.lblCpfV.TabIndex = 48;
            this.lblCpfV.Text = "CPF Vendedor";
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(110, 12);
            this.txtIdVenda.MaxLength = 15;
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(81, 20);
            this.txtIdVenda.TabIndex = 0;
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.AutoSize = true;
            this.lblIdVenda.Location = new System.Drawing.Point(13, 15);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(91, 13);
            this.lblIdVenda.TabIndex = 50;
            this.lblIdVenda.Text = "Buscar Venda(ID)";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(197, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(581, 346);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(326, 12);
            this.txtData.MaxLength = 20;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(151, 20);
            this.txtData.TabIndex = 54;
            this.txtData.TabStop = false;
            // 
            // frmConVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdVenda);
            this.Controls.Add(this.lblIdVenda);
            this.Controls.Add(this.mskCpfV);
            this.Controls.Add(this.lblCpfV);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.ltvProdutos);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.lblTelC);
            this.Controls.Add(this.lblEndC);
            this.Controls.Add(this.lblNomeC);
            this.Controls.Add(this.lblSexoC);
            this.Controls.Add(this.rdoFemC);
            this.Controls.Add(this.rdoMascC);
            this.Controls.Add(this.mskTelC);
            this.Controls.Add(this.txtEndC);
            this.Controls.Add(this.mskCpfC);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.lblCpfC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConVenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.Label lblEndC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label lblSexoC;
        private System.Windows.Forms.RadioButton rdoFemC;
        private System.Windows.Forms.RadioButton rdoMascC;
        private System.Windows.Forms.MaskedTextBox mskTelC;
        private System.Windows.Forms.TextBox txtEndC;
        private System.Windows.Forms.MaskedTextBox mskCpfC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.Label lblCpfC;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListView ltvProdutos;
        private System.Windows.Forms.ColumnHeader colCod;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.ColumnHeader colQuant;
        private System.Windows.Forms.ColumnHeader colSubT;
        private System.Windows.Forms.TextBox txtForma;
        private System.Windows.Forms.MaskedTextBox mskCpfV;
        private System.Windows.Forms.Label lblCpfV;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.Label lblIdVenda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
    }
}