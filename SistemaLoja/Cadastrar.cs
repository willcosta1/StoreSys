using SistemaLoja.BO;
using SistemaLoja.DAO;
using SistemaLoja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }
        public frmCadastrar(int param)
        {
            InitializeComponent();
            switch (param)
            {
                case 1:
                    grpAdm.Show();
                    break;
                case 2:
                    this.grpVend.Location = new System.Drawing.Point(12, 12);
                    grpVend.Show();
                    break;
                case 3:
                    this.grpCli.Location = new System.Drawing.Point(12, 12);
                    grpCli.Show();
                    break;
                case 4:
                    this.grpPro.Location = new System.Drawing.Point(12, 12);
                    grpPro.Show();
                    break;
                    
            }
        }

        private void btnVoltarA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnVoltarV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltarC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //salvar
        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            if (!txtNomeA.Text.Equals("")&&!txtSenhaA.Text.Equals("")&&!mskCpfA.Text.Equals(""))
            {
                var A = new Administrador();
                var V = new Vendedor();
                V.Cpf = mskCpfA.Text;
                A.Nome = txtNomeA.Text;
                A.Cpf = mskCpfA.Text;
                A.Senha = txtSenhaA.Text;
                if (ValidarCpf.ValidarCPF(A) == false)
                {
                    MessageBox.Show("Por favor, digite um Cpf válido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (AdministradorDAO.Find(A) != null||VendedorDAO.Find(V)!=null)
                    {
                        MessageBox.Show("CPF já cadastrado! Já tem um mesmo CPF para Adm ou Vendedor!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (AdministradorDAO.Insert(A) == true)
                        {
                            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
                
            }else
            {
                MessageBox.Show("Por favor preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarV_Click(object sender, EventArgs e)
        {
            if (!txtNomeV.Text.Equals("") && !txtSenhaV.Text.Equals("") && !mskCpfV.Text.Equals(""))
            {
                var V = new Vendedor();
                var A = new Administrador();
                A.Cpf = mskCpfV.Text;
                V.Nome = txtNomeV.Text;
                V.Cpf = mskCpfV.Text;
                V.Senha = txtSenhaV.Text;
                if (ValidarCpf.ValidarCPF(V) == false)
                {
                    MessageBox.Show("Por favor, digite um Cpf válido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (VendedorDAO.Find(V) != null||AdministradorDAO.Find(A)!=null)
                    {
                        MessageBox.Show("CPF já cadastrado! Já tem um mesmo CPF para Adm ou Vendedor!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (VendedorDAO.Insert(V) == true)
                        {
                            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarC_Click(object sender, EventArgs e)
        {
            if (!txtNomeC.Text.Equals("") && !txtEndC.Text.Equals("") && !mskCpfC.Text.Equals("")&&((rdoFemC.Checked)||(rdoMascC.Checked)))
            {
                var C = new Cliente();
                C.Nome = txtNomeC.Text;
                C.Cpf = mskCpfC.Text;
                C.Telefone = mskTelC.Text;
                C.Endereco = txtEndC.Text;
                if (rdoFemC.Checked)
                {
                    C.Sexo = "F";
                }else
                {
                    C.Sexo = "M";
                }
                if (ValidarCpf.ValidarCPF(C) == false)
                {
                    MessageBox.Show("Por favor, digite um Cpf válido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ClienteDAO.Find(C) != null)
                    {
                        MessageBox.Show("CPF já cadastrado! Verifique os dados e tente novamente mais tarde", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (ClienteDAO.Insert(C) == true)
                        {
                            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarP_Click(object sender, EventArgs e)//salvarP
        {
            if (!txtNomeP.Text.Equals("") && !txtPrecoP.Text.Equals("")&&!txtCodP.Text.Equals("")&&!txtEstoque.Text.Equals(""))
            {
                var P = new Produto();
                P.Nome = txtNomeP.Text;
                P.Preco = float.Parse(txtPrecoP.Text);
                P.Codigo = txtCodP.Text;
                P.Estoque = int.Parse(txtEstoque.Text);
                if (P.Estoque >= 0&&P.Preco>=0)
                {
                    if (ProdutoDAO.FindCodigo(P) != null)
                    {
                        MessageBox.Show("Código já cadastrado! Verifique os dados e tente novamente mais tarde", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (ProdutoDAO.Insert(P) == true)
                        {
                            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }else
                {
                    MessageBox.Show("Estoque e/ou preço não podem ser negativos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
