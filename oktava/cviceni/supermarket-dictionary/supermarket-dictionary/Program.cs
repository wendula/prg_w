using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> supermarket = new Dictionary<string, int>();

            supermarket["butter"] = 50;
            supermarket["cheese"] = 45;
            supermarket["bread"] = 15;
            


            Console.ReadKey();
        }
    }
}
