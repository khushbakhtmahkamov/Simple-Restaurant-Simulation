using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    //TODO: Questions:
    //1. Why you make this class as generic?
    //2. Do we need to restrict this generic class (type T)? Because when using this class, user can pass different type here.
    //3. Why you used generic of IEnumerable? Can we implement just from IEnumerable?
    class TableRequests
    {
        Dictionary<string, List<ItemInterface>> menuItem = new Dictionary<string, List<ItemInterface>>();

        //TODO: This method for this project should like thisL Add<ChickenOrder>("Dilshod")
        public void Add<T>(string customer) where T:ItemInterface
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
            else if(type == typeof(Egg))
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

        public List<CookedFood> Get<T>() where T:CookedFood
        {
            List<CookedFood> list = new List<CookedFood>();
            foreach (KeyValuePair<string, List<ItemInterface>> keyValue in menuItem)
            {
                foreach(ItemInterface it in keyValue.Value)
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
                yield return  keyValue.Key;
            }
        }

        public List<ItemInterface> this[string customer]
        {
            get
            {
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
