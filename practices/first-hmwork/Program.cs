// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args){
        FirstHmwork firstHmw = new FirstHmwork();
        firstHmw.FirstQuestion();
        firstHmw.SecondQuestion();
        firstHmw.ThirdQuestion();
        firstHmw.FourthQuestion();
    }
}

public class FirstHmwork{

    // First Question - Kullanıcıdan alınan n adet sayıların çift sayı olanlarını bulma
    public void FirstQuestion(){
        Console.WriteLine("Please enter a positive number(n)..");
        int n = Convert.ToInt32(Console.ReadLine());
        if(!(n.isPositiveNumber())){
            Console.WriteLine("Please enter a positive number(n)..");
        }
        Console.WriteLine("Please enter positive array number(n)..");
        List<int> arr = new List<int>();
        for(int i=0;i<n;i++){
            arr.Add(Convert.ToInt32(Console.ReadLine()));
        }
        foreach (var item in arr)
        {
            if(item % 2 == 0 ){
                Console.WriteLine("Even number: " + item);
            }
            else{
                Console.WriteLine("Not even number!");
            }
        }
    }

    // Second Question - Kullanıcıdan alınan diziden, n ve m sayılarından m sayısını bulma
    public void SecondQuestion(){
         Console.WriteLine("Please enter a positive number(n)..");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a positive number(m)..");
        int m = Convert.ToInt32(Console.ReadLine());
        if(!(n.isPositiveNumber())){
            Console.WriteLine("Please enter a positive number(n)..");
        }
        if(!(m.isPositiveNumber())){
            Console.WriteLine("Please enter a positive number(m)..");
        }
        Console.WriteLine("Please enter positive array number(m)..");
        List<int> arr = new List<int>();
        for(int i=0;i<m;i++){
            arr.Add(Convert.ToInt32(Console.ReadLine()));
        }
        foreach (var item in arr)
        {
            if(item == m || m % item == 0){
                Console.WriteLine("M or M Dividing: " + item);
            }
        }
    }

    
    // Third Question - Kullanıcıdan n adet alınan elemanlı string dizisini ters sıralama
    public void ThirdQuestion(){
        Console.WriteLine("Please enter a positive number(n)..");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[n];
        Console.WriteLine("Please enter"+ $"{n} words");
        for (int i = 0; i < n; i++){
            Console.Write($"{i + 1}.th enter the word ");
            words[i] = Convert.ToString(Console.ReadLine());
        }
        Array.Reverse(words);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }

    
    // Fourth Question - Kullanıcıdan alınan cümlenin kelime ve harf sayısını bulma
    public void FourthQuestion(){
        Console.WriteLine("Please enter a sentence..");

        string newStr = Convert.ToString(Console.ReadLine());
        string [] arrSplit = newStr.Split(" ");
        Console.WriteLine(arrSplit.Length);
        
        Console.WriteLine(newStr.Length - (arrSplit.Length-1) );
    }
}

public static class Extension{
    public static bool isPositiveNumber(this int number){
        return number>0;
    }
}   