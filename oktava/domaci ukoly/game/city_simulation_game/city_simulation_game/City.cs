using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    internal class City
    {
        private string name;
        public int population = 0;
        public int budget = 1000;
        public int income = 0;
        public int satisfaction = 50;
        public int satis = 0;
        public int education = 0;
        public int educate = 0;
        public int factories = 0;
        public int health = 50;
        public int heal;
        public int turn = 1;
        public int buildings = 0;
        public Building[,] Grid { get; set; }
        private int size;

        public City(int size, string name)
        {
            this.size = size;
            Grid = new Building[size, size];
            this.name = name;
        }

        public void AddBuilding(Building building)
        {
            Console.WriteLine("where do we place the building? give me a X coordinate (counting from 0)");
            int x = 0;
            int y = 0;
            bool check = false;
            while (!check) { check = int.TryParse(Console.ReadLine(), out x); }
            Console.WriteLine("and an Y coordinate, please");
            check = false;
            while (!check) { check = int.TryParse(Console.ReadLine(), out y); }
            if (x >= 0 && x < size && y >= 0 && y < size && Grid[y, x] == null)
            {
                Grid[y,x] = building;
                buildings++;
                building.AffectCity(this);
            }
            else
            {
                Console.WriteLine("uhm, nope, definitely not there. you already have a building there, or you're trying to build on a nonexistent street");
            }
        }
        public void EndTurn()
        {
            budget += income;
            health += heal;
            satisfaction += satis;
            education += educate;
            if (population > income / 10)
            {
                satisfaction -= 5;
            }
            else satisfaction += 2;
            turn++;

            // Age buildings and check repairs
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Grid[i, j] != null)
                    {
                        Grid[i, j].AgeBuilding(this);
                    }
                }
            }
        }
        public void RepairBuilding(int x, int y)
        {
            if (x >= 0 && x < size && y >= 0 && y < size && Grid[y, x] != null)
            {
                Grid[y, x].age = 0;
                Console.WriteLine("well done, building repaired");
                Console.ReadKey();
                budget -= 50;
            }
            else
            {
                Console.WriteLine("there's definitely no building here!");
                Console.ReadKey();
            }
        }
        public void DisplayCity()
        {
            Console.Clear();
            Console.WriteLine($"city: {name}, turn: {turn}");
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Grid[i, j] != null)
                    {
                        Console.Write(Grid[i, j].symbol);
                    }
                    else
                    {
                        Console.Write("[-]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"population: {population}, budget: {budget}, satisfaction: {satisfaction}, health: {health}, education: {education}");
            Console.WriteLine();
        }
    }
}
