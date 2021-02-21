using System;
using System.Collections.Generic;
using System.Text;

namespace ControlProduct
{
    class Product
    {
        public string  Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2");
        }
    }
    
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }
    }

    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price , DateTime manufactureDate) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("MM/dd/yyyy") + ")";
        }
    }
}
