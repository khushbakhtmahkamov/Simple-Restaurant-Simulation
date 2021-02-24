using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class TableRequests <T>:IEnumerable<T>
    {
        Dictionary<string,List<T>> menuItem = new Dictionary<string, List<T>>();
        public void Add(string customer, T i)
        {
            List<T> order=new List<T>();
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                if (keyValue.Key == customer)
                {
                    order = keyValue.Value;
                }
            }
            order.Add(i);
            menuItem[customer]= order;
           
        }

        public List<string> GetOrder()
        {
            List<string> order = new List<string>();
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                order.Add(keyValue.Key);
            }

            return order;
        }

        public List<T> Get(T order)
        {
            List<T> list = new List<T>();
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
                list.Add(keyValue.Value.Find(x=>x.GetType().Equals(order.GetType())));
            }
            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (KeyValuePair<string, List<T>> keyValue in menuItem)
            {
               foreach(T order in keyValue.Value)
               {
                    yield return order;
               }
                   
            }
        }

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
