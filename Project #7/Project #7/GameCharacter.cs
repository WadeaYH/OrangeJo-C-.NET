using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__7
{
    internal abstract class GameCharacter
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected double health;

        public double Health
        {
            get { return health; }
            set { 
                
                if (health <= 100 && health >= 0) health = value;
                else throw new ArgumentOutOfRangeException("\nHealth must be between 0 and 100.");
            }
        }

        public GameCharacter(string name, double health)
        {
            this.name = name;
            this.health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(double damage)
        {
            health -= damage;
            if (health < 0)
            {
                health = 0;
            }
        }


        public void Heal()
        {
            health += 10;
            if (health > 100)
            {
                health = 100;
            }
            Console.WriteLine($"\n{Name} healed for 10 health points.");
        }

        public void Heal(double amount)
        {
            health += amount;
            if (health > 100)
            {
                health = 100;
            }
            Console.WriteLine($"\n{Name} healed for {amount} health points.");
        }


    }
}
