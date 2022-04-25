using System.Security.Cryptography;
using System.Globalization;
using System;
using System.Collections;

ArrayList primeList = new ArrayList();
ArrayList notPrimeList = new ArrayList();

// Girdi Alma
Console.WriteLine("20 Adet Sayı Giriniz: ");
for(int i = 0; i < 20; i++){
    Console.WriteLine(i + ". Sayınızı Giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());
    bool result = n.isPositive();
    bool result2 = n.isNumeric();
    bool result3 = n.isPrime();
    if( result && result2 && result3){
        primeList.Add(n);
    }
    if( result && result2){
        if(result3 == false){
            notPrimeList.Add(n);
        }
    }
}

// Listeleme
primeList.Sort();
foreach (var item in primeList)
{
    Console.WriteLine(item);
}

notPrimeList.Sort();
foreach (var item in notPrimeList)
{
    Console.WriteLine(item);
}



// Extension Methods
public static class Extension{
    public static bool isPositive(this int number){
        return number > 0;
    }

    public static bool isNumeric(this int number){
        int temp = 0;
        return int.TryParse(number, out temp); 
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