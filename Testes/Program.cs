using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalSegundos, horas, minutos, segundos, resto;

            Console.Write("Digite a quantidade de segundos: ");

            totalSegundos = int.Parse(Console.ReadLine());

            horas = totalSegundos / 3600;

            resto = totalSegundos % 3600;

            minutos = resto / 60;

            resto = resto % 60;

            segundos = resto;

            Console.WriteLine($"O total de segundos digitados correspondem a hora {horas}:{minutos}:{segundos}");



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
