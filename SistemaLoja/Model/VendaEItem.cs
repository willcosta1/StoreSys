using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Model
{
    class VendaEItem
    {
        public int Id { get; set; }
        public Venda Venda { get; set; }
        public ItemVenda ItemVenda { get; set; }
    }
}
