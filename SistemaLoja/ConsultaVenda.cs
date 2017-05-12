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
    public partial class frmConVenda : Form
    {
        public frmConVenda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtIdVenda.Equals(""))
            {
                var Venda = new Venda();
                Venda.Id = int.Parse(txtIdVenda.Text);
                if ((Venda = VendaDAO.Find(Venda)) != null)
                {
                    if ((Venda.Cliente)!=null)
                    {
                        //var C = new Cliente();
                        //C.Cpf = Venda.Cliente.Cpf;
                        //Venda.Cliente = C;
                        mskCpfC.Text = Venda.Cliente.Cpf;
                        txtNomeC.Text = Venda.Cliente.Nome;
                        txtEndC.Text = Venda.Cliente.Endereco;
                        mskTelC.Text = Venda.Cliente.Telefone;
                        if (Venda.Cliente.Sexo.Equals("F"))
                        {
                            rdoFemC.Checked = true;
                        }
                        else
                        {
                            rdoMascC.Checked = true;
                        }
                        mskCpfV.Text = Venda.Vendedor.Cpf;
                        txtTotal.Text = Venda.Total.ToString("C2");
                        txtForma.Text = Venda.FormaPag;
                        txtData.Text = Venda.Data.ToString();
                        ltvProdutos.Items.Clear();
                        var VI = new VendaEItem();
                        VI.Venda = VendaDAO.Find(Venda);
                        foreach (VendaEItem item in VendaEItemDAO.FindVI(VI))
                        {
                            ListViewItem item2 = new ListViewItem(item.ItemVenda.Produto.Codigo.ToString());
                            item2.SubItems.Add(item.ItemVenda.Produto.Nome);
                            item2.SubItems.Add(item.ItemVenda.Produto.Preco.ToString("C2"));
                            item2.SubItems.Add(item.ItemVenda.Quant.ToString());
                            item2.SubItems.Add(ItemVendaBO.CalcularSub(item.ItemVenda.Produto.Preco, item.ItemVenda.Quant).ToString("C2"));
                            ltvProdutos.Items.Add(item2);
                        }
                        MessageBox.Show("Encontrada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao buscar a venda desejada!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Venda não encontrada!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Preencha o campo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
