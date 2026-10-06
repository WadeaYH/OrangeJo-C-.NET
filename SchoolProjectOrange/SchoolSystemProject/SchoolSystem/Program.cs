using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Wadea";
            int studentAgr = 22;
            double studentGrade = 3.5;
            double studentAverage = 3.7;
            string studentGender = "Male";
            bool isStudentActive = true;

            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Age: " + studentAgr);
            Console.WriteLine("Student Grade: " + studentGrade);
            Console.WriteLine("Student Average: " + studentAverage);
            Console.WriteLine("Student Gender: " + studentGender);
            Console.WriteLine("Is Student Active: " + isStudentActive);
            Console.WriteLine("\n\n\n\n");

            string[] students = { "Wadea", "Ali", "Ahmed", "Sara", "Lina" };
            Console.WriteLine("===== Before Modification =====");
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
            Console.WriteLine("Student 5: " + students[4]);
            Console.WriteLine("Total Students: " + students.Length);

            Console.WriteLine("\n\n\n\n");

            Console.WriteLine("This is the first student: " + students[0]);
            Console.WriteLine("This is the last student: " + students[students.Length - 1]);
            students[2] = "Alex";
            Console.WriteLine("===== After the modification =====");
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
            Console.WriteLine("Student 5: " + students[4]);
            
            Console.WriteLine("\n\n\n\n");


        }
    }
}
