using System;
using System.Collections.Generic;

namespace OOCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientePF objPessoaFisica = new ClientePF();

            objPessoaFisica.Nome = "Ellen";
            objPessoaFisica.Enderecos = new List<Endereco>();


            Endereco end1 = new Endereco();
            end1.ID = 1;
            end1.TipoEndereco = TipoEndereco.Residencial;
            end1.Logradouro = "Av Teste, 300";
            end1.Complemento = "apto 114 bl A";
            end1.Bairro = "Centro";
            end1.Cidade = "Townsville";

            objPessoaFisica.Enderecos.Add(end1);

            Endereco end2 = new Endereco();
            end2.ID = 2;
            end2.TipoEndereco = TipoEndereco.Comercial;
            end2.Logradouro = "Av Dom Pedro II, 300";
            end2.Complemento = "apto 256";
            end2.Bairro = "Centro";
            end2.Cidade = "Citytown";

            objPessoaFisica.Enderecos.Add(end2);


            Endereco end3 = new Endereco();
            end3.ID = 3;
            end3.TipoEndereco = TipoEndereco.Outros;
            end3.Logradouro = "Rua Imperador II, 90";
            end3.Complemento = "casa 1";
            end3.Bairro = "Tijuca";
            end3.Cidade = "Ville2";

            objPessoaFisica.Enderecos.Add(end3);

            foreach (var end in objPessoaFisica.Enderecos)
            {
                Console.WriteLine(objPessoaFisica.Nome + " mora em " + end.Consultar());
            }


            Console.ReadLine();
        }
    }
}
