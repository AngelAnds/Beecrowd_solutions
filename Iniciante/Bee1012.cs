using System;

class program
{
    static void Main()
    {
        string[] t = Console.ReadLine().Split(' ');

        double a = double.Parse(t[0]);
        double b = double.Parse(t[1]);
        double c = double.Parse(t[2]);

        Console.WriteLine("TRIANGULO: {0:F3}", (a * c) / 2.0);
        Console.WriteLine("CIRCULO: {0:F3}", 3.14159 * Math.Pow(c, 2.0));
        Console.WriteLine("TRAPEZIO: {0:F3}", ((a + b)*c) / 2.0);
        Console.WriteLine("QUADRADO: {0:F3}", Math.Pow(b, 2.0));
        Console.WriteLine("RETANGULO: {0:F3}", a * b);

    }
}
