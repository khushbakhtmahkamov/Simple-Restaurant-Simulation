using System;
using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        public delegate void ReadyDelegate(TableRequests tr);
        public event ReadyDelegate Ready;
        int numberObject = 0;
        private TableRequests tr; 
        private string[] _result;

        public string[] Result
        {
            get
            {
               return _result;
            }
        }
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

            for (int i = 0; i < numberChicken; i++)
            {
                tr.Add<Chicken>(customerName);
            }

           
            for (int i = 0; i < numberEgg; i++)
            {
                tr.Add<Egg>(customerName);
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
            Ready(tr);
        }
        
        public void Serve()
        {
            _result = new string[0];
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

                Array.Resize(ref _result, j + 1);
                _result[j] = "Customer " + customer + " is served " + drinkAll + " " + numberChiken + " chicken, " + numberEgg + " egg";
                j++;

            }
            numberObject = 0;
        }
    }
}
