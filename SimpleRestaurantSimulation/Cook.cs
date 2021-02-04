using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {        
        private Order objectOrder;
        public Cook()
        {

        }

        public object Submit(menu menu, int quantity)
        {
            if (menu == menu.Chicken)
            {
                ChickenOrder chickenOrder = new ChickenOrder(quantity);
                this.objectOrder = chickenOrder;
            }
            else if (menu == menu.Egg)
            {
                EggOrder eggOrder = new EggOrder(quantity);
                this.objectOrder = eggOrder;
            }

            return this.objectOrder;
        }

        public string Inspect()
        {
            if (this.objectOrder is ChickenOrder)
            {
                return "no inspection is required";
            }
            else
            {
                EggOrder eggOrder = (EggOrder)this.objectOrder;
                return "Egg Quality:" + eggOrder.GetQuality();
            }
        }
        
        public string Prepare()
        {
            
            if (this.objectOrder is ChickenOrder)
            {
                ChickenOrder chickOrder = (ChickenOrder)this.objectOrder;

                for (int i = 1; i <= chickOrder.GetQuantity(); i++)
                {
                    chickOrder.CutUp();
                }
                chickOrder.Cook();
                return "Preparation has been completed.";
            }
            else
            {
                int countRottenEggs = 0;
                EggOrder eggOrder = (EggOrder)this.objectOrder;
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
                return "Preparation has been completed. Number of rotten eggs-" + countRottenEggs;
            }
        }


    }
}
