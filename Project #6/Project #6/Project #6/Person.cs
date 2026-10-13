using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__6
{
    internal class Person
    {
        public string Name { get; set; }

        private string _internalCode; // This field is private and can only be accessed within the Person class.

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                age = value;
            }
        }

        public string InternalCode
        {
            get { return _internalCode; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Internal code cannot be empty.");
                }
                _internalCode = value;
            }
        }

        protected string SchoolName { get; set; }


        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} .");
        }
    }
}
