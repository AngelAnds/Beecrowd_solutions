using System; 

class URI {

    static void Main(string[] args) { 

        int cod, t;
        double sp, s;

        cod = int.Parse(Console.ReadLine());
        t = int.Parse(Console.ReadLine());
        sp = double.Parse(Console.ReadLine());

        s = (t * sp);

        Console.WriteLine("NUMBER = {0}", cod);
        Console.WriteLine("SALARY = U$ {0:F2}", s);

    }

}
