using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Entities
{
    internal class Peca
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public List<Peca> Pecas { get; set; }

        public Peca()
        {
        }

        public Peca(int codigo, int quantidade, double valor)
        {
            Codigo = codigo;
            Quantidade = quantidade;
            Preco = valor;
        }
        public void AdicionarPecas(string[] peca)
        {
            Codigo = int.Parse(peca[0]);
            Quantidade = int.Parse(peca[1]);
            Preco = double.Parse(peca[2], CultureInfo.InvariantCulture);
        }

        

        public double ValorTotal()
        {
            double precoItem = Quantidade * Preco;
            return precoItem;
        }

    }
}
