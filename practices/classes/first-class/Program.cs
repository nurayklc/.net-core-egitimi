
// Create Instance
Employee firstEmployee = new Employee();
firstEmployee.Name = "Nevra";
firstEmployee.Surname = "Elmas";
firstEmployee.No = 1;
firstEmployee.Department = "IT";

firstEmployee.EmployeeInfo();


Employee secondEmployee = new Employee();
secondEmployee.Name = "Agah";
secondEmployee.Surname = "Beyoğlu";
secondEmployee.No = 2;
secondEmployee.Department = "IK";

secondEmployee.EmployeeInfo();


Employee employee1 = new Employee("Elif", "Kara", 3, "IT");
employee1.EmployeeInfo();



Employee employee2 = new Employee("Deniz", "Akgün");
employee2.EmployeeInfo();



// Create Class
class Employee {

    public string Name;
    public string Surname;
    public int No;
    public string Department;

    // Method Overloading
    public Employee(string name, string surname, int no, string department){
        this.Name = name;
        this.Surname = surname;
        this.No = no;
        this.Department = department;
    }

    public Employee(string name, string surname){
        this.Name = name;
        this.Surname = surname;
    }

    public Employee(){}

    public void EmployeeInfo(){
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Surname: " + Surname);
        Console.WriteLine("Employee No: " + No);
        Console.WriteLine("Employee Department: " + Department);
    }
}