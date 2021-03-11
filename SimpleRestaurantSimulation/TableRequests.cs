using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace SimpleRestaurantSimulation
{
    class TableRequests : IEnumerable
    {
        Dictionary<string, List<IMenuItem>> menuItem = new Dictionary<string, List<IMenuItem>>();

        public void Add<T>(string customer) where T : IMenuItem
        {
            //TODO: This method has some extra code. Can you refactor this method?
            Type type = typeof(T);
            List<IMenuItem> order = new List<IMenuItem>();
            foreach (KeyValuePair<string, List<IMenuItem>> keyValue in menuItem)
            {
                if (keyValue.Key == customer)
                {
                    order = keyValue.Value;
                }
            }

            IMenuItem menu;
            if (type == typeof(Egg) || type == typeof(Chicken))
                menu = (IMenuItem)Activator.CreateInstance(type, new Object[] { 1 });
            else
                menu = (IMenuItem)Activator.CreateInstance(type);

            order.Add(menu);

            menuItem[customer] = order;
        }

        public List<CookedFood> Get<T>() where T : CookedFood
        {
            List<CookedFood> list = new List<CookedFood>();
            foreach (KeyValuePair<string, List<IMenuItem>> keyValue in menuItem)
            {
                foreach (IMenuItem it in keyValue.Value)
                {
                    if (it.GetType().Equals(typeof(T)))
                    {
                        list.Add((CookedFood)it);
                    }
                }
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return menuItem.OrderBy(M => M.Key).GetEnumerator();
        }

        public List<IMenuItem> this[string customer]
        {
            get
            {
                return menuItem[customer];
            }
        }

    }
}
