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

        public void Process(TableRequests<ItemInterface> tr)
        {
            Chicken ch = new Chicken(1);
            List<ItemInterface> menuItems;
            menuItems = tr.Get(ch);
            foreach (ItemInterface menuItem in menuItems)
            {
                Chicken chickOrder = (Chicken)menuItem;
                for (int i = 1; i <= chickOrder.GetQuantity(); i++)
                {
                    chickOrder.CutUp();
                }
                chickOrder.Cook();
            }

            Egg egg = new Egg(1);
            menuItems = tr.Get(egg);
            int countRottenEggs = 0;

            foreach (ItemInterface menuItem in menuItems)
            {
                using (Egg eggOrder = (Egg)menuItem)
                {
                    for (int i = 1; i <= eggOrder.GetQuantity(); i++)
                    {
                        try
                        {
                            eggOrder.Crack();
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            countRottenEggs++;
                        }

                        eggOrder.DiscardShell();
                    }
                    eggOrder.Cook();
                }

            }

           // Processed();
        }
    }
}
