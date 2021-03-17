using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {
        public status Status = status.Free;
        
        public Task Process(TableRequests tr)
        {
            Task t = Task.Run(() =>
              {
                  this.Status = status.Busy;
                  List<CookedFood> menuItems;
                  
                  menuItems = tr.Get<CookedFood>();
                  Parallel.ForEach(menuItems, menuItem => {
                      menuItem.Prepare();
                  });
                  this.Status = status.Free;
              });
            
            return t;
        }
    }
}
