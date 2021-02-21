using System;
using System.Collections.Generic;

namespace ControlProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int quantityProducts = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantityProducts; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Product #" + (i+1) + " data:");
                Console.Write("Common,used or imported (c/u/i)?: ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(answer == 'i' || answer == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(answer == 'u' || answer == 'U')
                {
                    Console.Write("Manufacture date (MM/DD/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (answer == 'c' || answer == 'C')
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            foreach(Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
