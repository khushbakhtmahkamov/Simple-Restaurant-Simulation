using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    abstract class Drink : MenuItem
    {
        public Drink() : base()
        {
        }

        //TODO: Obtain and Serve methods should be abstract in this class
        public override void Obtained()
        {
        }

        public override void Served()
        {
        }
    }
}
