using System;

namespace StringAndInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime ve bir sayıyı aralarında virgül ile giriniz: ");
            var str = Console.ReadLine();

            RemoveChar(str);
        }

        static void RemoveChar(string str)
        {
            var newStr = str.Split(",");

            var word = newStr[0].ToString();
            var number = Convert.ToInt32(newStr[1]);

            word = word.Remove(number, 1);

            Console.WriteLine(word);
        }
    }
}
