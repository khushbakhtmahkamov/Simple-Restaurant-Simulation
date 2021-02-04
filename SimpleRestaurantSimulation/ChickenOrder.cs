using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class ChickenOrder : Order
    {
        //private int quantity;
        public ChickenOrder(int quantity) : base(quantity)
        {
            //this.quantity = quantity;
        }

        // public int GetQuantity()=> this.quantity;

        public void CutUp()
        {

        }

    }
}
