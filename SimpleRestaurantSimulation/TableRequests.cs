using System;
using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    //TODO: Shouldn't we inherit this class from IEnumarable intercafe?
    class TableRequests
    {
        Dictionary<string, List<ItemInterface>> menuItem = new Dictionary<string, List<ItemInterface>>();

        //TODO: Can you refactor this method and make this smaller? I think I sent you a link about using Activator class.
        public void Add<T>(string customer) where T : ItemInterface
        {
            Type type = typeof(T);
            List<ItemInterface> order = new List<ItemInterface>();
            foreach (KeyValuePair<string, List<ItemInterface>> keyValue in menuItem)
            {
                if (keyValue.Key == customer)
                {
                    order = keyValue.Value;
                }
            }

            if (type == typeof(Chicken))
            {
                Chicken chicken = new Chicken(1);
                order.Add(chicken);
            }
            else if (type == typeof(Egg))
            {
                Egg egg = new Egg(1);
                order.Add(egg);
            }
            else
            {
                if (type == typeof(Pepsi))
                {
                    Pepsi pepsi = new Pepsi();
                    order.Add(pepsi);
                }
                else if (type == typeof(CocaCola))
                {
                    CocaCola cola = new CocaCola();
                    order.Add(cola);
                }
                else
                {
                    Tea tea = new Tea();
                    order.Add(tea);
                }
            }

            menuItem[customer] = order;
        }

        public List<CookedFood> Get<T>() where T : CookedFood
        {
            List<CookedFood> list = new List<CookedFood>();
            foreach (KeyValuePair<string, List<ItemInterface>> keyValue in menuItem)
            {
                foreach (ItemInterface it in keyValue.Value)
                {
                    if (it.GetType().Equals(typeof(T)))
                    {
                        list.Add((CookedFood)it);
                    }
                }
            }
            return list;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (KeyValuePair<string, List<ItemInterface>> keyValue in menuItem)
            {
                yield return keyValue.Key;
            }
        }

        public List<ItemInterface> this[string customer]
        {
            get
            {
                //TODO: Can we use this code: return menuItem[customer];
                List<ItemInterface> result = new List<ItemInterface>();
                foreach (KeyValuePair<string, List<ItemInterface>> keyValue in menuItem)
                {
                    if (keyValue.Key == customer)
                    {
                        result = keyValue.Value;
                    }
                }
                return result;
            }
        }

    }
}
