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
            city.budget -= 100;//cost of construction
            city.satis += 2;//more fun for citizens
            city.heal += 1;//greener city - healthier citizens
        }
    }
}
