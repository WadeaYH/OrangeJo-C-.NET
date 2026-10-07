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
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter student age: ");
            string studentAge = Console.ReadLine();

            Console.Write("Enter student grade: ");
            string studentGrade = Console.ReadLine();

            Console.Write("Enter student average: ");
            int studentAverage = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student gender: ");
            string studentGender = Console.ReadLine();

            Console.WriteLine($"Welcome to the Student Information System * {studentName} * :");
            Console.WriteLine("Your Information:");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"Gender: {studentGender}");
            Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("===== Name Information =====");
            Console.WriteLine($"Original Name: {studentName}");
            Console.WriteLine($"Uppercase Name: {studentName.ToUpper()}");
            Console.WriteLine($"Lowercase Name: {studentName.ToLower()}");
            Console.WriteLine($"First Character: {studentName[0]}");
            Console.WriteLine("\n\n\n\n\n");


            Console.WriteLine("===== Average Information =====");
            Console.WriteLine($"Original Average: {studentAverage}");
            Console.WriteLine("Bonus Points: 5");
            studentAverage += 5;
            Console.WriteLine($"Updated Average: {studentAverage}");

            Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("===== Student Status Check =====");
            if (studentAverage >= 50)
            {
                Console.WriteLine("Status: Passed");
            }
            else
            {
                Console.WriteLine("Status: Failed");
            }

            Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("===== Student Age Check =====");
            if (studentAge == "18")
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            Console.WriteLine("\n\n\n\n\n");


            Console.WriteLine("===== STUDENT SUMMARY =====");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"Gender: {studentGender}");
            Console.WriteLine($"New Average: {studentAverage}");
            Console.WriteLine($"Result: {(studentAverage >= 50 ? "Passed" : "Failed")}");
            Console.WriteLine($"Adult: {(studentAge == "18" ? "Yes" : "No")}");

        }
    }
}
