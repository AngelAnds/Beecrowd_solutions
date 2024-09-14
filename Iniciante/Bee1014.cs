using System;

class program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
      
        float y = float.Parse(Console.ReadLine());
      
        Console.WriteLine("{0:F3} km/l", (x / y));
    }

}
