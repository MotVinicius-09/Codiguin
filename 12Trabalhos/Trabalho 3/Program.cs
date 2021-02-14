using System;

namespace Trabalho_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer a tabela ansci

            Console.WriteLine("Tabela ANSCI");
            for (int i = 11; i <= 255; i++)
            {
                char carac = Convert.ToChar(i);
                Console.WriteLine(i + " = " + carac);
            }
        }
    }
}
