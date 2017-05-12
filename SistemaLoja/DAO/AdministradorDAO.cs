using SistemaLoja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

namespace SistemaLoja.DAO
{
    class AdministradorDAO
    {
        public static Administrador Find(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Administradores.FirstOrDefault(x=>x.Cpf.Equals(A.Cpf));
            }
            catch
            {
                return null;
            }
        }
        public static bool Insert(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Administradores.Add(A);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Alter(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(A).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool Delete(Administrador A)
        {
            LojaEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Administradores.Remove(A);
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
