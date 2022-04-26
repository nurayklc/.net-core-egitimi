
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


// Create Class
class Employee {

    public string Name;
    public string Surname;
    public int No;
    public string Department;


    public void EmployeeInfo(){
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Surname: " + Surname);
        Console.WriteLine("Employee No: " + No);
        Console.WriteLine("Employee Department: " + Department);
    }
}