using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__7
{
    internal class Warrior : GameCharacter
    {
        public Warrior(string name, double health) : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine($"\nThe warrior attacks with a powerful sword strike!");
        }

        public override void TakeDamage(double damage)
        {
            damage = damage - 2;
            health -= damage;
            Console.WriteLine($"\n{Name} took {damage} damage and now has {Health} health.");
        }
    }
}
