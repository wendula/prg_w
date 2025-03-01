using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    class House : Building
    {   
        public House()
        {
            symbol = "[O]";
        }
        public override void AffectCity(City city)
        {
            city.population += 5;//effect
            city.budget -= 100;//cost of construction
        }
    }
}
