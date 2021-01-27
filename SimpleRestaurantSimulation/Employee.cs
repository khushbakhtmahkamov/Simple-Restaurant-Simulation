using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Employee
    {
        public static int NumEmployee = 0;
        private Object objectOrder;
        private int prepared = 0;
        

        public Employee()
        {
            NumEmployee++;
        }

        public object NewRequest(int quantity, string menuItem)
        {
           if(NumEmployee % 3 == 0)
            {
                if(menuItem == "egg")
                {
                    menuItem = "chicken";
                }
                else
                {
                    menuItem = "egg";
                }
            }
            
            if (menuItem == "egg")
            {
                EggOrder eggOrder = new EggOrder(quantity);
                this.objectOrder = eggOrder;
            }
            else
            {
                ChickenOrder chickenOrder = new ChickenOrder(quantity);
                this.objectOrder = chickenOrder;
            }
            return this.objectOrder;
        }

        public object CopyRequest()
        {
            prepared = 0;
            if (objectOrder == null)
            {
                throw new Exception();
            }
            Object o;
            o = objectOrder;
            if (objectOrder is EggOrder)
            {
                //EggOrder уggOrder = new EggOrder();
            }
            else
            {

            }
            return o;
        }

        public string Inspect(object ob)
        {
            
            if(ob is ChickenOrder)
            {
                return "no inspection is required";
            }
            else
            {
                EggOrder eggOrder = (EggOrder)ob;
                return "Egg Quality:"+eggOrder.GetQuality();
            }
        }

        public string PrepareFood(object ob)
        {
            if (prepared == 1)
            {
                throw new Exception();
            }

            prepared = 1;

            if(ob is ChickenOrder)
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
                return "Preparation has been completed. Number of rotten eggs-"+ countRottenEggs;
            }
        }


    }
}
