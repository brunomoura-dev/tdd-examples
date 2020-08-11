using System;

namespace tdd_book.NotaFiscal
{
    public class Pedido
    {
        public string Cliente { get; }
        public double ValorTotal { get; }
        public int QuantidadeItens { get; }

        public Pedido(string cliente, double valorTotal, int quantidadeItens)
        {
            Cliente = cliente;
            ValorTotal = valorTotal;
            QuantidadeItens = quantidadeItens;
        }
    }
}
