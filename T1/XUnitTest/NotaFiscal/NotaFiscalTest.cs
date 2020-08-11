using Moq;
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
        [Fact]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            var dao = new Mock<NFDao>();
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);
            var pedido = new Pedido("Bruno", 1000, 1);
            tdd_book.NotaFiscal.NotaFiscal nf = gerador.Gera(pedido);

            Assert.Equal(1000 * 0.94, nf.Valor, 4);
        }

        [Fact]

        public void DevePersistirNFGerada()
        {
            var dao = new Mock<NFDao>();
            
            var gerador = new GeradorDeNotaFiscal(dao.Object);
            var pedido = new Pedido("Bruno", 1000, 1);
            var nf = gerador.Gera(pedido);
            dao.Object.Persiste(nf);

            dao.Verify(t => t.Persiste(nf), Times.AtLeastOnce);
        }
    }
}
