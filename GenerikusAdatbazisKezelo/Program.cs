using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusAdatbazisKezelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager<Student> database1 = new DatabaseManager<Student>();
            
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            student1.Id = 0;
            student2.Id = 1;
            student3.Id = 2;
            student1.Age = 18;
            student2.Age = 17;
            student3.Age = 23;
            student1.Name = "Janos";
            student2.Name = "Pista";
            student3.Name = "Gergo";

            database1.AddRecord(student1);
            database1.AddRecord(student2);
            database1.AddRecord(student3);

            database1.PrintDatabase();

            try
            {
                Console.WriteLine(database1.GetRecord(3));
                database1.RemoveRecord(3);
                database1.PrintDatabase();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
