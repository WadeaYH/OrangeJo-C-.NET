using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__6
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        

        public Teacher(string name, int age, string subject, string schoolName) : base(name, age, schoolName)
        {
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}, School Name: {SchoolName}");
        }


    }
}
