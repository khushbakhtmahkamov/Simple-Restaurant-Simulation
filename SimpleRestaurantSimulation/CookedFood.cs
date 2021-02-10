using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    //TODO: in abstract class meshavad
    class CookedFood : MenuItem
    {
        public CookedFood(int quantity) : base(quantity)
        {
        }
        //TODO: in abstract method meshavad
        public virtual void Cook()
        {

        }
    }
}
