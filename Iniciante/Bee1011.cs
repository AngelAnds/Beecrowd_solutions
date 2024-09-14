using System;

class program
{
    static void Main()
    {
        double raio = double.Parse(Console.ReadLine());
        Console.WriteLine("VOLUME = {0:F3}", (4 / 3.0) * Math.Pow(raio, 3) * 3.14159);
    }
}
