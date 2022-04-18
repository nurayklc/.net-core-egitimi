// See https://aka.ms/new-console-template for more information

int time = DateTime.Now.Hour;

if (time <= 11 && time >= 6)
{
    Console.WriteLine("Günaydın...");
}
else if (time <= 18)
{
    Console.WriteLine("İyi günler...");
}
else
{
    Console.WriteLine("İyi geceler...");
}

string result = time <= 18 ? "İyi günler..." : (time <= 11 && time >= 6) ? "Günaydın..." : "İyi geceler...";
Console.WriteLine(result);

// Switch Case

int month = DateTime.Now.Month;

// Expression
switch (month)
{
    case 1:
        Console.WriteLine("Ocak Ayı");
        break;
    case 2:
        Console.WriteLine("Şubat Ayı");
        break;
    case 3:
        Console.WriteLine("Mart Ayı");
        break;
    case 4:
        Console.WriteLine("Nisan Ayı");
        break;
    case 5:
        Console.WriteLine("Mayıs Ayı");
        break;

    default:
        Console.WriteLine("Yanlış veri girişi!");
        break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Mevsimi");
        break;
    
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar Mevsimi");
        break;

    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Mevsimi");
        break;

    case 9:
    case 10:
    case 11:
        Console.WriteLine("İlkbahar Mevsimi");
        break;   

    default:
        break;
}