using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    internal class Park : Building
    {
        public Park()
        {
            symbol = "[P]";
        }
        public override void AffectCity(City city)
        {
            city.budget -= 100;
            city.satis += 1;
            city.heal += 1;
        }
    }
}
