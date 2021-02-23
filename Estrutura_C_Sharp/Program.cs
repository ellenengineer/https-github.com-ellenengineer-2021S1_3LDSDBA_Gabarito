using System;

namespace Estrutura_C_Sharp
{

    struct Retangulo
    {
        public double baseRetangulo;
        public double alturaRetangulo;

        public double CalcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Exercicio1();

            Exercicio2();
            Console.ReadLine();
        }

        /*Criar Programa onde imprime área do Retângulo.
         * O calculo da área deverá ser calculado em uma struct e impresso em uma aplicação console.
         * Validar (com ternário, if/else, switch ou as condições do C#8.0) antes da impressão, 
         * para verificar se a base e altura forem diferentes
         * */

        static void Exercicio1()
        {
            Console.WriteLine("Ex 1: ");
            Retangulo stRetangulo = new Retangulo();
            Console.WriteLine("Digite a base do retangulo: ");
            double dblBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo: ");
            double dblAltura = Convert.ToDouble(Console.ReadLine());

            stRetangulo.baseRetangulo = dblBase;
            stRetangulo.alturaRetangulo = dblAltura;


            if (dblBase != dblAltura)
                Console.WriteLine(string.Format("a área do retângulo é {0}", stRetangulo.CalcularArea()));
            else
                Console.WriteLine("Isto é um quadrado!Queremos retângulo!");

            Console.WriteLine("-------------------------- ");
            Console.WriteLine(" ");
        }
        /*Fazer um programa que retorne uma matriz(linha x coluna) de 2 colunas e 3 linhas
         * contendo nome dos produtos. 
         * Percorrer a matriz com um loop (while, for ou foreach), imprimindo cada item:
            posição  0,0 – celular samsung
            posição  1,0 – celular xiaomi
            posicao  2,0 – celular motorola

            posicao 0,1 – fone bluetooth
            posicao 1,1 – mouse razer
            posicao  2,1 - chromecast
        */
        static void Exercicio2()
        {
            Console.WriteLine("Ex 2: ");
            string[,] posicao = new string[3, 2];
            posicao[0, 0] = "celular samsung";
            posicao[1, 0] = "celular xiaomi";
            posicao[2, 0] = "celular motorola";

            posicao[0, 1] = "fone bluetooth";
            posicao[1, 1] = "mouse razer";
            posicao[2, 1] = "chromecast";

             foreach (var item in posicao)
             {
                 Console.WriteLine(item);
             }

            Console.WriteLine("-------------------------- ");
            Console.WriteLine(" ");
        }
    }
}
