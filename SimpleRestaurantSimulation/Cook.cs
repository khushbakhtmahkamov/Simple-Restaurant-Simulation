using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {
        public Task Process(TableRequests tr)
        {
            Task t = Task.Run(() =>
              {
                  System.Threading.Thread.Sleep(4000);
                  List<CookedFood> menuItems;

                  menuItems = tr.Get<Chicken>();
                  foreach (IMenuItem menuItem in menuItems)
                  {
                      Chicken chickOrder = (Chicken)menuItem;
                      chickOrder.Prepare();
                  }

                  menuItems = tr.Get<Egg>();
                  foreach (IMenuItem menuItem in menuItems)
                  {
                      using (Egg eggOrder = (Egg)menuItem)
                      {
                          eggOrder.Prepare();
                      }
                  }
              });
            return t;
        }
    }
}
