using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__5
{
    internal class Student
    {
        private string name;
        private int age;
        private double Grade;
        
        public Student()
        {
            this.name = "Unknown";
            this.age = 0;
            this.Grade = 0.0;
        }

        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {Grade}");
        }


    }
}
