using System;

namespace Trabalho_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que imprime no Console uma matriz identidade n por n usando um laço for.
            
            Console.Write("Informe o tamanho da matriz: ");
            int TamMat = int.Parse(Console.ReadLine());

            for(int i = 0; i < TamMat; i++)
            {
                for(int j = 0; j < TamMat;j++)
                {
                    if(i==j)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine("");
            }

        }
    }
}
