using System;

// =====================================================================
//  SIMPLE DEMO: Properties, Auto-properties, Access modifiers
//               (public, private, protected)
//
//  HOW TO USE THIS FILE
//  1. Every example ("CASE") inside Main is commented out.
//  2. To run a case: delete the line that says /*  and the line that says */
//     around it.  (Each case is inside its own { } so you can run many.)
//  3. Press Ctrl + F5 and read the output.
//  4. Cases marked "ERROR" are SUPPOSED to fail. Uncomment them to show
//     the compiler message, then comment them again.
// =====================================================================

namespace SimpleDemo
{
    // =================================================================
    //  PART 1: PROPERTIES
    // =================================================================

    // A BAD class: public field = no protection (anyone can write anything)
    class BadPerson
    {
        public int age;                       // public FIELD (not safe)
    }

    // A GOOD class: private field + public property that checks the value
    class Person
    {
        private int _age;                     // backing field (private, hidden)

        public int Age                        // the PROPERTY (public door)
        {
            get { return _age; }              // runs when we READ  p.Age
            set                               // runs when we WRITE p.Age = ...
            {
                if (value < 0 || value > 120) // "value" = what the user assigned
                {
                    throw new ArgumentException("Age must be between 0 and 120");
                }
                _age = value;                 // value is OK, so we save it
            }
        }
    }

    // =================================================================
    //  PART 2: AUTO-PROPERTIES
    // =================================================================
    class Student
    {
        // 1) Normal auto-property: read and write from anywhere
        public string Name { get; set; }

        // 2) Read-only auto-property: can only be set inside the constructor
        public int Id { get; }

        // 3) private set: everyone can read it, only THIS class can change it
        public int Score { get; private set; }

        // 4) Auto-property with a default value
        public string Role { get; set; } = "Student";

        // 5) Computed property: stores nothing, calculates when you read it
        public string First { get; set; }
        public string Last { get; set; }
        public string FullName => First + " " + Last;

        public Student(int id)                // constructor sets the read-only Id
        {
            Id = id;
        }

        public void AddScore(int points)      // the only way to change Score
        {
            Score = Score + points;           // allowed: we are INSIDE the class
        }
    }

    // =================================================================
    //  PART 3: ACCESS MODIFIERS (public, private, protected)
    // =================================================================
    class Animal
    {
        public string Name;                   // public    : everyone can use it
        protected int energy = 10;            // protected : this class + child classes
        private string secret = "I am private"; // private : this class only

        public void ShowSecret()
        {
            Console.WriteLine(secret);        // OK: the same class can use its private
        }
    }

    // Dog is a CHILD class. The colon  :  means "inherits from Animal"
    // (we only need it to show what protected means)
    class Dog : Animal
    {
        public void UseProtected()
        {
            energy = energy - 1;              // OK: protected is allowed in a child
            Console.WriteLine(Name + " energy now " + energy);   // Name is public: OK
        }

        // ERROR demo (uncomment to see it):
        //public void TryPrivate()
        //{
        //    Console.WriteLine(secret);     // ERROR CS0122: 'Animal.secret' is inaccessible
        //}
    }

    // =================================================================
    //  PART 4: EVERYTHING TOGETHER
    // =================================================================
    class BankAccount
    {
        private decimal _balance;                       // private field
        public string Owner { get; set; }               // public auto-property
        protected string Pin { get; set; } = "1234";    // protected auto-property

        public decimal Balance                          // full property with a rule
        {
            get { return _balance; }                    // everyone can READ it
            private set                                 // only THIS class can WRITE it
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negative balance");
                }
                _balance = value;
            }
        }

        public void Deposit(decimal amount)             // the safe way to change Balance
        {
            Balance = Balance + amount;
        }
    }

    // =================================================================
    //  MAIN: all the cases are here (all commented)
    // =================================================================
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program started. Remove the comments from one CASE at a time.");

            // ---------------------------------------------------------
            // CASE 1: The problem with a PUBLIC FIELD
            // "age is public, so anyone can store a nonsense value"
            // ---------------------------------------------------------
            /*
            {
                BadPerson bp = new BadPerson();
                bp.age = -50;                          // allowed, but nonsense!
                Console.WriteLine(bp.age);             // -50
            }
            */

            // ---------------------------------------------------------
            // CASE 2: A PROPERTY (private field + public door)
            // "p.Age = 25 runs the set block, then reading runs the get block"
            // ---------------------------------------------------------
            /*
            {
                Person p = new Person();
                p.Age = 25;                            // set runs, value = 25
                Console.WriteLine(p.Age);              // get runs: 25
            }
            */

            // ---------------------------------------------------------
            // CASE 3: A PROPERTY THAT CHECKS THE VALUE
            // "the set block rejects a bad value, so the old value stays safe"
            // ---------------------------------------------------------
            
            {
                Person p = new Person();
                try
                {
                    p.Age = -50;                       // set throws an exception
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Rejected: " + ex.Message);
                    // Rejected: Age must be between 0 and 120
                }
            }
            

            // ---------------------------------------------------------
            // CASE 4: AUTO-PROPERTY { get; set; }
            // "the compiler creates the hidden field for me"
            // ---------------------------------------------------------
            /*
            {
                Student s = new Student(1);
                s.Name = "Wadea";
                Console.WriteLine(s.Name);             // Wadea
            }
            */

            // ---------------------------------------------------------
            // CASE 5: READ-ONLY AUTO-PROPERTY { get; }
            // "Id was set in the constructor. After that, nobody can change it"
            // ---------------------------------------------------------
            /*
            {
                Student s = new Student(7);
                Console.WriteLine(s.Id);               // 7
            }
            */

            // CASE 5b (ERROR): try to change the read-only property
            /*
            {
                Student s = new Student(7);
                s.Id = 99;                             // ERROR CS0200: property is read only
            }
            */

            // ---------------------------------------------------------
            // CASE 6: PRIVATE SET { get; private set; }
            // "everyone can READ Score, but only the class can CHANGE it"
            // ---------------------------------------------------------
            /*
            {
                Student s = new Student(1);
                s.AddScore(10);                        // the class changes Score for us
                s.AddScore(5);
                Console.WriteLine(s.Score);            // 15
            }
            */

            // CASE 6b (ERROR): try to set Score from outside
            /*
            {
                Student s = new Student(1);
                s.Score = 100;                         // ERROR CS0272: set accessor is inaccessible
            }
            */

            // ---------------------------------------------------------
            // CASE 7: DEFAULT VALUE
            // "Role starts as Student, but we can change it"
            // ---------------------------------------------------------
            /*
            {
                Student s = new Student(1);
                Console.WriteLine(s.Role);             // Student
                s.Role = "Leader";
                Console.WriteLine(s.Role);             // Leader
            }
            */

            // ---------------------------------------------------------
            // CASE 8: COMPUTED PROPERTY  =>
            // "FullName stores nothing. It is calculated every time we read it"
            // ---------------------------------------------------------
            /*
            {
                Student s = new Student(1);
                s.First = "Wadea";
                s.Last = "Ali";
                Console.WriteLine(s.FullName);         // Wadea Ali

                s.Last = "Ahmad";                      // change a stored value
                Console.WriteLine(s.FullName);         // Wadea Ahmad (updated by itself)
            }
            */

            // ---------------------------------------------------------
            // CASE 9: PUBLIC
            // "public = anyone can use it, even Main"
            // ---------------------------------------------------------
            /*
            {
                Animal a = new Animal();
                a.Name = "Rex";                        // OK: Name is public
                Console.WriteLine(a.Name);             // Rex
            }
            */

            // ---------------------------------------------------------
            // CASE 10: PRIVATE
            // "private = only the Animal class can use it"
            // ---------------------------------------------------------
            /*
            {
                Animal a = new Animal();
                a.ShowSecret();                        // I am private  (the class itself reads it)
            }
            */

            // CASE 10b (ERROR): use the private field from outside
            /*
            {
                Animal a = new Animal();
                Console.WriteLine(a.secret);           // ERROR CS0122: inaccessible (private)
            }
            */

            // ---------------------------------------------------------
            // CASE 11: PROTECTED
            // "protected = this class and its children (Dog uses energy)"
            // ---------------------------------------------------------
            /*
            {
                Dog d = new Dog();
                d.Name = "Rex";
                d.UseProtected();                      // Rex energy now 9
            }
            */

            // CASE 11b (ERROR): use the protected field from outside
            /*
            {
                Animal a = new Animal();
                a.energy = 5;                          // ERROR CS0122: inaccessible (protected)
            }
            */

            // ---------------------------------------------------------
            // CASE 12: EVERYTHING TOGETHER (BankAccount)
            // "Owner is public, Pin is protected, _balance is private,
            //       and Balance can be read by all but changed only by the class"
            // ---------------------------------------------------------
            /*
            {
                BankAccount acc = new BankAccount();
                acc.Owner = "Wadea";                   // OK: public auto-property
                acc.Deposit(100m);                     // OK: the safe way to change Balance
                Console.WriteLine(acc.Owner + " has " + acc.Balance);   // Wadea has 100
            }
            */

            // CASE 12b: the rule inside the property rejects a bad value
            /*
            {
                BankAccount acc = new BankAccount();
                try
                {
                    acc.Deposit(-500m);                // Balance would become -500
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Rejected: " + ex.Message);   // Rejected: No negative balance
                }
            }
            */

            // CASE 12c (ERROR): set Balance from outside (private set)
            /*
            {
                BankAccount acc = new BankAccount();
                acc.Balance = 5m;                      // ERROR CS0272: set accessor is inaccessible
            }
            */

            // CASE 12d (ERROR): use the protected Pin from outside
            /*
            {
                BankAccount acc = new BankAccount();
                acc.Pin = "0000";                      // ERROR CS0122: inaccessible (protected)
            }
            */

            Console.ReadLine();                        // keeps the window open
        }
    }
}