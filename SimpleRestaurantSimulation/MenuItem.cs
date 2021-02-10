using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    abstract class MenuItem:ItemInterface
    {
        public int quantity;
        public MenuItem(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity() => this.quantity;

        public void Obtained()
        {

        }

        public void Served()
        {

        }
    }
}
