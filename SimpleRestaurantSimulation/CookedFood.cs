using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    //TODO: in abstract class meshavad
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

        //TODO: in abstract method meshavad
        public abstract void Cook();
    }
}
