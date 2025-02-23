using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome mayor! your city awaits you. what are you going to name it?");
            string city_name = Console.ReadLine();
            Console.WriteLine("bold choice! and how big of a city do you think you can manage? we advice somewhere between 5-10 blocks for a start, but we are only the city council, so it is up to you.");
            int city_size = 0;
            bool check = false;
            while (!check) { check = int.TryParse(Console.ReadLine(), out city_size); }
            City city = new City(city_size,city_name);
            Console.WriteLine("now for your turns. you can construct buildings, as many as you want to, if you have the money for it");

            while (true)
            {
                city.DisplayCity();
                if(city.satisfaction<1 || city.health<1)
                {
                    Console.WriteLine("your management absolutely failed. your citizens cannot live in a place like this. you have much to learn, byee");
                    break;
                }
                else if (city.buildings == city_size * city_size && city.satisfaction > 50 && city.health > 50 && city.education > 30 && city.budget > 0)
                {
                    Console.WriteLine("your skills are very appretiated, your citizens are content and can live live a happy live in the city you have build. you've won!");
                    break;
                }
                Console.WriteLine("what is your next action? \ntype 'exit' to end this turn\nbuild a house = 'O' (cost=100, adds population)\nbuild a factory = 'F' (cost=300, adds income, lowers health)\nbuild a hospital = 'H' (cost = 350, adds health)\nbuild a school = 'S' (cost = 350, adds education which adds to income)\nbuild a shopping centre = 'C' (cost=250, adds income and satisfaction)\nbuild a park = 'P' (cost=100, adds satisfaction and health)\nrepair a building = 'R' (cost=50)");
                string choice = Console.ReadLine().ToUpper();
                Building building = null;
                switch (choice)
                {
                    case "EXIT":
                        city.EndTurn();
                        break;
                    case "O":
                        building = new House();
                        city.AddBuilding(building);
                        break;
                    case "F":
                        building = new Factory();
                        city.factories++;
                        city.AddBuilding(building);
                        break;
                    case "H":
                        building = new Hospital();
                        city.AddBuilding(building);
                        break;
                    case "S":
                        building = new School();
                        city.AddBuilding(building);
                        break;
                    case "C":
                        building = new ShoppingCentre();
                        city.AddBuilding(building);
                        break;
                    case "P":
                        building = new Park();
                        city.AddBuilding(building);
                        break;
                    case "R":
                        Console.WriteLine("which building do you want to repair? enter X coordinate");
                        int x = 0;
                        int y = 0;
                        check = false;
                        while (!check) { check = int.TryParse(Console.ReadLine(), out x); }
                        Console.WriteLine("enter Y coordinate");
                        check = false;
                        while (!check) { check = int.TryParse(Console.ReadLine(), out y); }
                        city.RepairBuilding(x, y);
                        break;
                    default:
                        Console.WriteLine("that was something completely else than what we wanted");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
