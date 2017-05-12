using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaLoja.Model;
using System.Data.Entity;

namespace SistemaLoja.DAO
{
    class VendaEItemDAO
    {
        public static bool Insert(VendaEItem VI)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.VendaEItens.Add(VI);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<VendaEItem> FindVI(VendaEItem VI)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.VendaEItens.Include("Venda").Include("ItemVenda.Produto").Where(x=>x.Venda.Id==(VI.Venda.Id)).ToList();
            }
            catch(Exception error)
            {
                return null;
            }
        }
        public static bool InsertVendaEItemOnTable(Venda V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                for (int i = 0; i < ItemVendaDAO.GetListItens().Count; i++)
                {
                    var IV = new ItemVenda();
                    var VEI = new VendaEItem();
                    var P = new Produto();
                    VEI.Venda = V;
                    VEI.ItemVenda = ItemVendaDAO.GetListItens()[i];
                    P.Codigo = VEI.ItemVenda.Produto.Codigo;
                    P = ProdutoDAO.FindCodigo(P);
                    P.Estoque -= VEI.ItemVenda.Quant;
                    ProdutoDAO.Alter(P);
                    ItemVendaDAO.Insert(VEI.ItemVenda);
                    VEI.ItemVenda = ItemVendaDAO.Find(VEI.ItemVenda);
                    VendaEItemDAO.Insert(VEI);
                }
                ItemVendaDAO.ClearList();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
