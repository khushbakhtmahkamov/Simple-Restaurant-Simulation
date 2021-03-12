﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {
        public status Status = status.Free;
        private TableRequests _tr;

        public TableRequests Tr
        {
            get
            {
                return _tr;
            }
            set
            {
                _tr = value;
            }
        }
        public Task Process()
        {
            this.Status = status.Busy;
            Task t = Task.Run(() =>
              {
                  System.Threading.Thread.Sleep(4000);
                  List<CookedFood> menuItems;
                  
                  menuItems = _tr.Get<CookedFood>();
                  foreach (IMenuItem menuItem in menuItems)
                  {                      
                      if (menuItem is Chicken)
                      {
                          Chicken chickOrder = (Chicken)menuItem;
                          chickOrder.Prepare();
                      }
                      else
                      {
                          using (Egg eggOrder = (Egg)menuItem)
                          {
                              eggOrder.Prepare();
                          }
                      }
                     
                  }

              });
            this.Status = status.Busy;
            return t;
        }
    }
}
