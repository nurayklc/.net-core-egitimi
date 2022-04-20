// See https://aka.ms/new-console-template for more information

static int sum(int param1, int param2){
    return param1+param2;
}

// Call by Value 
Console.WriteLine(sum(4,9));
Console.WriteLine(sum(85,78));

ExerciseMethods exerciseMethod = new ExerciseMethods();

exerciseMethod.ConsoleWrite("Sum Method" + Convert.ToString(sum(23,56)));

// Ref by Value 
//exerciseMethod.increaseAndSum(11,22);



// Out Param
string number = "11111";
bool result = int.TryParse(number, out int outNumber);
if(result)
    Console.WriteLine("Success" + outNumber);
else
    Console.WriteLine("Fail!");


// Method Overloading Lesson 

string welcome = "Welcomeee";
int roomNumber = 8;

Methods methodsInstance = new Methods();
methodsInstance.Write(welcome);
methodsInstance.Write(roomNumber);


//Recursive Methods - Öz Yinelemeli
int result2 = 1;
for (int i = 1; i < 5; i++){
    result2 = result2 * 3;
}
Console.WriteLine(result);

Works instance = new();
Console.WriteLine(instance.Expo(3, 4));


// Extension Methods
string ifade = "Extension Methods";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);
if (sonuc)
{
    Console.WriteLine(ifade.RemoveWhiteSpaces());
}
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
dizi.SortArray();
dizi.EkranaYazdir();

int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber());

Console.WriteLine(ifade.GetFirstCharacter());
 

// Methods first Lesson
class ExerciseMethods {

    public void ConsoleWrite(string data){
        Console.WriteLine(data);
    }

    // Ref by Value
    public int increaseAndSum(ref int param1, ref int param2){
        param1 +=1;
        param2 +=1;
        return param1 + param2;
    }

}

// Method Overloading Lesson
class Methods {
    public void Write(string data){
        Console.WriteLine("Data: " + data);
    }

    public void Write(int data){
        Console.WriteLine("Data: " + data);
    }
}


// Recursive Fuction/Methods

public class Works{
    public int Expo(int sayi, int us){
        if (us < 2){
            return sayi;
        }
        return Expo(sayi, us - 1) * sayi;
    }
        //Expo(3,4)
        //Expo(3,3) * 3;
        //Expo(3,2) * 3 * 3;
        //Expo(3,1) * 3 * 3 * 3;
        // 3 * 3 * 3 * 3 = 3 ^ 4;
}

public static class Extensions{
    public static bool CheckSpaces(this string param){
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param){
        string [] arr = param.Split(" ");
        return string.Join("", arr);
    }

    public static string MakeUpperCase(this string param){
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param){
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param){
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param){
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param){
        return param % 2 == 0 ;
    }

    public static string GetFirstCharacter(this string param){
        return param.Substring(0,2);
    }
}