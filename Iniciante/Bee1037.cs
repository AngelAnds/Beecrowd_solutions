using System;
namespace URI //@AngelAnds 1037
{
    class Program
    {
        static void Main(string[] agrs)
        {
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0.00 && valor <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25.00 && valor <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor > 50.00 && valor <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor > 75.00 && valor <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
