using System;

namespace testes
{
    class URI // Desenvolvido por: @AngelAnds
    {
        static void Main(string[] args)
        {
            string[] tempos = Console.ReadLine().Split(' ');

            int hora01 = int.Parse(tempos[0]);
            int hora02 = int.Parse(tempos[1]);

            if (hora01 > hora02)
            {
                Console.WriteLine($"O JOGO DUROU {(24 - hora01) + hora02} HORA(S)");
            } 
            else if (hora02 > hora01)
            {
                Console.WriteLine($"O JOGO DUROU {hora02 - hora01} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
            }
        }
    }
}
