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