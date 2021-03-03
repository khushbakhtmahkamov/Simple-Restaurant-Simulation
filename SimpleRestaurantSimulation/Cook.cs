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

            //TODO: Agar hamin proccessi puxtani chicken va egg-ro ba xudi classhoi Chicken va Egg implement kuned dar in metodi Process() code tamoman kam meshavad.
            menuItems = tr.Get<Chicken>();
            foreach (IMenuItem menuItem in menuItems)
            {
                Chicken chickOrder = (Chicken)menuItem;
                chickOrder.Obtain();
                chickOrder.CutUp();
                chickOrder.Cook();
            }

            menuItems = tr.Get<Egg>();
            foreach (IMenuItem menuItem in menuItems)
            {
                using (Egg eggOrder = (Egg)menuItem)
                {
                    try
                    {
                        eggOrder.Obtain();
                        eggOrder.Crack();
                    }
                    catch
                    {
                    }
                    eggOrder.Cook();
                }

            }

            Processed();
        }
    }
}
