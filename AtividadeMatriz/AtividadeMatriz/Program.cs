using System;
using System.Globalization;
using System.Collections.Generic;

namespace Estudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            int[,] mat = new int[num1, num2];

            for (int i = 0; i < num1; i++)
            {
                string[] val = Console.ReadLine().Split(' ');

                for (int j = 0; j < num2; j++)
                {
                    mat[i, j] = int.Parse(val[j]);
                }
            }

            int numProc = int.Parse(Console.ReadLine());

            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    if (mat[i, j] == numProc)
                    {

                        Console.WriteLine("Posição " + i + "," + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Direita: " + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }

                        if (j < num2 - 1)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j + 1]);
                        }

                        if (i < num1 - 1)
                        {
                            Console.WriteLine("Embaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}
