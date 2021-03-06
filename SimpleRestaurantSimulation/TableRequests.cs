﻿using System;
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
            Type type = typeof(T);
            List<IMenuItem> order = new List<IMenuItem>();
            var listMenu = menuItem.Select(m => m).Where(k => k.Key.Equals(customer)).Select(me => me.Value).ToList();
            if (listMenu.Count > 0)
                order = listMenu.Last();

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
            foreach (var keyValue in menuItem)
            {
                foreach (IMenuItem it in keyValue.Value)
                {
                    if (it is T)
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
    }
}
