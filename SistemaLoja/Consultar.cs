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
    public partial class frmConsultar : Form
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

        public frmConsultar(int param)
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
                if ((A=AdministradorDAO.Find(A))!=null)
                {
                    txtNomeA.Text = A.Nome;
                    mskCpfA.Text = A.Cpf;
                    txtSenhaA.Text=A.Senha;
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("CPF não encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
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
                    txtEndC.Text=C.Endereco;
                    mskTelC.Text=C.Telefone;
                    if (C.Sexo.Equals("F"))
                    {
                        rdoFemC.Checked = true;
                    }else
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
                if ((P=ProdutoDAO.FindCodigo(P))!=null)
                {
                    txtNomeP.Text=P.Nome;
                    txtPrecoP.Text=P.Preco.ToString("C2");
                    txtCodP.Text=P.Codigo;
                    txtEstoque.Text=P.Estoque.ToString();
                    MessageBox.Show("Encontrado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
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
