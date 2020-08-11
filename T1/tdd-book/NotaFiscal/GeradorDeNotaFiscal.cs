using System;
using tdd_book.NotaFiscal;

namespace tdd_book
{
    public class GeradorDeNotaFiscal
    {
        public NotaFiscal.NotaFiscal Gera(Pedido pedido)
        {
            return new NotaFiscal.NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, 
                DateTime.Now);
        }
    }
}