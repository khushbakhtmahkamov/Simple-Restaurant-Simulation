using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class EggOrder
    {
        private int quantity;
        public static int NumEggOrder = 0;
        private int? quality;

        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            NumEggOrder++;
            GetQuality();
        }

        public int GetQuantity()=> this.quantity;

        private int? GetQuality()
        {
            if (NumEggOrder % 2 == 0)
            {
                quality= null;
            }
            else
            {
                Random rand = new Random();
                quality= rand.Next(101);
            }
            return quality;
        }

        public void Crack()
        {
            if (quality < 25)
            {
                throw new ArgumentOutOfRangeException("Bad quality");
            }
        }

        public void DiscardShell()
        {

        }

        public void Cook()
        {

        }
    }
}
