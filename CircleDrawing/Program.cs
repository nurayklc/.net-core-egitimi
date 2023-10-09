using System;

namespace CircleDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yarıçapı giriniz: ");
            int r = Convert.ToInt32(Console.ReadLine());

            cirleDrawe(r);
        }

        static void cirleDrawe(int r)
        {
            for(int i = 1; i <= r*2; i++)
            {
                for(int j = 1; j<= i; j ++)
                {
                    for(int k = 0; k<= r-j;k++)
                    {

                    Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
