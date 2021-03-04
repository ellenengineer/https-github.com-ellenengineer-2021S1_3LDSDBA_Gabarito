using System;
using System.Collections.Generic;
using System.Text;

namespace OOCollections
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DtNascFund { get; set; }
        public string Email { get; set; }

        public List<Endereco> Enderecos { get;set; }
    }
}
