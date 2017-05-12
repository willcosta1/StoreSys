using SistemaLoja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaLoja.DAO
{
    class ItemVendaDAO
    {
        static List<ItemVenda> Itens = new List<ItemVenda>();
        public static ItemVenda Find(ItemVenda I)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Itens.FirstOrDefault(x=>x.Id==I.Id);
            }
            catch
            {
                return null;
            }
        }
        public static bool Insert(ItemVenda I)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Itens.Add(I);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(ItemVenda I)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(I).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(ItemVenda I)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Itens.Remove(I);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ItemVenda> GetListItens()
        {
            return Itens.ToList();
        }

        public static void AddItens(ItemVenda Item)
        {
            Itens.Add(Item);
        }

        public static bool RemoveItens(Produto P)
        {
            if (FindIndex(P) >= 0)
            {
                Itens.RemoveAll(x => x.Produto.Codigo.Contains(P.Codigo));
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int FindIndex(Produto P)
        {
            int index = Itens.FindIndex(x => x.Produto.Codigo == P.Codigo);
            return index;
        }
        public static void ClearList()
        {
            Itens.Clear();
        }

        public static ItemVenda FindIndexObj(int index)
        {
            return Itens[index];
        }
        public static void AddIndexObj(ItemVenda i,int index)
        {
            Itens[index] = i;
        }
    }
}
