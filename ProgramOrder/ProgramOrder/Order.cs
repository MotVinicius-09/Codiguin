using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramOrder
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
        


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client.Name + "(" + Client.BirthDay.ToString("dd/MM/yyyy") + ")" + " - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.Product.Name + ", " + "Quantity: " + item.Quantity + ", " + "Subtotal: $" + item.SubTotal());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            

            return sb.ToString();

        }



    }
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }
    }

    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price,Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;

        }

        public double SubTotal()
        {
            return Quantity * Price;
        }



    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }

    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }

}
