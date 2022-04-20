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