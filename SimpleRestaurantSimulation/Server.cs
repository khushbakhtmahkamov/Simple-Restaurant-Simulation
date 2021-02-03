using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        Cook cook = new Cook();
        Object o;
        int numberObject = 0;
        menu[][] orderMenu;
        int countArray = 0;
        string[] result;
        public Server()
        {

        }

        public void Receive(int numberChicken,int numberEgg,menu typeDrink)
        {
            if (numberObject == 0)
            {
                orderMenu = new menu[8][];
                numberObject = 1;
                countArray = 0;
            }
            if(countArray>7)
            {
                throw new ArgumentOutOfRangeException("Maximum number of orders 8");
            }
            int count = 0;
            int countОaggedФrray = 0;
            if (typeDrink != menu.NoDrink)
            {
                count = 1;
            }
            count = count + numberChicken + numberEgg;
            orderMenu[countArray] = new menu[count];
            for(int i = 0; i < numberChicken; i++)
            {
                orderMenu[countArray][countОaggedФrray] = menu.Chicken;
                countОaggedФrray++;
            }
            for (int i = 0; i < numberEgg; i++)
            {
                orderMenu[countArray][countОaggedФrray] = menu.Egg;
                countОaggedФrray++;
            }
            if (typeDrink != menu.NoDrink)
            {
                orderMenu[countArray][countОaggedФrray] = typeDrink;
            }

            countArray++;
        }

        public void Send()
        {
            result = new string[countArray];
            
            for (int i = 0; i < countArray; i++)
            {
                menu drink =menu.NoDrink;
                int count = orderMenu[i].Length;
                int countChicken = 0;
                int countEgg = 0;
                for(int j = 0; j < count; j++)
                {
                    if (orderMenu[i][j] == menu.Chicken)
                    {
                        countChicken++;
                    }else if(orderMenu[i][j] == menu.Egg)
                    {
                        countEgg++;
                    }
                    else
                    {
                        drink = orderMenu[i][j];
                    }
                    
                }
                if (countChicken > 0)
                {
                   o = cook.Submit(menu.Chicken, countChicken);
                    cook.Prepare(o);
                }
                if (countEgg > 0)
                {
                   o = cook.Submit(menu.Egg, countEgg);
                   cook.Prepare(o);
                }
                result[i] = "Customer "+i+ " is served "+ countChicken+ " chicken, "+ countEgg+ " egg, "+drink;
            }
            
        }

        public string[] Serve()
        {
            numberObject = 0;
            return result;
        }
    }
}
