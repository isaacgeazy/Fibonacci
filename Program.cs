using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           int valor1 = 0, valor2 = 1;
            int termo;       
            int soma;
          

          
                Console.Write("Digite a Quantidade de Termos: ");
                termo = int.Parse(Console.ReadLine());
               
                soma = valor1 + valor2;

                Console.WriteLine();
                Console.Write(0 + " " + 1 + " ");

                 for (int i = 3; i <= termo; i++)
                {
                    Console.Write(soma + " ");
                    valor1 = valor2;
                    valor2 = soma;
                    soma = valor1 + valor2;
                }

        }
    }
}

