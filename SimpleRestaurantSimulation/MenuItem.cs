using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    abstract class MenuItem : ItemInterface
    {
        
        public MenuItem()
        {
        }

        //TODO: remove this method


        //TODO: Obtained() and Served() methods should be abstract
        public abstract void Obtained();

        public abstract void Served();
    }
}
