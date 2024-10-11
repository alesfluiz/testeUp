using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Principal;

namespace Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] peca1 = Console.ReadLine().Split(' ');

            int codigo = int.Parse(peca1[0]);
            int quantidade = int.Parse(peca1[1]);
            double valor = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valorP1 = quantidade * valor;

            string[] peca2 = Console.ReadLine().Split(' ');

            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2],CultureInfo.InvariantCulture);
            double valorP2 = quantidade2 * valor2;

            double total = valor + valorP2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");










            /*
            int totalSegundos, horas, minutos, segundos, resto;

            Console.Write("Digite a quantidade de segundos: ");

            totalSegundos = int.Parse(Console.ReadLine());

            horas = totalSegundos / 3600;

            resto = totalSegundos % 3600;

            minutos = resto / 60;

            resto = resto % 60;

            segundos = resto;

            Console.WriteLine($"O total de segundos digitados correspondem a hora {horas}:{minutos}:{segundos}");

            */

            /*int tipoCha = int.Parse(Console.ReadLine());
            string[] quantidade = Console.ReadLine().Split(' ');

            int acertos = 0;

            for (int i = 0; i < quantidade.Length; i++)
            {
                int tipoAtual = int.Parse(quantidade[i]);
                if (tipoAtual == tipoCha)
                {
                    acertos++;
                }
            }
            Console.WriteLine(acertos);*/
        }
    }

}
