using System.Linq;
using tdd_book.CarrinhoDeCompras;

namespace tdd_book
{
    public class MaiorPreco
    {
        public MaiorPreco()
        {
        }

        public double Encontra(Carrinho carrinho)
        {
            if (carrinho.Itens.Count == 0) return 0;

            return carrinho.Itens.Select(item => item.ValorTotal).Max();
        }
    }
}