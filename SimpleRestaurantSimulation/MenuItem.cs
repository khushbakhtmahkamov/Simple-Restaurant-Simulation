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

        public abstract void Obtained();

        public abstract void Served();
    }
}
