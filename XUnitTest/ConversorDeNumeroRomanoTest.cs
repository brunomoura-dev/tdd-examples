using System;
using tdd_book;
using Xunit;

namespace XUnitTest
{
    public class ConversorDeNumeroRomanoTest
    {
        

        [Fact]
        public void DeveEntenderOSimboloI()
        {

            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");

            Assert.Equal(1, numero);
        }

        [Fact]
        public void DeveEntenderOSimboloV()
        {

            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");

            Assert.Equal(5, numero);
        }

        [Fact]
        public void DeveEntenderOSimboloII()
        {

            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");

            Assert.Equal(2, numero);
        }

        [Fact]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");

            Assert.Equal(22, numero);
        }

        [Fact]
        public void DeveEntenderNumerosComoIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IX");

            Assert.Equal(9, numero);
        }

        [Fact]
        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXIV");

            Assert.Equal(24, numero);
        }
    }
}
