using System;
using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        public delegate void ReadyDelegate();
        public event ReadyDelegate Ready;
        int numberObject = 0;
        public TableRequests tr; //TODO: It should not be public. The server should pass this tableRequest object as a argument of Ready delegate.

        public string[] result; //TODO: Since you are using it in Form1.cs, it's good to make it readonly property.
        public Server()
        {
        }

        public void Receive(int numberChicken, int numberEgg, menu typeDrink, string customerName)
        {
            if (numberObject == 0)
            {
                tr = new TableRequests();
                numberObject = 1;
            }

            //TODO: In this project it doesn't metter how many customers request in one time, because we are using Collection instead of array.
            int customer = 0;
            foreach (string c in tr)
            {
                customer++;
            }

            if (customer > 7)
            {
                throw new ArgumentOutOfRangeException("Maximum number of orders 8");
            }

            if (numberChicken >= 1) //TODO: Do we need this "if" condition here?
            {
                for (int i = 0; i < numberChicken; i++)
                {
                    tr.Add<Chicken>(customerName);
                }

            }

            if (numberEgg >= 1) //TODO: Do we need this "if" condition here?
            {
                for (int i = 0; i < numberEgg; i++)
                {
                    tr.Add<Egg>(customerName);
                }

            }

            if (typeDrink != menu.NoDrink)
            {
                if (typeDrink == menu.Pepsi)
                {
                    tr.Add<Pepsi>(customerName);
                }
                else if (typeDrink == menu.Cola)
                {
                    tr.Add<CocaCola>(customerName);
                }
                else
                {
                    tr.Add<Tea>(customerName);
                }
            }
        }

        public void Send()
        {
            if (numberObject == 0)
            {
                throw new NullReferenceException("Order not added!");
            }
            Ready();
        }

        //TODO: The server should iterate over the TableRequests and serve each food...
        public void Serve()
        {
            result = new string[0];
            List<ItemInterface> menuItem;
            int j = 0;
            foreach (string customer in tr)
            {
                menuItem = tr[customer];
                int numberChiken = 0;
                int numberEgg = 0;
                menu drink = menu.NoDrink;
                string drinkAll = "";
                foreach (ItemInterface order in menuItem)
                {

                    if (order is Chicken)
                    {
                        Chicken chicken = (Chicken)order;
                        numberChiken += chicken.GetQuantity();
                    }
                    else if (order is Egg)
                    {
                        Egg egg = (Egg)order;
                        numberEgg += egg.GetQuantity();
                    }
                    else
                    {
                        if (order is CocaCola)
                        {
                            drink = menu.Cola;
                            drinkAll = drinkAll + drink + ",";
                        }

                        if (order is Pepsi)
                        {
                            drink = menu.Pepsi;
                            drinkAll = drinkAll + drink + ",";
                        }

                        if (order is Tea)
                        {
                            drink = menu.Tea;
                            drinkAll = drinkAll + drink + ",";
                        }
                    }

                }

                if (drinkAll == "")
                    drinkAll = menu.NoDrink.ToString();

                Array.Resize(ref result, j + 1);
                result[j] = "Customer " + customer + " is served " + drinkAll + " " + numberChiken + " chicken, " + numberEgg + " egg";
                j++;

            }
            numberObject = 0;
        }
    }
}
