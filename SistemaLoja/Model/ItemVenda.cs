using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Model
{
    class ItemVenda
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quant { get; set; }
    }
}
