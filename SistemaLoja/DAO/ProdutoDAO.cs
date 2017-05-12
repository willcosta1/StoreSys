using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaLoja.Model;

namespace SistemaLoja.DAO
{
    class ProdutoDAO
    {
        public static Produto FindCodigo(Produto P)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Produtos.FirstOrDefault(x => x.Codigo.Equals(P.Codigo));
            }
            catch
            {
                return null;
            }
        }
        /*public static Produto FindNome(Produto P)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Produtos.FirstOrDefault(x=>x.Nome.Equals(P.Nome));
            }
            catch
            {
                return null;
            }
        }*/

        public static bool Insert(Produto P)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Produtos.Add(P);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(Produto P)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(P).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Produto P)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Produtos.Remove(P);
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
