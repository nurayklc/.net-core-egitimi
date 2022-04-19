// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen bir sayı giriniz: ");
int count = int.Parse(Console.ReadLine());
for (int i = 1; i <= count; i++)
{
    if (i % 2 == 1)
        Console.WriteLine(i);
}

int oddSum = 0;
int evenSum = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 1)
        oddSum += i;
    else
        evenSum += i;
}

Console.WriteLine("Tek Toplam " + oddSum);
Console.WriteLine("Çift Toplam " + evenSum);

//break, continue
for (int i = 1; i < 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}
