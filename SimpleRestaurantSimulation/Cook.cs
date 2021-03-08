using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    class Cook
    {
        public delegate void ProcessedDelegate();
        public event ProcessedDelegate Processed;

        public void Process(TableRequests tr)
        {
            List<CookedFood> menuItems;
            //TODO: menuItems is always empty. Please debug and fix this problem.

            menuItems = tr.Get<CookedFood>();
            foreach (IMenuItem menuItem in menuItems)
            {
                Chicken chickOrder = (Chicken)menuItem;
                chickOrder.Prepare();
                using (Egg eggOrder = (Egg)menuItem)
                {
                    eggOrder.Prepare();
                }
            }

            Processed();
        }
    }
}
