using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    internal class Hospital : Building
    {
        public Hospital()
        {
            symbol = "[H]";
        }
        public override void AffectCity(City city)
        {
            city.heal = 4;
            city.budget -= 350;
        }
        public override void AgeBuilding(City city)
        {
            base.AgeBuilding(city);
            if (needs_repair)
            {
                Console.WriteLine("a hospital needs repair, otherwise it will lower its production");
                Console.ReadKey();
                city.heal -= 2;
                needs_repair = false;
            }
        }
    }
}
