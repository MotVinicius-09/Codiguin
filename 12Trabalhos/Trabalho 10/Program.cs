using System;

namespace Trabalho_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program nProgram = new Program();
            {
                Console.WriteLine("Digite um numero: ");
                string numero = Console.ReadLine();
                int tamanho = numero.Length;
                int num = int.Parse(numero);
                nProgram.Calcula(num, tamanho);
            }
        }
        private void Calcula(int numero, int tamanho)
        {
            int a;
            int soma = 0;

            for (int i = 1; i <= tamanho; i++)
            {
                a = numero % 10;
                numero = numero / 10;
                Console.Write(a);

                if (tamanho > i)
                {
                    Console.Write(" + ");

                }
                soma = soma + a;
            }
            Console.WriteLine(" = " + soma);
        }
    }
}
