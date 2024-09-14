using System;

namespace Area01
{
    class Teste01
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos;
            int tempo = Convert.ToInt32(Console.ReadLine());

            horas = tempo / 3600;
            minutos = (tempo - (horas * 3600))/60;
            segundos = tempo - ((horas * 3600) + (minutos * 60));

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
