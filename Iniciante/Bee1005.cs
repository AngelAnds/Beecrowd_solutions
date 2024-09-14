using System; 

class URI {

    static void Main(string[] args) { 

        double a, b, x;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        x = ((a * 3.5) + (b * 7.5)) / 11;
        Console.WriteLine("MEDIA = {0:F5}", x);

    }

}
