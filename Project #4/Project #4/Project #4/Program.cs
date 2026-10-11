using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__4
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int points = 0;
            Console.WriteLine("*** Welcome to guessing number game ***");
            Console.WriteLine("I'm thinking of a number between 50 and 75.");
            Console.WriteLine("Can you guess what it is?");
            Random random = new Random();
            int numberToGuess = random.Next(50, 75);
            bool flag = true;
            int counter = 1;
            while (flag)
            {
                Console.WriteLine("\n\n");
                Console.Write("Enter your guess: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == numberToGuess)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    if(counter == 1)
                    {
                        points += 10;
                    }
                    else if (counter == 2)
                    {
                        points += 7;
                    }
                    else if (counter == 3)
                    {
                        points += 5;
                    }
                    else
                    {
                        points = 0;
                    }
                    Console.WriteLine($"You guessed the number in {counter} attempts, and you scored {points} points.");
                    flag = false;
                }
                else if (input < numberToGuess)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                    counter++;
                }
            }
        }
    }
}
