using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Řehoř", 100, 10);
            Enemy enemy1 = new Enemy("Ghost", 10, 5, 2);
            Enemy enemy2 = new Enemy("Bandit", 40, 15, 3);
        }
    }
}
