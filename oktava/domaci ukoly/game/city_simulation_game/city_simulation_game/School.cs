using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    internal class School : Building
    {
        public School()
        {
            symbol = "[S]";
        }
        public override void AffectCity(City city)
        {
            city.budget -= 350;//cost of construction
            city.educate += city.population;//schools educate the amount of population present in the time of their construction 
            city.income += (city.population * city.factories / 2);//better education -> better economy
        }
    }
}
