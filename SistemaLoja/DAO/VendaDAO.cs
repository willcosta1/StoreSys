using SistemaLoja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaLoja.DAO
{
    class VendaDAO
    {
        public static Venda Find(Venda V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Vendas.Include("Cliente").Include("Vendedor").FirstOrDefault(x=>x.Id==V.Id);
            }
            catch
            {
                return null;
            }
        }
        public static bool Insert(Venda V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Vendas.Add(V);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(Venda V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(V).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Venda V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Vendas.Remove(V);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
