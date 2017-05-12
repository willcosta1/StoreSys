using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SistemaLoja.Model;

namespace SistemaLoja.DAO
{
    class ClienteDAO
    {
        public static Cliente Find(Cliente C)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Clientes.FirstOrDefault(x=>x.Cpf.Equals(C.Cpf));
            }
            catch
            {
                return null;
            }
        }
        public static bool Insert(Cliente C)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Clientes.Add(C);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(Cliente C)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(C).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Cliente C)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Clientes.Remove(C);
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
