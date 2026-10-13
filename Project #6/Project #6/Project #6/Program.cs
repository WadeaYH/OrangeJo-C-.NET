using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alice", 30, "Greenwood High");
            person.DisplayInfo();
            Console.WriteLine();
            //person.SchoolName = "Sunrise Academy"; // Accessing protected property in main.

            //person._internalCode = "ABC123"; // Accessing private field in main.

            SchoolReport report = new SchoolReport("Annual School Report"); // this is a sealed class, so it cannot be inherited.
            report.DisplayReport();
            Console.WriteLine();

            Student student1 = new Student("Bob", 15, "Sunrise Academy", 10, "S12345");
            student1.DisplayInfo();
            student1.DisplayStudentInfo();
            Console.WriteLine();

            Student student2 = new Student("Charlie", 16, "Greenwood High", 11, "S67890");
            student2.DisplayInfo();
            student2.DisplayStudentInfo();
            Console.WriteLine();

            Teacher teacher = new Teacher("Mr. Smith", 40, "Sunrise Academy", "Mathematics");
            teacher.DisplayInfo();
            teacher.DisplayTeacherInfo();
            Console.WriteLine();


        }
    }
}
