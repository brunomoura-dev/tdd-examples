using tdd_book.CarrinhoDeCompras;
using Xunit;

namespace XUnitTest
{
    public class CarrinhoDeCompraTest
    {
        public Carrinho Carrinho;

        public CarrinhoDeCompraTest()
        {
            Carrinho = new Carrinho();
        }


        [Fact]
        public void DeveRetornarZeroSeCarrinho()
        {
            double valor = Carrinho.Encontra();

            Assert.Equal(0, valor, 4);
        }

        [Fact]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            Carrinho.Adiciona(new Item("Geladeira", 1, 900.00));
            double valor = Carrinho.Encontra();

            Assert.Equal(900.00, valor, 4);
        }

        [Fact]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            Carrinho.Adiciona(new Item("Geladeira", 1, 900.00));
            Carrinho.Adiciona(new Item("Fogão", 1, 1500.00));
            Carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.00));

            double valor = Carrinho.Encontra();

            Assert.Equal(1500.00, valor, 4);
        }
    }
}
