using System;

namespace tdd_book.NotaFiscal
{
    public class NotaFiscal
    {
        public string Cliente { get; }
        public double Valor { get; }
        public DateTime Data { get; }

        public NotaFiscal(string cliente, double valor, DateTime data)
        {
            Cliente = cliente;
            Valor = valor;
            Data = data;
        }
    }
}
