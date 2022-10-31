using System;
using System.Collections.Generic;

namespace CharReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            var str = Console.ReadLine();

            var newStr = str.Split(" ");
            for(int i= 0; i < newStr.Length; i++)
            {
                var result = Reverse(newStr[i]);
                Console.Write(result + " ");
            }
        }

        static string Reverse(string str)
        {
            var res = "";
            for (int j = str.Length -1 ; j >= 0; j--)
            {
                res += str[j];
            }
            return res;
        }
    }
}
