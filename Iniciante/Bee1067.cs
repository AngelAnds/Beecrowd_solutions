using System;

class URI // Desenvolvido por: @AngelAnds
{
    static void Main(string[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int c = 1; c <= numero; c++)
        {
            if (!(c % 2 == 0))
            {
                Console.WriteLine(c);
            }
        }
      
    }
}
