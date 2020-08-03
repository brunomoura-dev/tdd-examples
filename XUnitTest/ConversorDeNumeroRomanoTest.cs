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


    }
}
