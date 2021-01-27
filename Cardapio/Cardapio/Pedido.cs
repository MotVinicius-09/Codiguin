
namespace Cardapio
{
    class Pedido
    {
        public string NomeProd { get; set; }
        public double PrecoProd { get; set; }

        public Pedido(string nomeProd, double precoProd)
        {
            NomeProd = nomeProd;
            PrecoProd = precoProd;
        }
    }
}
