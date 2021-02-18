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
        int numberObject = 0;
        TableRequests tr;
        int customer = 0;
        string[] result;
        public Server()
        {
        }

        public void Receive(int numberChicken, int numberEgg, menu typeDrink)
        {
            if (numberObject == 0)
            {
                tr = new TableRequests();
                numberObject = 1;
                customer = 0;
            }
            if (customer > 7)
            {
                throw new ArgumentOutOfRangeException("Maximum number of orders 8");
            }

            if (numberChicken >= 1)
            {
                Chicken chicken = new Chicken(numberChicken);
                tr.Add(customer, chicken);
            }

            if (numberEgg >= 1)
            {
                Egg egg = new Egg(numberEgg);
                tr.Add(customer, egg);
            }

            if (typeDrink != menu.NoDrink)
            {
                if (typeDrink == menu.Pepsi)
                {
                    Pepsi pepsi = new Pepsi();
                    tr.Add(customer, pepsi);
                }
                else if (typeDrink == menu.Cola)
                {
                    CocaCola cola = new CocaCola();
                    tr.Add(customer, cola);
                }
                else
                {
                    Tea tea = new Tea();
                    tr.Add(customer, tea);
                }
            }

            if(numberChicken >= 1 || numberEgg >= 1 || typeDrink != menu.NoDrink)
                customer++;
        }

        public void Send()
        {
            cook.Process(tr);
        }

        public string[] Serve()
        {
            result = new string[customer];
            ItemInterface[] menuItem;
            for (int i = 0; i < customer; i++)
            {
                menuItem = tr[i];
                int numberChiken = 0;
                int numberEgg = 0;
                menu drink = menu.NoDrink;
                if (menuItem[0] != null)
                {
                    Chicken chicken = (Chicken)menuItem[0];
                    numberChiken = chicken.GetQuantity();
                }

                if (menuItem[1] != null)
                {
                    Egg egg = (Egg)menuItem[1];
                    numberEgg = egg.GetQuantity();
                }

                if (menuItem[2] != null)
                {
                    if (menuItem[2] is CocaCola)
                    {
                        drink = menu.Cola;
                    }

                    if (menuItem[2] is Pepsi)
                    {
                        drink = menu.Pepsi;
                    }

                    if (menuItem[2] is Tea)
                    {
                        drink = menu.Tea;
                    }
                }
                result[i] = "Customer " + i + " is served " + numberChiken + " chicken, " + numberEgg + " egg, " + drink;
            }

            if (result == null || result.Length == 0)
            {
                throw new NullReferenceException("order not sent to the Cook");
            }
            numberObject = 0;
            return result;
        }
    }
}
