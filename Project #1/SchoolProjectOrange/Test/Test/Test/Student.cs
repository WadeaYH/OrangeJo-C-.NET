using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student
    {
        public string name { get; set; }
        private int age;

        public string message { get; set; }

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

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public int Age
        {
            get { return age; }
            set {
                if(value > 100)
                {
                    DisplayError("Age cannot be greater than 100.");
                    return;
                }
                age = value; }
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
