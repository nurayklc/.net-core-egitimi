using System;

namespace TriangleDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen boyut sayısını giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            triangle(number);
        }
        static void triangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= number; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
