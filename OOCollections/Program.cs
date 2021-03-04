using System;

namespace OOCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientePF objPessoaFisica = new ClientePF();

            objPessoaFisica.Nome = "Ellen";
            objPessoaFisica.Endereco = new Endereco();
            objPessoaFisica.Endereco.ID = 1;
            objPessoaFisica.Endereco.TipoEndereco = TipoEndereco.Residencial;
            objPessoaFisica.Endereco.Logradouro = "Av Teste, 300";
            objPessoaFisica.Endereco.Complemento = "apto 114 bl A";
            objPessoaFisica.Endereco.Bairro = "Centro";
            objPessoaFisica.Endereco.Cidade = "Townsville";

            Console.WriteLine(objPessoaFisica.Nome + " mora em " + objPessoaFisica.Endereco.Consultar());

            Console.ReadLine();
        }
    }
}
