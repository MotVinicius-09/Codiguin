using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----LISTA-DE-COMPRAS----");
                Console.Write("Quantos produtos você vai levar?: ");
                int quantItem = int.Parse(Console.ReadLine());

            List<Lista> listaDeCompras = new List<Lista>(quantItem);
            
            
            for(int i = 0; i < quantItem; i++)
            {
                Random idAleat = new Random();
                int id = idAleat.Next(100, 999);

                Console.WriteLine();
                Console.WriteLine("Digite o " + (i + 1)  + "°" +"Item:");
                Console.Write("Produto: ");
                string produto = Console.ReadLine();
                
                Console.Write("Tipo do produto: ");
                string tipoDoProduto = Console.ReadLine();

                Console.Write("Quantidade do produto: ");
                double quantProd = double.Parse(Console.ReadLine());
                   
                double preco = 0;
                switch(tipoDoProduto)
                {
                    case "Alimento":
                        preco = 3.00;
                        break;
                    case "Limpeza":
                        preco = 5.00;
                        break;
                    case "Fruta":
                        preco = 1.00;
                        break;
                    case "Bebida":
                        preco = 2.00;
                        break;
                }
                listaDeCompras.Add(new Lista(produto, tipoDoProduto,id,preco,quantProd));
            }

            Console.WriteLine();
            List<Lista> listaAlimentos = listaDeCompras.FindAll(x => x.ClassProduct == "Alimento");
            Console.WriteLine("----Lista de Alimento----");
            foreach(Lista p in listaAlimentos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            List<Lista> listaBebidas = listaDeCompras.FindAll(x => x.ClassProduct == "Bebida");
            Console.WriteLine("--Lista de Bebidas--");
            foreach (Lista p in listaBebidas)
            {
                Console.WriteLine(p);
            }
            
            Console.WriteLine();
            List<Lista> listaLimpeza = listaDeCompras.FindAll(x => x.ClassProduct == "Limpeza");
            Console.WriteLine("--Lista de Limpeza--");
            foreach (Lista p in listaLimpeza)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            List<Lista> listaFruta = listaDeCompras.FindAll(x => x.ClassProduct == "Fruta");
            Console.WriteLine("--Lista de Fruta--");
            foreach (Lista p in listaFruta)
            {
                Console.WriteLine(p);
            }
        }
    }
}
