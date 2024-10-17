using System;
namespace URI //@AngelAnds 1113
{
    class Program
    {
        static void Main(string[] agrs)
        {
            string[] input = new string[] { };
            int numeroA, numeroB;

            do
            {
                input = Console.ReadLine().Split(' ');

                numeroA = int.Parse(input[0]);
                numeroB = int.Parse(input[1]);

                if (numeroA == numeroB)
                {
                    break;
                }
                else if (numeroA > numeroB)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }while (true);
        }
    }
}
