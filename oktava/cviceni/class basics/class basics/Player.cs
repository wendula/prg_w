using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_basics
{
    internal class Player
    {
        public string name;
        int health;
        private int damage;

        public Player(string name, int health, int damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }
        public void SetDamage(int value)
        {
            damage = value;
            if (damage<=0)
            {
                damage = 1;
            }
        }
        public int GetDamage() { return damage; }
        public void Hurt(int incomingDamage)
        {
            health -= incomingDamage;
            Console.WriteLine("Player " + name + " got hurt for " + incomingDamage + " points.");

            if (health <= 0)
            {
                Console.WriteLine("Player " + name + " is dead.");
            }
        }

    }
}
