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
        menu[][] orderMenu; //TODO: in massiv lozim nest 
        
        TableRequests tr;
        int countArray = 0;
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
                orderMenu = new menu[8][];
                numberObject = 1;
                countArray = 0;
                customer = 0;
            }
            if (customer > 7)
            {
                throw new ArgumentOutOfRangeException("Maximum number of orders 8");
            }

            if (numberChicken > 0)
            {
                ItemInterface i; //TODO: Be istifodai hamin variable shuda metavonad. Inchunin codei hamin methodro kam kuned.
                Chicken chicken = new Chicken(numberChicken);
                i = chicken;
                tr.Add(customer, i);
            }

            if (numberEgg > 0)
            {
                ItemInterface i;
                Egg egg = new Egg(numberEgg);
                i = egg;
                tr.Add(customer, i);
            }

            if (typeDrink != menu.NoDrink)
            {
                ItemInterface i;
                if (typeDrink == menu.Pepsi)
                {
                    Pepsi pepsi = new Pepsi(1);
                    i = pepsi;
                }
                else if(typeDrink == menu.Cola)
                {
                    CocaCola cola = new CocaCola(1);
                    i = cola;
                }
                else
                {
                    Tea tea = new Tea(1);
                    i = tea;
                }
                tr.Add(customer, i);
            }
            customer++;
            
        }

        public string Send()
        {
            string qualityResult = ""; //TODO: ?
            cook.Process(tr);

            
            return qualityResult;
        }

        public string[] Serve()
        {
            result = new string[customer];
            ItemInterface[] menuItem;
            for(int i = 0; i < customer; i++)
            {
                menuItem = tr[i];
                int numberChiken = 0;
                int numberEgg = 0;
                menu drink = menu.NoDrink;
                if (menuItem[0] != null)
                {
                    Chicken chicken = (Chicken)menuItem[0];
                    numberChiken=chicken.GetQuantity();
                }

                if (menuItem[1] != null)
                {
                    Egg egg = (Egg)menuItem[1];
                    numberEgg = egg.GetQuantity();
                }

                if (menuItem[2] != null)
                {
                    if(menuItem[2] is CocaCola)
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

            if (result == null || result.Length==0 )
            {
                throw new NullReferenceException("order not sent to the Cook");
            }
            numberObject = 0;
            return result;
        }
    }
}
