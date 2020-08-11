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
        public GeradorDeNotaFiscal Gerador { get; set; }
        public Mock<NFDao> Dao = new Mock<NFDao>();
        public Mock<SAP> Sap = new Mock<SAP>();

        public NotaFiscalTest()
        {
            Gerador = new GeradorDeNotaFiscal(Dao.Object, Sap.Object);
        }

        [Fact]
        public void DeveGerarNfComValorDeImpostoDescontado()
        {
            var dao = new Mock<NFDao>();
            var pedido = new Pedido("Bruno", 1000, 1);
            tdd_book.NotaFiscal.NotaFiscal nf = Gerador.Gera(pedido);

            Assert.Equal(1000 * 0.94, nf.Valor, 4);
        }

        [Fact]
        public void DevePersistirNfGerada()
        {
            var dao = new Mock<NFDao>();
            
            var pedido = new Pedido("Bruno", 1000, 1);
            var nf = Gerador.Gera(pedido);
            dao.Object.Persiste(nf);

            dao.Verify(t => t.Persiste(nf), Times.AtLeastOnce);
        }

        [Fact]
        public void DeveEnviarNfGeradaParaSap()
        {
            var dao = new Mock<NFDao>();
            var sap = new Mock<SAP>();

            var pedido = new Pedido("Bruno", 1000, 1);
            var nf = Gerador.Gera(pedido);

            sap.Object.Envia(nf);
            sap.Verify(t => t.Envia(nf));

        }
    }
}
