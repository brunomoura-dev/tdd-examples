using System;
using System.Collections.Generic;
using System.Text;
using tdd_book;
using tdd_book.NotaFiscal;
using Xunit;

namespace XUnitTest.NotaFiscal
{
    public class NotaFiscalTest
    {

        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal();
            var pedido = new Pedido("Bruno", 1000, 1);
            tdd_book.NotaFiscal.NotaFiscal nf = gerador.Gera(pedido);

            Assert.Equal(1000 * 0.94, nf.Valor, 4);
        }
    }
}
