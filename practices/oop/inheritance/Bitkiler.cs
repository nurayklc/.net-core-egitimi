public class Bitkiler : Canlilar
{

    public void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }

    // Polymophism
    public override void UyaranlaraTepki()
    {
        //base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
        Console.WriteLine("Bitkiler güneşe tepki verir.");
    }
}

public class TohumluBitkiler : Bitkiler
{
    public TohumluBitkiler(){
        base.Fotosentez();
        base.Beslenme();
        base.Bosaltım();
        base.Solunum();
        base.UyaranlaraTepki();
    }
    public void TohumlaCogalır()
    {
        Console.WriteLine("Tohumlu bitkiler tohumla cagalır.");
    } 
}

public class TohumsuzBitkiler : Bitkiler
{
    public void SporlaCogalır()
    {
        Console.WriteLine("Tohumsuz bitkiler sporla cagalır.");
    }
}