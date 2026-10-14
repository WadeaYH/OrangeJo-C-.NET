using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adventure Game!");
            Console.WriteLine();

            List<GameCharacter> characters = new List<GameCharacter>();

            Warrior warrior = new Warrior("Conan", 75.5);
            Wizard wizard = new Wizard("Gandalf", 60.5);
            
            characters.Add(warrior);
            characters.Add(wizard);

            warrior.Heal();
            wizard.Heal();

            foreach (var character in characters)
            {
                if (character is Wizard)
                {
                    Console.WriteLine($"\nWizard: {character.Name} entered the game!");
                }
                else if (character is Warrior)
                {
                    Console.WriteLine($"\nWarrior: {character.Name} entered the game!");
                }
                character.UseSpecialAbility();
                character.TakeDamage(22.5);
                Console.WriteLine($"\n{character.Name} has {character.Health} health.");
                character.Heal(10);
                character.Heal();
                Console.WriteLine($"\n{character.Name} has {character.Health} health after healing.\n*****************************");
            }

            HealthPotion healthPotion = new HealthPotion("Golden Apple Potion");
            healthPotion.Collect();
            healthPotion.Use(warrior, "15");
            healthPotion.Use(wizard, "20");
            healthPotion.Use(warrior, "CAT");

        }
    }
}
