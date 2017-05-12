using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLoja.DAO;
using SistemaLoja.Model;
using SistemaLoja.BO;
using System.Data.Entity;

namespace SistemaLoja
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (!mskCpfLogin.Text.Equals("") && !txtSenha.Text.Equals(""))
            {
                Administrador A = new Administrador();
                A.Cpf = mskCpfLogin.Text;
                A = AdministradorDAO.Find(A);
                if (A!= null)
                {
                    if (A.Senha.Equals(txtSenha.Text))
                    {
                        //this.Hide(); msm coisa, só para lembrar do comando
                        this.Visible = false;
                        Main m = new Main(1,A.Nome,A.Cpf);
                        m.Show();
                    }else
                    {
                        MessageBox.Show("Login ou senha inválidos!","Erro!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Vendedor V = new Vendedor();
                    V.Cpf = mskCpfLogin.Text;
                    V = VendedorDAO.Find(V);
                    if (V != null)
                    {
                        if (V.Senha.Equals(txtSenha.Text))
                        {
                            //this.Hide();
                            this.Visible = false;
                            Main m = new Main(2,V.Nome,V.Cpf);
                            m.Show();

                        }
                        else
                        {
                            MessageBox.Show("Login ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }else
                    {
                        MessageBox.Show("Login ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos!","Erro!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
