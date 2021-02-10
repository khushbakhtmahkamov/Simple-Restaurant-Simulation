using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class CookedFood : MenuItem
    {
        public CookedFood(int quantity) : base(quantity)
        {
        }

        public virtual void Cook()
        {

        }
    }
}
