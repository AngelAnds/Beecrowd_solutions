using System;
namespace URI //@AngelAnds 1070
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int numero = int.Parse(Console.ReadLine());
            int impares;

            if (numero % 2 == 0)
            {
                impares = numero + 1;
            }
            else
            {
                impares = numero;
            }

            for (int c = 0; c < 6; c++)
            {
                Console.WriteLine(impares);
                impares += 2;
            }
        }
    }
}
