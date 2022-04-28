public class Hayvanlar : Canlilar
{
    public void Adaptosyon()
    {
        Console.WriteLine("Hayvanlar adaptosyon yapar.");
    }
    
    // Polymophism
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

public class Surungenler : Hayvanlar
{
    public Surungenler(){
        base.Adaptosyon();
    }
    
    public void SurunerekHareketEderler()
    {
        Console.WriteLine("Surungenler surunerek hareket ederler.");
    }

}

public class Kuslar : Hayvanlar
{
    public Kuslar(){
        base.Adaptosyon();
        base.Beslenme();
        base.Bosaltım();
        base.Solunum();
        base.UyaranlaraTepki();
    }

    public void Ucmak()
    {
        Console.WriteLine("Kuslar uçarlar.");
    }

}