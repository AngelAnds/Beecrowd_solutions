using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');

        int cod = Convert.ToInt32(valores[0]);
        int qtd = Convert.ToInt32(valores[1]);

        if (cod == 1)
        {
            Console.WriteLine($"Total: R$ {qtd * 4.00:F2}");
        }
        else if (cod == 2)
        {
            float valor = qtd * 4.5f;
            Console.WriteLine($"Total: R$ {valor:F2}");
        }
        else if (cod == 3)
        {
            Console.WriteLine($"Total: R$ {qtd * 5.00:F2}");
        }
        else if (cod == 4)
        {
            Console.WriteLine($"Total: R$ {qtd * 2.00:F2}");
        }
        else if (cod == 5)
        {
            float valor = qtd * 1.5f;
            Console.WriteLine($"Total: R$ {valor:F2}");
        }

    }

}
