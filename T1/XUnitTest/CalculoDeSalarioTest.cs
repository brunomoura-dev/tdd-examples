using tdd_book.CalculoSalario;
using Xunit;

namespace XUnitTest
{
    public class CalculoDeSalarioTest
    {

        [Fact]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAte3000()
        {
            CalculadoraSalario calculadora = new CalculadoraSalario();

            var desenvolvedor = new Funcionario("Bruno", 1500, Cargo.DESENVOLVEDOR);
            double salario = calculadora.CalcularSalario(desenvolvedor);

            Assert.Equal(1500*0.9, salario, 1);
        }

        [Fact]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioMaiorOuIgual3000()
        {
            var valor = 4000;
            var desconto = 0.8;
            CalculadoraSalario calculadora = new CalculadoraSalario();

            var desenvolvedor = new Funcionario("Bruno", valor, Cargo.DESENVOLVEDOR);
            double salario = calculadora.CalcularSalario(desenvolvedor);

            Assert.Equal(valor * desconto, salario, 1);
        }

        [Fact]
        public void DeveCalcularSalarioParaDBAComSalarioComSalarioAte2500()
        {
            var valor = 500;
            var desconto = 0.85;
            CalculadoraSalario calculadora = new CalculadoraSalario();

            var dba = new Funcionario("Bruno", valor, Cargo.DBA);
            double salario = calculadora.CalcularSalario(dba);

            Assert.Equal(valor * desconto, salario, 1);
        }



    }
}
