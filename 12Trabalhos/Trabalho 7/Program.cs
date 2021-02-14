using System;
using System.Linq;

namespace Trabalho_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que receba n valores do usuário e em seguida ordene os valores em ordem ascendente.

            Console.Write("Quantos numeros você quer usar?: ");
            int num = int.Parse(Console.ReadLine());
            int[] vet = new int[num];
            Console.WriteLine();

            for(int i = 0; i < num; i++)
            {
                Random numRand = new Random();
                int numAleat = numRand.Next(0, 999);
                vet[i] = numAleat;
            }

            int[] ordemCrecente = vet.OrderBy(x => x).ToArray();
            Console.WriteLine("Ordenando na ordem crescente: ");

            for(int i = 0; i < num; i ++)
            {
                Console.WriteLine(ordemCrecente[i]);
                
            }
        }
    }
}
