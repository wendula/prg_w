using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace class_basics
{
    internal class Enemy
    {
        string name;
        int health;
        int damage;
        int level;

        public Enemy (string name, int health, int damage, int level)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.level = level;
        }
        public void Hurt (int incomingDamage)
        {
            health -= incomingDamage;
            Console.WriteLine("Enemy " + name + " got hurt for " + incomingDamage + " points.");

            if (health <= 0) 
            {
                Console.WriteLine("Enemy " + name + " is dead.");
            }
        } 
    }
}
