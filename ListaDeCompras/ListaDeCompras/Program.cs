using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ListaDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----LISTA-DE-COMPRAS----");
            Console.WriteLine("Itens no estoque: Alimento,Bebida,Limpeza e Fruta");
            Console.WriteLine();

            Console.Write("Quantos produtos você vai levar?: ");
            int quantItem = int.Parse(Console.ReadLine());

            List<Lista> listaDeCompras = new List<Lista>(quantItem);


            for (int i = 0; i < quantItem; i++)
            {
                Random idAleat = new Random();
                int id = idAleat.Next(100, 999);

                Console.WriteLine();
                Console.WriteLine("Digite o " + (i + 1) + "°" + "Item:");
                Console.Write("Produto: ");
                string produto = Console.ReadLine();

                Console.Write("Tipo do produto: ");
                string tipoDoProduto = Console.ReadLine();

                Console.Write("Quantidade do produto: ");
                double quantProd = double.Parse(Console.ReadLine());

                double preco = 0;
                double precoFinal = 0;
                switch (tipoDoProduto)
                {
                    case "Alimento":
                        preco = 3.00;
                        precoFinal = preco * quantProd;
                        break;
                    case "Limpeza":
                        preco = 5.00;
                        precoFinal = preco * quantProd;
                        break;
                    case "Fruta":
                        preco = 1.00;
                        precoFinal = preco * quantProd;
                        break;
                    case "Bebida":
                        preco = 2.00;
                        precoFinal = preco * quantProd;
                        break;
                }
                listaDeCompras.Add(new Lista(produto, tipoDoProduto, id, preco, quantProd, precoFinal));
            }

            Console.Clear();
            Console.WriteLine();
            List<Lista> listaAlimentos = listaDeCompras.FindAll(x => x.ClassProduct == "Alimento");
            Console.WriteLine("--Lista de Alimento--");
            foreach (Lista p in listaAlimentos)
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
            Console.WriteLine("--Lista de Frutas--");
            foreach (Lista p in listaFruta)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine("--------------Total-a-pagar---------------");
            int soma = listaDeCompras.Sum(x => Convert.ToInt32(x.TotalPrice));
            double total = Convert.ToDouble(soma);
            Console.WriteLine("Total a pagar: R$" + total.ToString("F2"));
        }

    }
}
