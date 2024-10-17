using System;

namespace URI //@AngelAnds 1035
{
    class Program
    {
        static void Main(string[] agrs)
        {
            string[] input = Console.ReadLine().Split(' ');

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int D = int.Parse(input[3]);

            if (B > C && D > A && C + D > B + A && C >= 0 && D >= 0 && A % 2 ==0)
            {
                Console.WriteLine($"Valores aceitos");
            }
            else
            {
                Console.WriteLine($"Valores nao aceitos");
            }
        }
    }
}
