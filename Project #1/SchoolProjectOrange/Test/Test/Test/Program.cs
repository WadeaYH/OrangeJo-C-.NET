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
            student.DisplayInfo();
            student.Name = "Wadea";
            student.Age = 22;
            student.DisplayInfo();


            Console.WriteLine("\n\n\n\n");

            string num = "42";
            int num2 = int.Parse(num);
            string num3 = num2.ToString();

            num += ", France";
            Console.WriteLine(num);
        }
    }
}
