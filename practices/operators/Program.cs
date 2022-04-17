// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Atama ve işlemli Atamalar
int x = 3;
int y = 2;
y = y+2;
y += 2;

x *= 2;
Console.WriteLine("x:" + x);
Console.WriteLine("y:" + y);

// Mantıksal Operatorler 
// || && !
bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted) 
    Console.WriteLine("Perfect");

if(isSuccess || isCompleted)
    Console.WriteLine("Terrific");

if(isSuccess && !isCompleted)
    Console.WriteLine("Great");

// İlişkisel Operatorler
// < > <= >= == !=

int a = 4;
int b = 8;

// bool sonuc = a<=b
// bool sonuc = a<b
// bool sonuc = a>=b
// bool sonuc = a>b
// bool sonuc = a!=b
// bool sonuc = a==b
bool sonuc = a<b;

Console.WriteLine("Sonuc" + sonuc);

// Aritmetik Operatorler
// + - * / 

int sayi = 10;
int sayi2 = 5;

Console.WriteLine("Toplama " + (sayi + sayi2));

Console.WriteLine("Çıkarma " + (sayi - sayi2));

Console.WriteLine("Bölme " + (sayi / sayi2));

Console.WriteLine("Çarpma " + (sayi * sayi2));

// % -> mod alır

int sonuc2 = 20 % 3;
Console.WriteLine("Mod: " + sonuc2)