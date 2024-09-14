using System;

namespace Area01
{
    class Teste01
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            int tempo = Convert.ToInt32(Console.ReadLine());

            anos = tempo / 365;
            meses = (tempo - (anos * 365))/30;
            dias = tempo - ((anos * 365) + (meses * 30));

            Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
          
        }
    }
}
