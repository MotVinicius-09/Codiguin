using System;

namespace Trabalho_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que calcule e exiba a soma da seguinte série : 
            //1 * x + 2 * x ^ 2 + 3 * x ^ 3 + 4 * x ^ 4 + 5 * x ^ 5 + … +n * xn


            Console.WriteLine("Informe o intervalor de valores a ixibir para série : ");
            Console.WriteLine("1*^x + 2*x^2 + 3*x^3 + 4*x^4 + 5*x^5 + ... + n*x^n");

            Console.Write("Digite o numero: ");
            int num = int.Parse(Console.ReadLine());

            double soma = 0;
            for (int i = 0; i <= num; i++)
            {
                Console.Write(i + "*x^" + i);

                if (i < num)
                {
                    Console.Write(" + ");
                }
                soma += (i * Math.Pow(i, i));
            }
            Console.WriteLine("");
            Console.WriteLine("A soma da série é: " + soma);
        }
    }
}
