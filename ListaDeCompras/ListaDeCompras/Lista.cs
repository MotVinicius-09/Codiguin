using System;
using System.Globalization;

namespace ListaDeCompras
{
    class Lista
    {
        public string Product { get; set; }
        public string ClassProduct { get; set; }
        public int Id { get; set; }
        public double Price {private get; set; }
        public double TotalPrice { private get;  set; }
        public double QuantProd { get; set; }

        public Lista (string product, string classProduct, int id, double preco, double quantProd)
        {
            Product = product;
            ClassProduct = classProduct;
            Id = id;
            Price = preco;
            QuantProd = quantProd;
        }
        
        public void ValorTotal()
        {
            TotalPrice = Price * TotalPrice;
        }
        public override string ToString()
        {
            return "Id: " + Id
                + ", Produto: " + Product
                + ", Classificação: " + ClassProduct
                + ", Preço Unidade: R$" + Price.ToString("F2")
                + ", Preço Total: R$" + TotalPrice.ToString("F2");

        }
    }
}
