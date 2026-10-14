using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__7
{
    internal class HealthPotion : ICollectible
    {
        private string PotionName { get; set; }
        public HealthPotion()
        {
            PotionName = "Health Potion";
        }

        public HealthPotion(string potionName)
        {
            PotionName = potionName;
        }

        public void Collect()
        {
            Console.WriteLine("\nYou have collected a health potion!");
        }

        public void Use(GameCharacter character, String amountText)
        {

            try
            {
                double amount = double.Parse(amountText);
                character.Heal(amount);
                Console.WriteLine($"\n{character.Name} used a health potion and now has {character.Health} health.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid amount entered. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred while using the health potion: {ex.Message}");
            }
        }
    }
}
