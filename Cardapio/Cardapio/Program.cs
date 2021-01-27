using System;
using System.Globalization;

namespace Cardapio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("restaurante - barriga cheia");
            Console.WriteLine("[1] Cachorro-quente R$ 3.00");
            Console.WriteLine("[2] tapioca         R$ 1.50");
            Console.WriteLine("[3] hamburguer      R$ 2.50");
            Console.WriteLine("[4] refrigerante    R$ 2.00");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Ola, quantos itens irá pedir?");
            int quantItem = int.Parse(Console.ReadLine());

            Pedido[] pedido = new Pedido[quantItem];
            string nomeProd;
            double precoProd = 0.0;
            for (int cont = 0; cont < quantItem; cont++)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o codigo do item:");
                int item = int.Parse(Console.ReadLine());
                
                switch(item)
                {
                    case 1:
                        nomeProd = "Cachorro-quente";
                        precoProd = 3.00;
                        pedido[cont] = new Pedido(nomeProd, precoProd);
                        break;

                    case 2:
                        nomeProd = "Tapioca";
                        precoProd = 1.50;
                        pedido[cont] = new Pedido(nomeProd, precoProd);
                        break;
                    case 3:
                        nomeProd = "Hamburguer";
                        precoProd = 2.50;
                        pedido[cont] = new Pedido(nomeProd, precoProd);
                        break;
                    case 4:
                        nomeProd = "Refrigerante";
                        precoProd = 2.00;
                        pedido[cont] = new Pedido(nomeProd, precoProd);
                        break;
                }
            }

            double soma = 0.0;
            for (int cont = 0; cont < quantItem; cont++)
            {
                soma += pedido[cont].PrecoProd;

            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Valor total a pagar:");
            for(int cont = 0; cont < quantItem; cont++)
            {
                Console.WriteLine(cont + ":" + pedido[cont].NomeProd);
            }
            Console.WriteLine("TOTAL: R$" + soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------");
            









        }
    }
}
