using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student wadea = new Student("Wadea", 22, 84.1);
            wadea.DisplayInfo();

            Student leen = new Student("Leen", 22, 99.5);
            leen.DisplayInfo();

            Student omar = new Student("Omar", 20, 75.0);
            omar.DisplayInfo();

            // What is class?
            /* A class is a blueprint for creating objects (instances) that have similar properties and methods. */

            // What is object?
            /* An object is an instance of a class that encapsulates data and behavior. It represents a specific entity with its own state and functionality. */

            // Difference between class and object?
            /* The main difference between a class and an object is that a class is a template or blueprint that defines the structure and behavior of objects, while an object is a specific instance of a class that has its own unique state and can perform actions defined by the class. In other words, a class is like a recipe, while an object is like the dish created from that recipe. */

            // Mention the OOP Principles?
            /* The four main principles of Object-Oriented Programming (OOP) are:
               1. Encapsulation: The bundling of data and methods that operate on that data within a single unit (class), restricting access to some of the object's components.
               2. Inheritance: The mechanism by which one class can inherit properties and methods from another class, promoting code reusability.
               3. Polymorphism: The ability of different classes to be treated as instances of the same class through a common interface, allowing for method overriding and dynamic method resolution.
               4. Abstraction: The process of hiding the complex implementation details and showing only the essential features of an object, allowing for a simplified interface. */

            // What is constructor?
            /* A constructor is a special method in a class that is automatically called when an object of that class is created. It is used to initialize the object's properties and set up any necessary state. Constructors typically have the same name as the class and do not have a return type. They can also be overloaded to provide different ways of initializing an object. */


        }
    }
}
