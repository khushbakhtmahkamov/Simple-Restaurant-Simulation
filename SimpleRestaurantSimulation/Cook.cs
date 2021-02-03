using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Cook
    {
        private Object objectOrder;
        private int prepared = 0;
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
            else if(menu == menu.Egg){
                EggOrder eggOrder = new EggOrder(quantity);
                this.objectOrder = eggOrder;
            }

            return this.objectOrder;
        }

        public string Prepare(object ob)
        {
            if (ob is ChickenOrder)
            {
                ChickenOrder chickOrder = (ChickenOrder)ob;

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
                EggOrder eggOrder = (EggOrder)ob;
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
