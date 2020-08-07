using System;

namespace tdd_book.CalculoSalario
{
    public class CalculadoraSalario
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo != Cargo.DESENVOLVEDOR) return funcionario.Salario * 0.85;
            if (funcionario.Salario > 3000)
                return funcionario.Salario * 0.8;

            return funcionario.Salario * 0.9;

        }
    }
}