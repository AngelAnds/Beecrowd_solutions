using System;

namespace Area01
{
    class Teste01
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;

            tempo = Convert.ToInt32(Console.ReadLine());
            velocidade = Convert.ToInt32(Console.ReadLine());

            float gasto = (tempo * velocidade) / 12.0f;

            Console.WriteLine($"{gasto:f3}");

        }
    }
}
