using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    internal class ShoppingCentre : Building
    {
        public ShoppingCentre()
        {
            symbol = "[C]";
        }
        public override void AffectCity(City city)
        {
            city.budget -= 250;
            city.satis += 1;
            city.income += 50;
        }
    }
}
