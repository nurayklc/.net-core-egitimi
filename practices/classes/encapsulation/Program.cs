// Create New Student
Student student1 = new Student();
student1.Name = "Nevra";
student1.Surname = "Elmas";
student1.StdntNo = 3;
student1.StdntClass = 10;

student1.GetInfoStudent();


// Pass Class Method
student1.PassClass();
student1.GetInfoStudent();


// Create Second Student
Student student2 = new Student("Canan", "Kara", 256,12);
student2.GetInfoStudent();

// Down Class Method
student2.DownClass();
student1.GetInfoStudent();


class Student{
    private string name;
    private string surname;
    private int stdntNo;
    private int stdntClass;

    public string Name { 
        get => name; 
        set => name = value;
    }

    public string Surname { 
        get => surname; 
        set => surname = value;
    }

    public int StdntNo { 
        get => stdntNo; 
        set => stdntNo = value;
    }

    public int StdntClass { 
        get => stdntClass; 
        set 
        {
            if(value<1){
                Console.WriteLine("The class less must 1!");
                stdntClass = 1;
            }
            else {
                stdntClass = value;
            }
        }
    }

    public Student(){}

    public Student(string name, string surname, int stdntNo, int stdntClass){
        Name = name;
        Surname = surname;
        StdntNo = stdntNo;
        StdntClass = stdntClass;
    }

    public void GetInfoStudent(){
        Console.WriteLine("Student Name: " , this.Name);
        Console.WriteLine("Student Surname: " , this.Surname);
        Console.WriteLine("Student No: " , this.StdntNo);
        Console.WriteLine("Student Class: " , this.StdntClass);
    }

    public void PassClass(){
        this.StdntClass = this.StdntClass + 1 ;
    }

    public void DownClass(){
        this.StdntClass = this.StdntClass - 1 ;
    }
}