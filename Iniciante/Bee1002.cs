using System; 

class URI {

    static void Main(string[] args) { 

        double r, area;
        r = double.Parse(Console.ReadLine());
        area = (3.14159 * (r * r));
        Console.WriteLine("A={0:F4}", area);

    }

}
