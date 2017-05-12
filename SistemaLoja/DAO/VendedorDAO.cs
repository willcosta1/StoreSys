using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaLoja.Model;

namespace SistemaLoja.DAO
{
    class VendedorDAO
    {
        public static Vendedor Find(Vendedor V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Vendedores.FirstOrDefault(x=>x.Cpf.Equals(V.Cpf));
            }
            catch
            {
                return null;
            }
        }
        public static bool Insert(Vendedor V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Vendedores.Add(V);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(Vendedor V)
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
        public static bool Delete(Vendedor V)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Vendedores.Remove(V);
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
