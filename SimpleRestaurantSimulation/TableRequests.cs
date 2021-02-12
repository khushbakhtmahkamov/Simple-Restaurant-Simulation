using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class TableRequests
    {
        private int number = 0;
        ItemInterface[,] menuItem = new ItemInterface[8, 3];
        public void Add(int customer, ItemInterface i)
        {
            if (i is Chicken)
            {
                menuItem[customer, 0] = i;
            }
            else if (i is Egg)
            {
                menuItem[customer, 1] = i;
            }
            else
            {
                menuItem[customer, 2] = i;
            }
            number++;
        }

        public ItemInterface[] this[int customer]
        {
            get
            {
                ItemInterface[] result = new ItemInterface[3];
                result[0] = menuItem[customer, 0];
                result[1] = menuItem[customer, 1];
                result[2] = menuItem[customer, 2];
                return result;
            }
        }

        public ItemInterface[] this[ItemInterface item]
        {
            get
            {
                ItemInterface[] result = new ItemInterface[0];
                int count = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (menuItem[i, j] != null && menuItem[i, j].GetType().Equals(item.GetType()))
                        {
                            Array.Resize(ref result, count + 1);
                            result[count] = menuItem[i, j];
                            count++;
                        }
                    }
                }
                return result;
            }
        }
    }
}
