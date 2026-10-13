using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__6
{
    internal class Student : Person
    {
        public int Grade { get; set; }

        private string studentId;

        public string StudentId
        {
            get { return studentId; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student ID cannot be empty.");
                }
                studentId = value;
            }
        }


        public Student(string name, int age, string schoolName, int grade, string studentId) : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}, Student ID: {StudentId}, School Name: {SchoolName}");
        }
    }
}
