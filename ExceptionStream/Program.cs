using System;
using System.IO;
using System.Text;

namespace ExceptionStream
{
    class Program
    {

        static void Main(string[] args)
        {
            Excecao();

            EscreverArquivo();

            LerArquivo();

            Console.ReadLine();
        }

        /*Fazer um método que crie um diretório, caso ele não exista e retorne o nome do diretório 
         * criado e/ou existente
         */
        static string LeDiretorio()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\DiretorioTeste");
            string retorno = string.Empty;
            try
            {
                if (di.Exists)
                {
                    retorno = di.FullName;
                }
                else
                {
                    di.Create();
                    retorno = di.FullName;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao criar ou ler diretório: {0}", e.ToString());
            }
            finally
            {
                Console.WriteLine("Procedimento finalizado!");
            }
            return retorno;
        }

        /// <summary>
        /// Fazer um método que crie um arquivo chamado AulaFapen.txt,  
        /// dentro do diretório criado no ex 1. E escrever o seguinte conteúdo 
        /// "Estamos utilizando a classe StreamWriter para escrever esse código! "                                             
        /// </summary>
        static void EscreverArquivo()
        {
            try
            {
                string diretorio = LeDiretorio();
                string arquivo = "AulaFapen.txt";

                string arquivoCompleto = string.Concat(diretorio,"\\",arquivo);
                using (StreamWriter writer = new StreamWriter(arquivoCompleto))
                {
                    writer.WriteLine("Estamos utilizando a classe StreamWriter para escrever esse código! ");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + "  " + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finalizou a execução");
            }

        }

        ///  Fazer um programa que leia o arquivo criado no exercício número 2 e 
        ///  jogue a frase escrita no arquivo em uma aplicação console 
        static void LerArquivo()
        {
            string diretorio = LeDiretorio();
            string arquivo = "AulaFapen.txt";
            string arquivoCompleto = string.Concat(diretorio, "\\", arquivo);

            StringBuilder sb = new StringBuilder();
            if (File.Exists(arquivoCompleto))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivoCompleto))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            sb.AppendLine(linha);
                        }
                        Console.WriteLine(sb.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Operação finalizada!");
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + " não foi localizado !");
            }
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
