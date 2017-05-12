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
    public partial class frmAlterar : Form
    {
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
        public frmAlterar(int param)
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
        //salvar
        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            
            if (!txtNomeA.Text.Equals("") && !txtSenhaA.Text.Equals("") && !mskCpfA.Text.Equals(""))
            {
                var A = new Administrador();
                A.Cpf = mskCpfA.Text;
                if (ValidarCpf.ValidarCPF(A) == false)
                {
                    MessageBox.Show("CPF ou operação inválida!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    A = AdministradorDAO.Find(A);
                    A.Nome = txtNomeA.Text;
                    A.Senha = txtSenhaA.Text;
                    if (AdministradorDAO.Alter(A) == true)
                    {
                        MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarV_Click(object sender, EventArgs e)
        {
            if (!txtNomeV.Text.Equals("") && !txtSenhaV.Text.Equals("") && !mskCpfV.Text.Equals(""))//
            {
                var V = new Vendedor();
                V.Cpf = mskCpfV.Text;
                if (ValidarCpf.ValidarCPF(V) == false)
                {
                    MessageBox.Show("CPF ou operação inválida!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    V = VendedorDAO.Find(V);
                    V.Nome = txtNomeV.Text;
                    V.Senha = txtSenhaV.Text;
                    if (VendedorDAO.Alter(V) == true)
                    {
                        MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            if (!txtNomeC.Text.Equals("") && !txtEndC.Text.Equals("") && !mskCpfC.Text.Equals("") && ((rdoFemC.Checked) || (rdoMascC.Checked)))
            {
                var C = new Cliente();
                C.Cpf = mskCpfC.Text;
                if (ValidarCpf.ValidarCPF(C) == false)
                {
                    MessageBox.Show("CPF ou operação inválida!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    C = ClienteDAO.Find(C);
                    C.Nome = txtNomeC.Text;
                    C.Endereco = txtEndC.Text;
                    C.Telefone = mskTelC.Text;
                    if (rdoFemC.Checked == true)
                    {
                        C.Sexo = "F";
                    }
                    else
                    {
                        C.Sexo = "M";
                    }
                    if (ClienteDAO.Alter(C) == true)
                    {
                        MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            if (!txtNomeP.Text.Equals("") && !txtPrecoP.Text.Equals("") && !txtCodP.Text.Equals("")&&!txtEstoque.Text.Equals(""))
            {
                var P = new Produto();
                P.Codigo = txtCodP.Text;
                if ((P = ProdutoDAO.FindCodigo(P))!=null)
                {
                    if (int.Parse(txtEstoque.Text) >= 0 && float.Parse(txtPrecoP.Text)>=0)
                    {
                        P.Nome = txtNomeP.Text;
                        P.Preco = float.Parse(txtPrecoP.Text);
                        P.Estoque = int.Parse(txtEstoque.Text);
                        if (ProdutoDAO.Alter(P) == true)
                        {
                            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Estoque e/ou preço não podem ser negativos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }else
                {
                    MessageBox.Show("Operação inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos ou pesquise um produto!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //procurar
        private void btnProcurarA_Click(object sender, EventArgs e)
        {
            if (!mskProcurarA.Text.Equals(""))
            {
                var A = new Administrador();
                A.Cpf = mskProcurarA.Text;
                if ((A = AdministradorDAO.Find(A)) != null)
                {
                    txtNomeA.Text = A.Nome;
                    mskCpfA.Text = A.Cpf;
                    txtSenhaA.Text = A.Senha;
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcurarV_Click(object sender, EventArgs e)
        {
            if (!mskProcurarV.Text.Equals(""))
            {
                var V = new Vendedor();
                V.Cpf = mskProcurarV.Text;
                if ((V = VendedorDAO.Find(V)) != null)
                {
                    txtNomeV.Text = V.Nome;
                    mskCpfV.Text = V.Cpf;
                    txtSenhaV.Text = V.Senha;
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcurarC_Click(object sender, EventArgs e)
        {
            if (!mskProcurarC.Text.Equals(""))
            {
                var C = new Cliente();
                C.Cpf = mskProcurarC.Text;
                if ((C = ClienteDAO.Find(C)) != null)
                {
                    txtNomeC.Text = C.Nome;
                    mskCpfC.Text = C.Cpf;
                    txtEndC.Text = C.Endereco;
                    mskTelC.Text = C.Telefone;
                    if (C.Sexo.Equals("F"))
                    {
                        rdoFemC.Checked = true;
                    }
                    else
                    {
                        rdoMascC.Checked = true;
                    }
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcurarP_Click(object sender, EventArgs e)
        {
            if (!txtProcurarP.Text.Equals(""))
            {
                var P = new Produto();
                P.Codigo = txtProcurarP.Text;
                if ((P = ProdutoDAO.FindCodigo(P)) != null)
                {
                    txtNomeP.Text = P.Nome;
                    txtPrecoP.Text = P.Preco.ToString();
                    txtCodP.Text = P.Codigo;
                    txtEstoque.Text = P.Estoque.ToString();
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
