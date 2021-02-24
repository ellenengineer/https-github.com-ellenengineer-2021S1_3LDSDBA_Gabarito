using System;

namespace ExceptionStream
{
    class Program
    {

        /*
         * Fazer um método que crie um diretório, caso ele não exista e retorne o nome do diretório criado e/ou existente
          Fazer um método que crie um arquivo chamado AulaFapen.txt,  dentro do diretório criado no ex 1. E escrever o seguinte conteúdo "Estamos utilizando a classe StreamWriter para escrever esse código! "                                             
          Fazer um programa que leia o arquivo criado no exercício número 2 e jogue a frase escrita no arquivo em uma aplicação console                   

         */
        static void Main(string[] args)
        {
            Excecao();



            Console.ReadLine();
        }

        /// <summary>
        /// Fazer um programa em aplicação console, onde tenta converter dados inseridos pelo usuário
        /// para um valor inteiro.Se não conseguir converter, 
        /// lançar uma exceção e imprimir mensagem de erro na tela.
        /// </summary>
        static void Excecao()
        {
            Console.WriteLine("Digite um número!");
            int num1;
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(string.Format("O número convertido é : {0}", num1));
            }
            catch (Exception)
            {

                Console.WriteLine("Eu disse para digitar numero e não outro tipo de variavel!! Eeerrrr ");
            }
            finally
            {
                Console.WriteLine("Fim do programa!");
            }



        }
    }
}
