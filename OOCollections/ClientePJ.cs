﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOCollections
{
   public class ClientePJ:Pessoa
    {
        public int ID { get; set; }

        public string CNPJ { get; set; }
        public double Lucro { get; set; }
        public string TipoEmpresa { get; set; }
    }
}
