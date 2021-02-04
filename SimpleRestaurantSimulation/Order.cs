﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Order
    {
        public int quantity;
        public Order(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity() => this.quantity;

        //TODO: This method should overriden in derived classes
        public void Cook()
        {

        }

    }
}
