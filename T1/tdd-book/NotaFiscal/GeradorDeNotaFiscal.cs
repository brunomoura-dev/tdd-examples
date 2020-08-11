using System;
using tdd_book.NotaFiscal;

namespace tdd_book
{
    public class GeradorDeNotaFiscal
    {
        private readonly NFDao _dao;

        public GeradorDeNotaFiscal(NFDao dao)
        {
            _dao = dao;
        }

        public NotaFiscal.NotaFiscal Gera(Pedido pedido)
        {
            var nf = new NotaFiscal.NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, 
                DateTime.Now);
            new NFDao().Persiste(nf);

            return nf;
        }
    }
}