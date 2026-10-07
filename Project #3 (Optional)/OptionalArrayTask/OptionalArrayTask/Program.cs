using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"Fruit at index {i}: {fruits[i]}");
            }
            Console.WriteLine($"Total number of fruits: {fruits.Length}");
            Console.WriteLine("\n\n\n\n\n");

            int[] numbers = { };

            Console.Write("How many numbers do you want to enter? : ");
            int howManyNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyNumbers; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers = numbers.Append(number).ToArray();
            }

            int[] number2 = (int[])numbers.Clone();
            Array.Reverse(number2);

            Console.WriteLine("Original array:");
            foreach (int n in numbers)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            Console.WriteLine("Reversed array:");
            foreach (int n in number2)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("\n\n\n\n\n");

            string[] colors = {"Red", "Green", "Blue", "Yellow", "Purple", "Ruby", "Rose"};
            int counter = 0;
            Console.Write("Colors starting with 'R' or 'r': ");
            foreach (string color in colors)
            {
                if (color[0] == 'R' || color[0] == 'r') {
                    Console.Write($"{color} ");
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total count: {counter}");
            Console.WriteLine("\n\n\n\n\n");


            int[] number3 = {};
            Console.Write("How many numbers do you want to enter? : ");
            int howManyNumbers2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyNumbers2; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number4 = Convert.ToInt32(Console.ReadLine());
                number3 = number3.Append(number4).ToArray();
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Sum of elements: " + number3.Sum());
            Console.WriteLine("Average of elements: " + number3.Average());
            Console.WriteLine("Minimum element: " + number3.Min());
            Console.WriteLine("Maximum element: " + number3.Max());
            Console.WriteLine("Sorted array: ");
            Array.Sort(number3);
            foreach (int n in number3)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}
