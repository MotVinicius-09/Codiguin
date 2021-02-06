using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDeCompras
{
    class Lista
    {
        public string Product { get; set; }
        public string ClassProduct { get; set; }

        public Lista (string product, string classProduct)
        {
            Product = product;
            ClassProduct = classProduct;
        }

        public override string ToString()
        {
            return "Produto: " + Product
                + ", Classificação: " + ClassProduct;

        }
    }
}
