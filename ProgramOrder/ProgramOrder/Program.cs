using System;

namespace ProgramOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);


            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(moment, status,client);
            
            Console.Write("How many items to this order?: ");
            int quantItems = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantItems; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderitem = new OrderItem(quantity, productPrice,product);
                order.addItem(orderitem);
                
                Console.WriteLine();

            }
            Console.WriteLine("ORDER SUMARY: ");
            Console.WriteLine(order);
        }
    }
}
