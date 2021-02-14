using System;

namespace Trabalho_9
{
    class Program
    {
        public static void PorValor(int numero)
        {
            numero++;
        }
        private static void PorReferencia(ref int numero)
        {
            numero++;
        }
        public static void Main(string[] args)
        {
            
            Console.Write("Informe um numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("          Tipo Valor         ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.Write("Valor anterior: " + numero);
            Program.PorValor(numero);
            Console.WriteLine();
            Console.WriteLine("Valor atual: " + numero);
            Console.WriteLine();

            Console.WriteLine("        Tipo Referência      ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Valor anterior: " + numero);
            Program.PorReferencia(ref numero);
            Console.WriteLine();
            Console.WriteLine("Valor Atual: " + numero);
        }
    }
}
