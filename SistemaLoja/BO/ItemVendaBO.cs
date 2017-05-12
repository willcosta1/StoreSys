using SistemaLoja.DAO;
using SistemaLoja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.BO
{
    class ItemVendaBO
    {
        public static float CalcularSub(float a,int b)
        {
            return a * (float)b;
        }
        public static float CalcularTotal()
        {
            float Total=0;
            VendaEItem VEI = new VendaEItem();
            for (int i = 0; i < ItemVendaDAO.GetListItens().Count; i++)
            {
                VEI.ItemVenda = ItemVendaDAO.GetListItens()[i];
                Total=Total+(VEI.ItemVenda.Produto.Preco * (float)VEI.ItemVenda.Quant);
            }
            return Total;
        }
    }
}
