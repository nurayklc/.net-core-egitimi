
Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);


Employee employee1 = new Employee("Nevra", "Elmas", "IT");
Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);


Employee employee2 = new Employee("Agah", "Bey", "IT");
Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);

// Static Class and Method Access
Console.WriteLine("Addition Result : {0}" , Exercise.Addition(85,96) );
Console.WriteLine("Extraction Result : {0}" , Exercise.Extraction(185,96) );

// Create Class
class Employee{

    private static int employeeCount;

    private string Name;

    private string Surname;

    public string Department;

    // Static Contructor - Static contructor da erişim belirteci olmaz
    // Sadece ilk çağrıldığında static contructor çalışır
    static Employee(){
        employeeCount = 0;
    }

    // Static Methods
    public static int EmployeeCount {
        get => employeeCount;
        //set => employeeCount = value;
    }


    // Contructor
    public Employee(string name, string surname, string department){
        this.Name = name;
        this.Surname = surname;
        this.Department = department;
        employeeCount++;
    }

    
}


// Static Class
static class Exercise{
    public static long Addition(int number1, int number2){
        return number1 + number2;
    }

    public static long Extraction(int number1, int number2){
        return number1 - number2;
    }
}