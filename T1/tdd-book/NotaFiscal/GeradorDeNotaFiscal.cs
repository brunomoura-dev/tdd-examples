using System;
using tdd_book.NotaFiscal;

namespace tdd_book
{
    public class GeradorDeNotaFiscal
    {
        private readonly NFDao _dao;
        private readonly SAP _sap;

        public GeradorDeNotaFiscal(NFDao dao, SAP sap)
        {
            _dao = dao;
            _sap = sap;
        }

        public NotaFiscal.NotaFiscal Gera(Pedido pedido)
        {
            var nf = new NotaFiscal.NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, 
                DateTime.Now);
            _dao.Persiste(nf);
            _sap.Envia(nf);

            return nf;
        }
    }
}