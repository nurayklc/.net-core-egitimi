using System;

namespace FibonacciAverageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen derinlik sayısını giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            float result = FibonnacciSum(number);
            Console.WriteLine($"{number}. derinliğine kadar olan fibonacci sayıların ortalaması: " + result);
           
        }

        static float FibonnacciSum(int num)
        {
            int first = 1;
            int second = 1;
            int sum = first + second;
            int result = 0;


            for (int i = 0; i < num - 2; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
                //Console.WriteLine(sum + "sum");
                result += sum;
                //Console.WriteLine(result + "res");
            }
            return Average(result, num);
        }

        static float Average(int s, int num)
        {
            return (float) (s + 2) / num ;
        }
    }
}
