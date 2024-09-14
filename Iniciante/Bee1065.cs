using System;

class URI // Desenvolvido por: @AngelAnds
{

    static void Main(string[] args)
    {

        int[] valores = new int[5];
        int soma = 0;

        for (int c = 0; c < valores.Length; c++)
        {
            valores[c] = Convert.ToInt32(Console.ReadLine());
            
            if (valores[c] % 2 == 0)
            {
                soma += 1;
            }
        }

        Console.WriteLine($"{soma} valores pares");
    }

}
