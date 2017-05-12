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
    public partial class Main : Form
    {
        string cpflog;
        public Main(int param,string nome, string cpflogin) //Parametro criado para controlar a dinamica de menus, mostrar nome(do login) e pegar o cpf
        {
            InitializeComponent();
            //Abaixo está o controle de tipo de conta no sistema, sendo eles, administrador e vendedor
            //tsm=toolstripmenu, cad=cadastro, con=consulta, alt=alteração, exc=Exclusão
            //A, V, C, P em todo codigo, refere a Administrador, Vendedor, Cliente, Produto
            //Dava para ter criado um form para cada função, mas ficaria uma quantidade grande de forms(4x4=16), apenas nas funções basicas...
            //então optei por deixar tudo dinamico, mudando apenas as localizações dos grpBox
            if (param==1)
            {
                tsmCadA.Enabled = true;
                tsmCadV.Enabled = true;
                tsmConA.Enabled = true;
                tsmConV.Enabled = true;
                tsmAltA.Enabled = true;
                tsmAltV.Enabled = true;
                tsmExcA.Enabled = true;
                tsmExcV.Enabled = true;
                tsmExcC.Enabled = true;
            }else
            {
                tsmCadVenda.Enabled = true;
            }
            lblNomeLogin.Text = "No sistema como: " + nome;
            cpflog = cpflogin;
        }
        //Data e hora
        private void timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = ("Data: " + DateTime.Now.ToShortDateString());
            lblHora.Text = ("Horário: " + DateTime.Now.ToLongTimeString());
        }
        //Cadastros
        public void tsmCadA_Click(object sender, EventArgs e)
        {
            var frmCadastrar = new frmCadastrar(1);
            frmCadastrar.ShowDialog();
        }
        private void tsmCadV_Click(object sender, EventArgs e)
        {
            var frmCadastrar = new frmCadastrar(2);
            frmCadastrar.ShowDialog();
        }

        private void tsmCadC_Click(object sender, EventArgs e)
        {
            var frmCadastrar = new frmCadastrar(3);
            frmCadastrar.ShowDialog();
        }

        private void tsmCadP_Click(object sender, EventArgs e)
        {
            var frmCadastrar = new frmCadastrar(4);
            frmCadastrar.ShowDialog();
        }
        //Consultas
        private void tsmConA_Click(object sender, EventArgs e)
        {
            var frmConsultar = new frmConsultar(1);
            frmConsultar.ShowDialog();
        }

        private void tsmConV_Click(object sender, EventArgs e)
        {
            var frmConsultar = new frmConsultar(2);
            frmConsultar.ShowDialog();
        }

        private void tsmConC_Click(object sender, EventArgs e)
        {
            var frmConsultar = new frmConsultar(3);
            frmConsultar.ShowDialog();
        }

        private void tsmConP_Click(object sender, EventArgs e)
        {
            var frmConsultar = new frmConsultar(4);
            frmConsultar.ShowDialog();
        }
        //Alterações
        private void tsmAltA_Click(object sender, EventArgs e)
        {
            var frmAlterar = new frmAlterar(1);
            frmAlterar.ShowDialog();
        }

        private void tsmAltV_Click(object sender, EventArgs e)
        {
            var frmAlterar = new frmAlterar(2);
            frmAlterar.ShowDialog();
        }

        private void tsmAltC_Click(object sender, EventArgs e)
        {
            var frmAlterar = new frmAlterar(3);
            frmAlterar.ShowDialog();
        }

        private void tsmAltP_Click(object sender, EventArgs e)
        {
            var frmAlterar = new frmAlterar(4);
            frmAlterar.ShowDialog();
        }
        //Exclusões
        private void tsmExcA_Click(object sender, EventArgs e)
        {
            var frmExcluir = new frmExcluir(1);
            frmExcluir.ShowDialog();
        }

        private void tsmExcV_Click(object sender, EventArgs e)
        {
            var frmExcluir = new frmExcluir(2);
            frmExcluir.ShowDialog();
        }

        private void tsmExcC_Click(object sender, EventArgs e)
        {
            var frmExcluir = new frmExcluir(3);
            frmExcluir.ShowDialog();
        }

        private void tsmExcP_Click(object sender, EventArgs e)
        {
            var frmExcluir = new frmExcluir(4);
            frmExcluir.ShowDialog();
        }
        //Sair
        private void tsmSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmCadVenda_Click(object sender, EventArgs e)
        {
            grpVenda.Show();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!mskCpfC.Equals(""))
            {
                var C = new Cliente();
                C.Cpf = mskCpfC.Text;
                if ((C=ClienteDAO.Find(C))!=null)
                {
                    txtNomeC.Text=C.Nome;
                    txtEndC.Text=C.Endereco;
                    mskTelC.Text=C.Telefone;
                    if (C.Sexo.Equals("F"))
                    {
                        rdoFemC.Checked=true;
                    }
                    else
                    {
                        rdoMascC.Checked = true;
                    }
                }else
                {
                    MessageBox.Show("Cliente não encontrado!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }else
            {
                MessageBox.Show("Digite um CPF!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            mskCpfC.Clear();
            txtNomeC.Clear();
            txtEndC.Clear();
            mskTelC.Clear();
            rdoFemC.Checked = false;
            rdoMascC.Checked = false;
            grpVenda.Hide();
            ltvProdutos.Items.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!mskCpfC.Text.Equals("")&&!txtNomeC.Text.Equals("")&&!txtTotal.Text.Equals("")&&!txtTotal.Text.Equals("0")&&!cboForma.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Continuar?","info",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (DialogResult==DialogResult.Yes) {
                    var Venda = new Venda();
                    var C = new Cliente();
                    var V = new Vendedor();
                    C.Cpf = mskCpfC.Text;
                    V.Cpf = cpflog;
                    Venda.Cliente = ClienteDAO.Find(C);
                    Venda.Vendedor = VendedorDAO.Find(V);
                    Venda.Data = DateTime.Now;
                    Venda.FormaPag = cboForma.Text;
                    Venda.Total = float.Parse(txtTotal.Text);
                    VendaDAO.Insert(Venda);
                    Venda = VendaDAO.Find(Venda);
                    if (VendaEItemDAO.InsertVendaEItemOnTable(Venda) == true)
                    {
                        MessageBox.Show("Salvo! ID da Venda é: " + Venda.Id, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTotal.Clear();
                        mskCpfC.Clear();
                        ltvProdutos.Items.Clear();
                        txtNomeC.Clear();
                        txtEndC.Clear();
                        mskTelC.Clear();
                        rdoFemC.Checked = false;
                        rdoMascC.Checked = false;
                    } else
                    {
                        MessageBox.Show("Error!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Operação inválida! Por favor, verifique os produtos e dados e tente novamente.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//-1 no index significa não ter
        {
            if (!txtIdP.Text.Equals("")&&!txtQuantP.Text.Equals(""))
            {
                var P = new Produto();
                P.Codigo = txtIdP.Text;
                if ((P = ProdutoDAO.FindCodigo(P)) != null)
                {
                    if (ItemVendaDAO.FindIndex(P) == -1)
                    {
                        if (P.Estoque >= int.Parse(txtQuantP.Text)&&int.Parse(txtQuantP.Text)>0)
                        {

                            var i = new ItemVenda();
                            i.Quant = int.Parse(txtQuantP.Text);
                            i.Produto = P;
                            ItemVendaDAO.AddItens(i);
                            txtIdP.Clear();
                            txtQuantP.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não tem estoque para a quantidade selecionada! Ou a quantidade selecionada é menor ou igual a zero.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        int index=ItemVendaDAO.FindIndex(P);
                        var iv = new ItemVenda();
                        iv = ItemVendaDAO.FindIndexObj(index);
                        int quanttemp=iv.Quant + int.Parse(txtQuantP.Text);
                        iv.Produto = P;
                        if (quanttemp<=P.Estoque)
                        {
                            iv.Quant += int.Parse(txtQuantP.Text);
                            ItemVendaDAO.AddIndexObj(iv,index);
                            txtQuantP.Clear();
                            txtIdP.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não há estoque!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                          
                    }
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            ltvProdutos.Items.Clear();
            foreach (ItemVenda item in ItemVendaDAO.GetListItens())
            {
                ListViewItem item2 = new ListViewItem(item.Produto.Codigo.ToString());
                item2.SubItems.Add(item.Produto.Nome);
                item2.SubItems.Add(item.Produto.Preco.ToString("C2"));
                item2.SubItems.Add(item.Quant.ToString());
                item2.SubItems.Add(ItemVendaBO.CalcularSub(item.Produto.Preco, item.Quant).ToString("C2"));
                ltvProdutos.Items.Add(item2);
            }
            txtTotal.Text = ItemVendaBO.CalcularTotal().ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (!txtCodRemove.Text.Equals(""))
            {
                var P = new Produto();
                P.Codigo = txtCodRemove.Text;
                if ((ItemVendaDAO.RemoveItens(P))==true)
                { 
                    txtCodRemove.Clear();
                }
                else
                {
                    MessageBox.Show("Não há um produto com o código selecionado no carrinho!","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }else
            {
                MessageBox.Show("Preencha o campo!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            ltvProdutos.Items.Clear();
            foreach (ItemVenda item in ItemVendaDAO.GetListItens())
            {
                ListViewItem item2 = new ListViewItem(item.Produto.Codigo.ToString());
                item2.SubItems.Add(item.Produto.Nome);
                item2.SubItems.Add(item.Produto.Preco.ToString());
                item2.SubItems.Add(item.Quant.ToString());
                item2.SubItems.Add(ItemVendaBO.CalcularSub(item.Produto.Preco,item.Quant).ToString("C2"));
                ltvProdutos.Items.Add(item2);
            }
            txtTotal.Text = ItemVendaBO.CalcularTotal().ToString();
        }

        private void tsmConVenda_Click(object sender, EventArgs e)
        {
            var ConVenda = new frmConVenda();
            ConVenda.ShowDialog();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result==DialogResult.Yes)
            {
                var form = new frmLogin();
                form.Show();
            }else
            {
                e.Cancel=true;
            }
        }
    }
}
