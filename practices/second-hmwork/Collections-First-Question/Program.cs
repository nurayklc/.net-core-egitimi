using System.Security.Cryptography;
using System.Globalization;
using System;
using System.Collections;

ArrayList primeList = new ArrayList();
ArrayList notPrimeList = new ArrayList();

// Girdi Alma
Console.WriteLine("Please enter positive 20 number!!");
for(int i = 0; i < 20; i++){
    back:
    try
    {
        Console.WriteLine(i+1 + ". Number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if(!n.isPositive()){
            Console.WriteLine("Not negative number!!");
            goto back;
        }
        bool result = n.isPrime();
        if(result)
            primeList.Add(n);
        else
            notPrimeList.Add(n);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Not negative number and numeric number!!");
        goto back;
    }
}

// Listeleme
primeList.Sort();
int primeMedium = 0;
Console.WriteLine("-- Prime Number List --");
foreach (var item in primeList)
{
    primeMedium += Convert.ToInt32(item);
    Console.WriteLine(item);
}
Console.WriteLine("Prime List Length: " + primeList.Count);
Console.WriteLine("Prime List Medium: " + Convert.ToInt32(primeMedium / primeList.Count));

notPrimeList.Sort();
int notPrimeMedium = 0;
Console.WriteLine("-- Not Prime Number List --");
foreach (var item in notPrimeList)
{
    notPrimeMedium += Convert.ToInt32(item);
    Console.WriteLine(item);
}

Console.WriteLine("Not Prime List Length: " + notPrimeList.Count);
Console.WriteLine("Not Prime List Medium: " + Convert.ToInt32(notPrimeMedium / notPrimeList.Count));


// Extension Methods
public static class Extension{
    public static bool isPositive(this int number){
        return number > 0;
    }

    public static bool isPrime(this int number){
        bool temp = true;
        for (int i = 2; i < number; i++)
        {
            if(number % i == 0) temp = false;
        }
        return temp;
    }
}