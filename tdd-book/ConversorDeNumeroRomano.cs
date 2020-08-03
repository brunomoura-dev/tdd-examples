using System.Collections.Generic;

namespace tdd_book
{
    public class ConversorDeNumeroRomano
    {
        private static readonly Dictionary<string, int> Tabela = new Dictionary<string, int>()
        {
            {"I", 1 },
            {"V", 5 },
            {"X", 10 },
            {"L", 50 },
            {"C", 100 },
            {"D", 500 },
            {"M", 1000 },
        };

        public int Converte(string numeroEmRomano)
        {
            int acumalador = 0;
            for (int i = 0; i < numeroEmRomano.Length; i++)
            {
                acumalador += Tabela[numeroEmRomano[i].ToString()];
            }
            return acumalador;
        }
    }
}