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

        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            NumEggOrder++;
        }

        public int GetQuantity()=> this.quantity;

        public int? GetQuality()
        {
            if (NumEggOrder % 2 == 0)
            {
                return null;
            }
            else
            {
                Random rand = new Random();
                return rand.Next(101);
            }
        }

        public void Crack()
        {
            if (GetQuality() < 25)
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
