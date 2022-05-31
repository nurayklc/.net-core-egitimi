using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LinqConsoleApp.DbOperations
{
    public class DataGenerator {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if(context.Students.Any()){
                    return;
                }
                context.Students.AddRange(
                    new Student(){
                        Name = "Fatma",
                        Surname = "Keskin",
                        ClassId = 1
                    },
                    new Student(){
                        Name = "Ada",
                        Surname = "Çetin",
                        ClassId = 2
                    },
                    new Student(){
                        Name = "Alin",
                        Surname = "Sarı",
                        ClassId = 2
                    },
                    new Student(){
                        Name = "Ada",
                        Surname = "Deryalı",
                        ClassId = 1
                    }
                );
                context.SaveChanges();
                
            }
        }
    }
}