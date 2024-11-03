using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list__dictionary
{
    internal class Program
    {
        static string AddFood()//nabere hodnotu pro přidání do seznamu
        {
            Console.WriteLine("Jaké jídlo chceš přidat do seznamu?");
            string user = Console.ReadLine();
            return user;
        }
        static string RemoveFood()//nabere hodnotu pro odebrání ze seznamu
        {
            Console.WriteLine("Jaké jídlo chceš odebrat ze seznamu?");
            string user = Console.ReadLine();
            return user;
        }
        static void Main(string[] args)
        {
            List<string> food = new List<string>();
            string user;

            while(true)
            {
                Console.WriteLine("Co bys rád udělal se svým seznamem oblíbených jídel? \nPŘIDAT/ODEBRAT");
                user = Console.ReadLine();
                if (user == "PŘIDAT")
                {
                    user = AddFood();
                    if (food.Contains(user))//kontrola duplikátů
                    {
                        Console.WriteLine("Toto jídlo už v seznamu máš, nemusíš ho přidávat znovu.");
                    }
                    else
                    {
                        food.Add(user);
                    }
                }
                else if (user == "ODEBRAT")
                {
                    user = RemoveFood();
                    if (food.Contains(user))//kontrola přítomnosti
                    {
                        food.Remove(user);
                    }
                    else
                    {
                        Console.WriteLine("Tohle jídlo v seznamu není, nemůžeš ho odebrat.");
                    }
                }
                else
                {
                    Console.WriteLine("Takovou možnost nevedeme, nevadí.");
                }
                Console.WriteLine();
                Console.WriteLine("Seznam oblíbených jídel:");
                foreach(string item in food)//vypsání listu
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
