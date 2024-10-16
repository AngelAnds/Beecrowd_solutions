using System;

namespace TESTES //@AngelAnds
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int valorReal;


            Console.WriteLine($"{valor}");
            Console.WriteLine($"{valor/100} nota(s) de R$ 100,00");
            valorReal = valor % 100;

            Console.WriteLine($"{valorReal / 50} nota(s) de R$ 50,00");
            valorReal = valorReal % 50;

            Console.WriteLine($"{valorReal / 20} nota(s) de R$ 20,00");
            valorReal = valorReal % 20;

            Console.WriteLine($"{valorReal / 10} nota(s) de R$ 10,00");
            valorReal = valorReal % 10;

            Console.WriteLine($"{valorReal / 5} nota(s) de R$ 5,00");
            valorReal = valorReal % 5;

            Console.WriteLine($"{valorReal / 2} nota(s) de R$ 2,00");
            valorReal = valorReal % 2;

            Console.WriteLine($"{valorReal} nota(s) de R$ 1,00");
        }
    }
}
