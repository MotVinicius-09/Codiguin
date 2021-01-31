using System;

namespace ConversorDeBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*----------------------*");
            Console.WriteLine("*=Conversor de binario=*");
            Console.WriteLine("[1] Binario para decimal");
            Console.WriteLine("[2] Decimal para binario");
            Console.WriteLine("*----------------------*");
            Console.Write("Opcao:");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Console.Write("Digite o numero: ");
                    string numero = Console.ReadLine();
                    int resultadoBD = Conversor.BinarioParaDecimal(numero);
                    Console.WriteLine("O valor " + numero + " convertido em binario é " + resultadoBD);

                    break;
                case 2:
                    Console.Write("Digite o numero: ");
                    numero = Console.ReadLine();
                    Conversor.DecimalParaBinario(numero);
                    string resultadoDB  = Conversor.DecimalParaBinario(numero);
                    Console.WriteLine("O valor " + numero + " convertido em binario é " + resultadoDB);
                    break;
            }

            


        }
    }
}
