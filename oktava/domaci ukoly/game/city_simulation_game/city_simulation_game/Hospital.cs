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
            city.heal = 4;//effect
            city.budget -= 350;//cost of construction
        }
        public override void AgeBuilding(City city)
        {
            base.AgeBuilding(city);
            if (needs_repair)
            {
                Console.WriteLine("a hospital needs repair, otherwise it will lower its production (enter)");
                Console.ReadKey();
                city.heal -= 2;//old hospitals do not work so well
                needs_repair = false;
            }
        }
    }
}
