// See https://aka.ms/new-console-template for more information
//Dizi Tanımlama
string[] renkler = new string[5];
string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

int[] dizi;
dizi = new int[5];

//Dizilere Değer Atama ve Erişim
renkler[0] = "Mavi";
dizi[3] = 10;
Console.WriteLine(hayvanlar[0]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

//Döngülerle Dizi Kullanımı
Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int arrLength = int.Parse(Console.ReadLine());
int[] numberArr = new int[arrLength];

for (int i = 0; i < arrLength; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz : ", i + 1);
    numberArr[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
foreach (var number in numberArr)
{
    sum += number;
}
Console.WriteLine("Ortalama :" + sum / arrLength);

int[] sayiDizisi = { 23, 12, 86, 72, 3, 11, 17, 4 };
Console.WriteLine("Sırasız Dizi ");
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("Sıralı Dizi ");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("Array Clear");
Array.Clear(sayiDizisi, 2, 2);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("Array Reverse");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("Array Indexof");

Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

Console.WriteLine("Array Resize");
Array.Resize<int>(ref sayiDizisi, 9);

sayiDizisi[8] = 99;

foreach (var sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}