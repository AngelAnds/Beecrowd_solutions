using System;

class URI // Desenvolvido por: @AngelAnds
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int num1 = Convert.ToInt32(input[0]);
        int num2 = Convert.ToInt32(input[1]);

        if (num2 % num1 == 0 || num1 % num2 == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}
