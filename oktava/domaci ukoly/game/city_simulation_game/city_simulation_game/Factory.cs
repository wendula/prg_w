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
            city.budget -= 300;
            city.income += 100;
            city.heal -= 1 * city.factories;
        }
        public override void AgeBuilding(City city)
        {
            base.AgeBuilding(city);
            if (needs_repair)
            {
                Console.WriteLine("a factory needs repair, otherwise it will lower its production");
                Console.ReadKey();
                city.income -= 50;
                needs_repair = false;
            }
        }
    }
}
