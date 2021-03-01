using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {
        public delegate void ProcessedDelegate();
        public event ProcessedDelegate Processed;
        public Cook()
        {
        }

        public void Process(TableRequests tr)
        {
            List<CookedFood> menuItems;

            menuItems = tr.Get<Chicken>();
            foreach (ItemInterface menuItem in menuItems)
            {
                Chicken chickOrder = (Chicken)menuItem;
                chickOrder.CutUp();
                chickOrder.Cook();
            }

            menuItems = tr.Get<Egg>();
            foreach (ItemInterface menuItem in menuItems)
            {
                using (Egg eggOrder = (Egg)menuItem)
                {
                    try
                    {
                        eggOrder.Crack();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                    }

                    eggOrder.DiscardShell();
                    eggOrder.Cook();
                }

            }

            Processed();
        }
    }

    
}
