using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Model
{
    class Cliente : Pessoa
    {
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Sexo { get; set; }
    }
}
