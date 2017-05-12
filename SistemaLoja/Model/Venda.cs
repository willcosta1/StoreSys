using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Model
{
    class Venda
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public DateTime Data { get; set; }
        public string FormaPag { get; set; }
        public float Total { get; set; }
    }
}
