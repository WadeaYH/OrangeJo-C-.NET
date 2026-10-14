using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__7
{
    internal class Wizard : GameCharacter
    {
        public Wizard(string name, double health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine($"\nThe wizard uses magic!");
        }

        public override void TakeDamage(double damage)
        {
            health -= damage;
            Console.WriteLine($"\n{Name} took {damage} damage and now has {Health} health.");
        }
    }
}
