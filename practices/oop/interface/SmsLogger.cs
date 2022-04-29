public class SmsLogger : ILogger
{
    public void WriteLog(){
        Console.WriteLine("SMS olarak log yazar.");
    }
}