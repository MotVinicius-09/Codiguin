using System;
using System.Globalization;

namespace Area_de_estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleat = new Random(50);
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(numAleat.Next(50).ToString());
            }
            Console.Write("Numeros: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros[i] + ",");
            }

            int[] numPar = new int[10];
            int[] numImp = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    numPar[i] = numeros[i];
                }
                else
                {
                    numImp[i] = numeros[i];
                }
            }
            
            Console.WriteLine();
            Console.Write("Numeros pares: ");
            for (int i = 0; i < 10; i++)
            {
                if (numPar[i] != 0)
                {
                    Console.Write(numPar[i] + ",");
                }
                    
            }
            Console.WriteLine();
            Console.Write("Numeros Impares: ");
            for (int i = 0; i < 10; i++)
            {
                if (numImp[i] != 0)
                {
                    Console.Write(numImp[i] + ",");
                }
            }
        }
    } 
}
