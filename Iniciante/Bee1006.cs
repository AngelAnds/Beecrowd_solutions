using System; 

class URI {

    static void Main(string[] args) { 

        
        double a, b, c, m;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        m = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0;
        Console.WriteLine("MEDIA = {0:F1}", m);

    }

}
