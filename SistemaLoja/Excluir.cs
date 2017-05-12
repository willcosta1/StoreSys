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
    public partial class frmExcluir : Form
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

        public frmExcluir(int param)
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
                    MessageBox.Show("Encontrado!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CPF não encontrado!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("CPF não encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("CPF não encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    txtPrecoP.Text = P.Preco.ToString("C2");
                    txtCodP.Text = P.Codigo;
                    txtEstoque.Text = P.Estoque.ToString();
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não encontrado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor, Preencha os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Excluir
        private void btnExcluirA_Click(object sender, EventArgs e)
        {
            if (!txtNomeA.Text.Equals(""))
            {
                var A = new Administrador();
                A.Cpf = mskCpfA.Text;
                A=AdministradorDAO.Find(A);
                if (AdministradorDAO.Delete(A) == true)
                {
                    txtNomeA.Clear();
                    txtSenhaA.Clear();
                    mskCpfA.Clear();
                    MessageBox.Show("Deletado!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Error","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Operação inválida!","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluirV_Click(object sender, EventArgs e)
        {
            if (!txtNomeV.Text.Equals(""))
            {
                var V = new Vendedor();
                V.Cpf = mskCpfV.Text;
                V = VendedorDAO.Find(V);
                if (VendedorDAO.Delete(V) == true)
                {
                    txtNomeV.Clear();
                    txtSenhaV.Clear();
                    mskCpfV.Clear();
                    MessageBox.Show("Deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Error!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operação inválida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluirC_Click(object sender, EventArgs e)
        {
            if (!txtNomeC.Text.Equals(""))
            {
                var C = new Cliente();
                C.Cpf = mskCpfC.Text;
                C = ClienteDAO.Find(C);
                if (ClienteDAO.Delete(C) == true)
                {
                    txtNomeC.Clear();
                    txtEndC.Clear();
                    mskCpfC.Clear();
                    mskTelC.Clear();
                    rdoFemC.Checked = false;
                    rdoMascC.Checked = false;
                    MessageBox.Show("Deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Error", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operação inválida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluirP_Click(object sender, EventArgs e)
        {
            if (!txtNomeP.Text.Equals(""))
            {
                var P = new Produto();
                P.Codigo = txtCodP.Text;
                P = ProdutoDAO.FindCodigo(P);
                if (ProdutoDAO.Delete(P) == true)
                {
                    txtCodP.Clear();
                    txtNomeP.Clear();
                    txtPrecoP.Clear();
                    txtEstoque.Clear();
                    MessageBox.Show("Deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Error", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Operação inválida!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
