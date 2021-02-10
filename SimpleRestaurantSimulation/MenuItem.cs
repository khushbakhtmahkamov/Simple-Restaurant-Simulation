using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    abstract class MenuItem : ItemInterface
    {
        public int quantity;
        public MenuItem(int quantity)
        {
            this.quantity = quantity;
        }

        //TODO: remove this method
        public int GetQuantity() => this.quantity;

        //TODO: Obtained() and Served() methods should be abstract
        public void Obtained()
        {

        }

        public void Served()
        {

        }
    }
}
