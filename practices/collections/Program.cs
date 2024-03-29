﻿using System.Collections.Generic;
using System.Collections;
// See https://aka.ms/new-console-template for more information

// Collections
// List<T> class
// Sytem.Collections.Generic Kütüphanesinden gelir
// T-> object türündedir. Listedeki elemanlarının tipini belirtiyor

List<int> numberList = new List<int>();

numberList.Add(55);
numberList.Add(11);
numberList.Add(44);
numberList.Add(33);
numberList.Add(22);
numberList.Add(66);

List<string> colorsList = new List<string>();

colorsList.Add("Mavi");
colorsList.Add("Kırmızı");
colorsList.Add("Sarı");
colorsList.Add("Turuncu");
colorsList.Add("Yeşil");

// Count - Listenin eleman sayısı
Console.WriteLine(numberList.Count);
Console.WriteLine(colorsList.Count);

// Listeleme
foreach (var item in numberList)
{
    Console.WriteLine(item);
}

foreach (var item in colorsList)
{
   Console.WriteLine(item);
}

// List.ForEach ile Listeleme
numberList.ForEach(number => Console.WriteLine(number));
colorsList.ForEach(color => Console.WriteLine(color));


// Listeden Eleman Çıkarma
numberList.Remove(11);
colorsList.Remove("Yeşil");

// Indexe göre eleman çıkarma
numberList.RemoveAt(0);
colorsList.RemoveAt(2);

numberList.ForEach(number => Console.WriteLine(number));
colorsList.ForEach(color => Console.WriteLine(color));


// Liste içinde arama
if (numberList.Contains(10))
{
    Console.WriteLine("Eleman bulundu.");
}


// Eleman ile indexe erişme
Console.WriteLine(colorsList.BinarySearch("Turuncu"));


// Diziyi List tipine çevirme
string [] animals = {"Kedi", "Köpek", "Kuş"};

List<string> animals2 = new List<string>(animals);


// Tüm listeyi temizleme
animals2.Clear();

// List içerisinde nesne oluşturma
List<Users> usersList = new List<Users>();
Users user1 = new Users();
user1.Name = "Derya";
user1.Surname = "Kılıç";
user1.Age = 24;

Users user2 = new Users();
user2.Name = "Ahmet";
user2.Surname = "Yılmaz";
user2.Age = 26;

usersList.Add(user1);
usersList.Add(user2);

List<Users> newUsersList = new List<Users>();
newUsersList.Add(new Users(){
    Name = "Aslı",
    Surname = "Gedik",
    Age = 28,
});

foreach (Users user in usersList)
{
    Console.WriteLine("Kullnıcı Adı:" + user.Name);
    Console.WriteLine("Kullnıcı Soyadı:" + user.Surname);
    Console.WriteLine("Kullnıcı Yaşı:" + user.Age);
}

usersList.Clear();





// ArrayList 
ArrayList arrList = new ArrayList();
arrList.Add("Ayşe");
arrList.Add(2);
arrList.Add(true);
arrList.Add('A');

Console.WriteLine(arrList[0]);
foreach (var item in arrList)
{
    Console.WriteLine(item);
}

// AddRange : Birden fazla elemanı ekleme
string [] colors = {"Mavi", "Sarı", "Turuncu"};
List<int> numbers = new List<int>(){8,6,3,9,1,4,745,23};
//arrList.AddRange();
arrList.AddRange(numbers);

foreach (var item in arrList)
{
    Console.WriteLine(item);
}


// ArrayList Sort : sadece aynı tipteki elemanları sıralar yoksa hata verir
/* arrList.Sort();

foreach (var item in arrList)
{
    Console.WriteLine(item);
}

// BinearySearch : index numarasına göre dizinin elemanını verir
arrList.BinarySearch();
 */

// Reverse 
arrList.Reverse();
foreach (var item in arrList)
{
    Console.WriteLine(item);
}


// Clear
arrList.Clear();




// Dictionary - Key,Value
Dictionary<int, string> users = new Dictionary<int,string>();
users.Add(1,"Ayşe");
users.Add(2,"Fatma");
users.Add(3,"Ali");
users.Add(4,"Deniz");

// Listeleme
Console.WriteLine(users[4]);
foreach (var item in users)
{
    Console.WriteLine(item);
}

// Count
Console.WriteLine(users.Count);

// Contains
Console.WriteLine(users.ContainsKey(3));
Console.WriteLine(users.ContainsValue("Derya"));


// Remove
Console.WriteLine(users.Remove(2));
foreach (var item in users)
{
    Console.WriteLine(item);
}


// Keys
foreach (var item in users.Keys)
{
    Console.WriteLine(item);
}

// Values
foreach (var item in users.Values)
{
    Console.WriteLine(item);
}


// Collections Lession Example
public class Users{

    private string name;
    private string surname;
    private int age;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }
}
