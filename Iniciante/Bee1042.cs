using System;

namespace Testes // Desenvolvido por: @AngelAnds
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] vetor = Array.ConvertAll(input, int.Parse);

            int num_temp;

            for (int cont1 = 0; cont1 < vetor.Length; cont1++)
            {
                for (int cont2 = cont1; cont2 < vetor.Length; cont2++)
                {
                    if (vetor[cont1] > vetor[cont2])
                    {
                        num_temp = vetor[cont1];
                        vetor[cont1] = vetor[cont2];
                        vetor[cont2] = num_temp;
                    }
                }
                Console.WriteLine(vetor[cont1]);
            }

            Console.WriteLine("");

            for (int cont = 0; cont < input.Length;  cont++)
            {
                Console.WriteLine(input[cont]);
            }
        }
    }
}
