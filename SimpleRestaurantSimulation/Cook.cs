using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {        
        //private MenuItem objectOrder;
        public Cook()
        {

        }

        public void Process(TableRequests tr)
        {
            Chicken ch=new Chicken(1);
            ItemInterface[] menuItems;
            menuItems = tr[ch];
            foreach(ItemInterface menuItem in menuItems)
            {
                Chicken chickOrder = (Chicken)menuItem;
                for (int i = 1; i <= chickOrder.GetQuantity(); i++)
                {
                    chickOrder.CutUp();
                }
                chickOrder.Cook();
            }

            Egg egg = new Egg(1);
            menuItems = tr[egg];
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
        }

       /* public string Inspect()
        {
            if (this.objectOrder is Chicken)
            {
                return "no inspection is required";
            }
            else
            {
                Egg egg = (Egg)this.objectOrder;
                return "Egg Quality:" + egg.GetQuality();
            }
        }
        */

    }
}
