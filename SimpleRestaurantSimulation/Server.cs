using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        public delegate void ReadyDelegate();
        public event ReadyDelegate Ready;
        Cook cook = new Cook();
        int numberObject = 0;
        TableRequests<ItemInterface> tr;
        int customer = 0;
        string[] result;
        public Server()
        {
        }

        //TODO: Refactor this method to be smaller.
        public void Receive(int numberChicken, int numberEgg, menu typeDrink, string customerName)
        {
            if (numberObject == 0)
            {
                tr = new TableRequests<ItemInterface>();
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
                tr.Add(customerName, chicken);
            }

            if (numberEgg >= 1)
            {
                Egg egg = new Egg(numberEgg);
                tr.Add(customerName, egg);
            }

            if (typeDrink != menu.NoDrink)
            {
                if (typeDrink == menu.Pepsi)
                {
                    Pepsi pepsi = new Pepsi();
                    tr.Add(customerName, pepsi);
                }
                else if (typeDrink == menu.Cola)
                {
                    CocaCola cola = new CocaCola();
                    tr.Add(customerName, cola);
                }
                else
                {
                    Tea tea = new Tea();
                    tr.Add(customerName, tea);
                }
            }

            if (numberChicken >= 1 || numberEgg >= 1 || typeDrink != menu.NoDrink)
                customer++;
        }

        public void Send()
        {
            Ready += (() => { cook.Process(tr); });
            Ready();
        }

        //TODO: The server should iterate over the TableRequests and serve each food...
        public string[] Serve()
        {
            result = new string[0];
            List<ItemInterface> menuItem;
            int j = 0;
            foreach (string customer in tr.GetOrder())
            {
                menuItem = tr[customer];
                int numberChiken = 0;
                int numberEgg = 0;
                menu drink = menu.NoDrink;
                foreach (ItemInterface order in menuItem)
                {

                    if (order is Chicken)
                    {
                        Chicken chicken = (Chicken)menuItem[0];
                        numberChiken = chicken.GetQuantity();
                    }
                    else if (order is Egg)
                    {
                        Egg egg = (Egg)menuItem[1];
                        numberEgg = egg.GetQuantity();
                    }
                    else
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

                }

                Array.Resize(ref result, j + 1);
                result[j] = "Customer " + customer + " is served " + drink + ", " + numberChiken + " chicken, " + numberEgg + " egg";
                j++;

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
