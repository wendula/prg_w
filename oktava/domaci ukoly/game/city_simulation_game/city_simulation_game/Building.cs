using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_simulation_game
{
    abstract class Building//abstract class for all types of buildings
    {
        public string symbol;
        public int age = 0;
        public bool needs_repair = false;
        public virtual void AgeBuilding(City city) //ages buildings through turns
        { 
            age++; 
            if (age >= 10)
            {
                needs_repair = true;
            }
        }
        public abstract void AffectCity(City city);//different actions for each building

    }
}
