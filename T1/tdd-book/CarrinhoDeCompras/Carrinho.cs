using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tdd_book.CarrinhoDeCompras
{
    public class Carrinho
    {
        public IList<Item> Itens { get; private set; }

        public Carrinho()
        {
            Itens = new List<Item>();
        }

        public void Adiciona(Item item)
        {
            Itens.Add(item);
        }

        public double Encontra()
        {
            if (Itens.Count == 0) return 0;

            return Itens.Select(item => item.ValorTotal).Max();
        }
    }
}
