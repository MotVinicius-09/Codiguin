using System;
using System.Linq;
using System.Windows;

namespace Trabalho_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            for(int i = 0; i <= 15; i++)
            {
                fibonacci = numeroAtual + numeroAnterior;
                Console.Write(fibonacci);
                if(15 > i)
                {
                    Console.Write(" + ");
                }
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }
        }
    }
}
