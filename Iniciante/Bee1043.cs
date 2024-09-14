using System;

class URI // Desenvolvido por: @AngelAnds
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        float[] input_float = Array.ConvertAll(input, float.Parse);

        float num1 = input_float[0];
        float num2 = input_float[1];
        float num3 = input_float[2];

        if (num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1)
        {
            float area_trapezio = ((num1 + num2) * num3)/ 2.0f;
            Console.WriteLine($"Area = {area_trapezio:F1}");
        }
        else
        {
            float area_triangulo = num1 + num2 + num3;
            Console.WriteLine($"Perimetro = {area_triangulo:F1}");
        }
    }
}
