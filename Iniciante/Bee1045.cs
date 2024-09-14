using System;

namespace testes // Desenvolvido por: @AngelAnds
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            float A1, B1, C1;

            float A = float.Parse(valores[0]);
            float B = float.Parse(valores[1]);
            float C = float.Parse(valores[2]);

            if (A >= B && A >= C)
            {
                A1 = A;

                if (B >= C)
                {
                    B1 = B;
                    C1 = C;
                }

                else
                {
                    B1 = C;
                    C1 = B;
                }
            }
            else if (B >= A && B >= C)
            {
                A1 = B;

                if (A >= C)
                {
                    B1 = A;
                    C1 = C;
                }
                else
                {
                    B1 = C;
                    C1 = A;
                }
            }
            else
            {
                A1 = C;

                if (A >= B)
                {
                    B1 = A;
                    C1 = B;
                }

                else
                {
                    B1 = B;
                    C1 = A;
                }

            } // não me orgulho dessa teia de letras

            if (A1 >= (B1 + C1))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else
            {
                if (Math.Pow(A1, 2) == Math.Pow(B1, 2) + Math.Pow(C1, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(A1, 2) > Math.Pow(B1, 2) + Math.Pow(C1, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(A1, 2) < Math.Pow(B1, 2) + Math.Pow(C1, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A1 == B1 && B1 == C1)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if (A1 == B1 && A1 != C1)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (A1 == C1 && A1 != B1)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (B1 == C1 && B1 != A1)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
