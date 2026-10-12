using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student : Hybrid
    {
        private string name;
        private int age;
        
        public Student()
        {
            name = "Unknown";
            age = 0;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public  void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public void DisplayError(string message)
        {
            Console.WriteLine($"Error: {message}");
        }

    }
}
