using System;
using System.Linq;
using System.Windows;

namespace Trabalho_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci = 0;
            int x = 0;
            int y = 1;

            for (int i = 0; i <= 15; i++)
            {
                fibonacci = x + y;
                Console.Write(fibonacci);
                if (15 > i)
                {
                    Console.Write(" + ");
                }
                x = y;
                y = fibonacci;     
            }
        }
    }
}
