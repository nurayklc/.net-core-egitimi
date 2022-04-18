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