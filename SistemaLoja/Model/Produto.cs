using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Model
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Codigo { get; set; }
        public int Estoque { get; set; }
    }
}
