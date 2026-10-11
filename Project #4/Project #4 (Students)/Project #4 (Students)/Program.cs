using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project__4__Students_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            while (exit)
            {
                Console.WriteLine("\n\n===== School Management System =====");
                Console.WriteLine("\n\n\n");
                Console.WriteLine("1. Display Students and Grades");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Add Student");
                Console.WriteLine("5. Check Student Grade");
                Console.WriteLine("6. Exit");

                Console.Write("\n\n\n\nEnter your choice (1-6): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayStudentsAndGrades();
                        break;
                    case "2":
                        SearchForStudent();
                        break;
                    case "3":
                        CheckStudentResult();
                        break;
                    case "4":
                        AddStudent();
                        break;
                    case "5":
                        CheckStudentGrade();
                        break;
                    case "6":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }



            void AddStudent()
            {
                Console.WriteLine("Enter the names of students and their grades (type 'done' to finish):");

                while (true)
                {
                    Console.WriteLine("\n");
                    Console.Write("Student name: ");
                    string input = Console.ReadLine();
                    if (input == "done")
                        break;
                    Console.Write("\nStudent grade: ");
                    string gradeInput = Console.ReadLine();
                    double grade;
                    while (!double.TryParse(gradeInput, out grade))
                    {
                        Console.Write("Invalid grade. Please enter a numeric grade: ");
                        gradeInput = Console.ReadLine();
                    }
                    students.Add(input);
                    grades.Add(grade);
                }
            }

            void DisplayStudentsAndGrades()
            {
                Console.WriteLine("\n\n\n\nStudent Details:");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"Student Name: {students[i]}, Grade: {grades[i]}");
                }
            }

            void SearchForStudent()
            {
                Console.Write("\n\n\n\nEnter any student name to view their grade: ");
                string studentName = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (string.Equals(students[i], studentName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Student Found!\nStudent details:\nStudent Name: {studentName}: {grades[i]}");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }

            void CheckStudentResult()
            {
                Console.Write("\n\n\n\nEnter any student name to view their grade: ");
                string studentName = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (string.Equals(students[i], studentName, StringComparison.OrdinalIgnoreCase))
                    {
                        double g = grades[i];
                        Console.WriteLine($"Student Found!\nStudent details:\nStudent Name: {studentName}: {g}");
                        if (g >= 90) Console.WriteLine("Result: Excellent");
                        else if (g >= 80) Console.WriteLine("Result: Very Good");
                        else if (g >= 70) Console.WriteLine("Result: Good");
                        else if (g >= 60) Console.WriteLine("Result: Pass");
                        else Console.WriteLine("Result: Fail");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }

            void CheckStudentGrade()
            {
                Console.Write("\n\n\n\nEnter student name to check their grade: ");
                string name = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (string.Equals(students[i], name, StringComparison.OrdinalIgnoreCase))
                    {
                        double g = grades[i];
                        Console.WriteLine($"Student: {students[i]}, Grade: {g}");
                        if (g >= 90) Console.WriteLine("Result: Excellent");
                        else if (g >= 80) Console.WriteLine("Result: Very Good");
                        else if (g >= 70) Console.WriteLine("Result: Good");
                        else if (g >= 60) Console.WriteLine("Result: Pass");
                        else Console.WriteLine("Result: Fail");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }

        }

    }
}
