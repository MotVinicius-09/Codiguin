using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
         {
            Aluguel[] vet = new Aluguel[10];
            
            Console.Write("Quantos quartos vão ser alugados?: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int cont = 1; cont <= quartos; cont++)
            {
                Console.WriteLine("Inquilino #" + cont);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vet[quarto] = new Aluguel(nome, email);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for (int cont = 0; cont < 10; cont++)
            {
                if (vet[cont] != null)
                {
                    Console.WriteLine(cont + ": " + vet[cont]);
                }
            }
              


        }
    }
}
