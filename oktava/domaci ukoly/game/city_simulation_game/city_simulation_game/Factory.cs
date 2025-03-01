using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    class Factory : Building
    {
        public Factory()
        {
            symbol = "[F]";
        }
        public override void AffectCity(City city)
        {
            city.budget -= 300;//cost of constuction
            city.income += 100;//main effect
            city.heal -= 1 * city.factories;//worse air conditions
        }
        public override void AgeBuilding(City city)
        {
            base.AgeBuilding(city);
            if (needs_repair)
            {
                Console.WriteLine("a factory needs repair, otherwise it will lower its production (enter)");
                Console.ReadKey();
                city.income -= 50;//old factory produces less
                needs_repair = false;
            }
        }
    }
}
