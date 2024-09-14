using System;

class program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        double s = double.Parse(Console.ReadLine());
        double cm = double.Parse(Console.ReadLine());

        double ss = s + ((15.0 / 100.0) * cm);

        Console.WriteLine("TOTAL = R$ {0:F2}", ss);
    }
}
