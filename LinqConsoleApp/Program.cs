// See https://aka.ms/new-console-template for more information

using LinqConsoleApp.DbOperations;
using System.Linq;

DataGenerator.Initialize();
LinqDbContext _context = new LinqDbContext();
var students = _context.Students.ToList<Student>();

// Find Method 

// Use Not Find Method
var student = _context.Students.Where(x => x.StudentId == 1).FirstOrDefault();
Console.WriteLine(student.Name);

// Use Find Method
student = _context.Students.Find(3);
Console.WriteLine(student.Name);

// FirstOrDeafult()
student = _context.Students.Where(x => x.Name == "Ada").FirstOrDefault();
Console.WriteLine(student.Surname);

student = _context.Students.FirstOrDefault(x => x.Name == "Ada");
Console.WriteLine(student.Surname);

// SingleOrDefault()
student = _context.Students.SingleOrDefault(x=> x.Name == "Alin");
Console.WriteLine(student.Surname);

// ToList()
var studentList = _context.Students.Where(x => x.ClassId == 2).ToList();
foreach (var item in studentList)
{
    Console.WriteLine("Liste Eleman Sayısı: " + studentList.Count);
    Console.WriteLine(item.Name);
}

// OrderBy()
var studentOrder = _context.Students.OrderBy(x => x.StudentId).ToList();
foreach (var item in studentOrder)
{
    Console.WriteLine(item.StudentId + " - " + item.Name + "" + item.Surname);
}

// OrderByDescending()
var studentOrderDesc = _context.Students.OrderByDescending(x => x.StudentId).ToList();
foreach (var item in studentOrderDesc)
{
    Console.WriteLine(item.StudentId + "-" + item.Name + "-" + item.Surname);
}

// Anonymous Object Result
var anonymousObject = _context.Students.Where(x => x.ClassId == 2)
                                        .Select(x => new {
                                            Id = x.StudentId,
                                            FullName = x.Name + " " + x.Surname
                                        });

foreach (var obj in anonymousObject)
{
    Console.WriteLine(obj.Id + " - " + obj.FullName);
}
