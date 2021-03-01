using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    class TableRequests:IEnumerable
    {
        Dictionary<string, List<ItemInterface>> menuItem = new Dictionary<string, List<ItemInterface>>();
        
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
            
            
            if (type == typeof(Egg) || type == typeof(Chicken))
            {
                object o = Activator.CreateInstance(type,new Object[] { 1});
                order.Add((ItemInterface)o);
            }
            else
            {
                object o = Activator.CreateInstance(type);
                order.Add((ItemInterface)o);
               
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

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }

        public List<ItemInterface> this[string customer]
        {
            get
            {
                return menuItem[customer];
            }
        }

    }
}
