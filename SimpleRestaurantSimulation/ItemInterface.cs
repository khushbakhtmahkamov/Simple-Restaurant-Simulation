using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    interface ItemInterface
    {
        int GetQuantity();
        void Obtained();
        void Served();
    }
}
