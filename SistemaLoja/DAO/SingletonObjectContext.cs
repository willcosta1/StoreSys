using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.DAO
{
    class SingletonObjectContext
    {
        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly LojaEntities context;

        private SingletonObjectContext()
        {
            context = new LojaEntities();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public LojaEntities Context
        {
            get
            {
                return context;
            }
        }
    }
}