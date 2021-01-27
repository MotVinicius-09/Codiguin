using System;
using System.Globalization;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (S/N) : ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com um valor para deposito: ");
                double valDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, nomeTitular, valDeposito);
            }
            else
            {
                conta = new ContaBancaria(numConta, nomeTitular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);   
            





        }
    }
}