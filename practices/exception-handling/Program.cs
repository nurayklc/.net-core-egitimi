// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("Please enter a number : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number : " + sayi);
}
catch (Exception ex)
{
    Console.WriteLine("Error : " + ex.Message.ToString());
    Console.WriteLine("Please enter a number !");
}
finally
{
    Console.WriteLine("Have a good day..");
}

// Exercise 2:
try
{
    //int a = int.Parse(null);
    int b = int.Parse("sa");
    int c = int.Parse("12345678910");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Error : This value is empty. " + ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Error : This value was not in a corrcet format." + ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Error : Çok yüsek veya çok düşük değer girdiniz " + ex);
}