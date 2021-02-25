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
    class TableRequests<T> : IEnumerable<T>
    {
        Dictionary<string, List<T>> menuItem = new Dictionary<string, List<T>>();

        //TODO: This method for this project should like thisL Add<ChickenOrder>("Dilshod")
        public void Add(string customer, T i)
        {
            List<T> order = new List<T>();
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                if (keyValue.Key == customer)
                {
                    order = keyValue.Value;
                }
            }
            order.Add(i);
            menuItem[customer] = order;

        }

        //TODO: We don't need this method as it's not definied in presentation
        public List<string> GetOrder()
        {
            List<string> order = new List<string>();
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                order.Add(keyValue.Key);
            }

            return order;
        }

        //TODO: according to the presentation this method should be like this: Get<ChickenOrder>()
        public List<T> Get(T order)
        {
            List<T> list = new List<T>();
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                list.Add(keyValue.Value.Find(x => x.GetType().Equals(order.GetType())));
            }
            return list;
        }

        //TODO: Where this method will be used?
        public IEnumerator<T> GetEnumerator()
        {
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                foreach (T order in keyValue.Value)
                {
                    yield return order;
                }

            }
        }

        //TODO: Do you think we need this method which is not implpemented
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public List<T> this[string customer]
        {
            get
            {
                List<T> result = new List<T>();
                foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
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
