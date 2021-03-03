using System;
using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        public delegate void ReadyDelegate(TableRequests tr);
        public event ReadyDelegate Ready;
        bool isTableRequestCreated = false;
        private TableRequests tr;
        private string[] _result;

        public string[] Result
        {
            get
            {
                return _result;
            }
        }

        public void Receive(int numberChicken, int numberEgg, menu typeDrink, string customerName)
        {
            if (!isTableRequestCreated)
            {
                tr = new TableRequests();
                isTableRequestCreated = true;
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
            if (!isTableRequestCreated)
            {
                throw new NullReferenceException("Order not added!");
            }
            Ready(tr);
        }

        public void Serve()
        {
            _result = new string[0];
            
            int j = 0;
            foreach (KeyValuePair<string, List<IMenuItem>> customerMenus in tr)
            {
                int numberChiken = 0;
                int numberEgg = 0;
                string drinkAll = "";
                foreach (IMenuItem order in customerMenus.Value)
                {

                    if (order is Chicken)
                        numberChiken += ((Chicken)order).GetQuantity();
                    else if (order is Egg)
                        numberEgg += ((Egg)order).GetQuantity();
                    else if (order is CocaCola)
                        drinkAll = drinkAll + menu.Cola + ",";
                    else if (order is Pepsi)
                        drinkAll = drinkAll + menu.Pepsi + ",";
                    else if (order is Tea)
                        drinkAll = drinkAll + menu.Tea + ",";

                    order.Serve();
                }

                if (drinkAll == "")
                    drinkAll = menu.NoDrink.ToString();

                Array.Resize(ref _result, j + 1);
                _result[j] = "Customer " + customerMenus.Key + " is served " + drinkAll + " " + numberChiken + " chicken, " + numberEgg + " egg";
                j++;
            }
            isTableRequestCreated = true;
        }
    }
}
