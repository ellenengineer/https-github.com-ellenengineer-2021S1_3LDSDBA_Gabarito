using System;
using System.Collections.Generic;
using System.Text;

namespace OOCollections
{
   public  class ClientePF:Pessoa
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public double Renda { get; set; }
        public string Sexo { get; set; }
    }
}
