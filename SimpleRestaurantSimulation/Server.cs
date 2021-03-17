using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        bool isTableRequestCreated = false;
        private TableRequests _tr;
        private string[] _result;

        public TableRequests Tr
        {
            get
            {
                return _tr;
            }
        }

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
                _tr = new TableRequests();
                isTableRequestCreated = true;
            }

            for (int i = 0; i < numberChicken; i++)
            {
                _tr.Add<Chicken>(customerName);
            }


            for (int i = 0; i < numberEgg; i++)
            {
                _tr.Add<Egg>(customerName);
            }

            if (typeDrink != menu.NoDrink)
            {
                if (typeDrink == menu.Pepsi)
                {
                    _tr.Add<Pepsi>(customerName);
                }
                else if (typeDrink == menu.Cola)
                {
                    _tr.Add<CocaCola>(customerName);
                }
                else
                {
                    _tr.Add<Tea>(customerName);
                }
            }
        }

        public void Send()
        {
            if (!isTableRequestCreated)
            {
                throw new NullReferenceException("Order not added!");
            }
            isTableRequestCreated = false;
        }

        public Task Serve(TableRequests tr)
        {
            Task t = Task.Run(() =>
            {
                System.Threading.Thread.Sleep(4000);
                _result = new string[0];

                //TODO: Can you try to use LINQ instead if these 2 'foreach' ?
                //can`t use linq in TableRequest
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
                
            });
            return t;

        }
    }
}
