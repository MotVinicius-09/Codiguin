using System;

namespace Trabalho_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que receba 2 números de um usuário e retorne qual,
            //dos números é o maior e depois verifique se esse número é primo ou não.
            Program p = new Program();
            {
                try
                {
                    Console.Write("Digite o primeiro numero: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo numero: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int numEscolhido = p.MaiorNum(num1,num2);
                    Console.WriteLine();
                    Console.WriteLine("O maior numero digitado foi " + numEscolhido);
                    p.NumeroPrimo(numEscolhido);
                }
                catch (Exception)
                {
                    Console.WriteLine("Deu ruim menó");
                }

            }

        }

        private int MaiorNum(int num1,int num2)
        {
            if(num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        private void NumeroPrimo(int numeroEscolhido)
        {
            if(numeroEscolhido % 2 != 0)
            {
                
                Console.WriteLine("Esse numero é primo");
            }
            else
            {
               
                Console.WriteLine("Esse numero não é primo");
            }
        }
    }
}
