using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    abstract class Building
    {
        public string symbol;
        public int age = 0;
        public bool needs_repair = false;
        public virtual void AgeBuilding(City city) 
        { 
            age++; 
            if (age >= 10)
            {
                needs_repair = true;
            }
        }
        public abstract void AffectCity(City city);

    }
}
