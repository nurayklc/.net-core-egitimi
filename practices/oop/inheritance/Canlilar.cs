public class Canlilar
{
    public void Beslenme()
    {
        Console.WriteLine("Beslenme yapar.");
    }

    protected void Solunum()
    {
        Console.WriteLine("Solunum yapar.");
    }

    protected void Bosaltım()
    {
        Console.WriteLine("Bosaltım yapar.");
    }
    // Polymophism
    public virtual void UyaranlaraTepki(){
        Console.WriteLine("Canlılar uyaranlara tepki verir.");
    }
}