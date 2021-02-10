using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    //TODO: in abstract class meshavad
    class Drink : MenuItem
    {
        //TODO: Baroi drink quantity lozim nest.
        public Drink(int quantity) : base(quantity)
        {
        }

        //TODO: Drinks() method baroi chi lozim ast? 
        public virtual void Drinks()
        {

        }
    }
}
