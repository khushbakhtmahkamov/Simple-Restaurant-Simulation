using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    abstract class CookedFood : MenuItem
    {
        public int quantity;
        public CookedFood(int quantity) : base()
        {
            this.quantity = quantity;
        }

        public int GetQuantity() => this.quantity;

        public override void Obtained()
        {

        }

        public override void Served()
        {
           
        }

        public abstract void Cook();
    }
}
