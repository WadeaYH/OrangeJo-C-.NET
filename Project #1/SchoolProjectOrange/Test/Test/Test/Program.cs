using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John Doe", 20);
            Student student2 = new Student("Jane Smith", 21);
            Student student3 = new Student("Bob Johnson", 22);
            student.DisplayInfo();
            student.name = "Wadea";
            student.Age = 22;
            student.DisplayInfo();


            //Console.WriteLine("\n\n\n\n");

            //student2.DisplayInfo();
            //student2.name = "Leen";
            //student2.DisplayInfo();
            //student2.DisplayError("This is an error message for student2.");

           
        }
    }
}
