namespace tdd_book.CarrinhoDeCompras
{
    public class Item
    {
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }

        public Item(string descricao, int quantidade, double valor)
        {
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;  
        }

        public double ValorTotal => Valor * Quantidade;
    }
}