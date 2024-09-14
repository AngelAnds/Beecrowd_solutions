using System;

class program
{
    static void Main()
    {
        string[] cp1 = Console.ReadLine().Split(' ');
        string[] cp2 = Console.ReadLine().Split(' ');

        double d1 = double.Parse(cp1[2]);
        double q1 = double.Parse(cp1[1]);
        double d2 = double.Parse(cp2[2]);
        double q2 = double.Parse(cp2[1]);
        
        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", (d1 * q1) + (d2 * q2));
    }
}
