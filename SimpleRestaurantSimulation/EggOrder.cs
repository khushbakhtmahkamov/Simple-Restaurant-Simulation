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
        private int? quality=-1;

        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            NumEggOrder++;
        }

        public int GetQuantity()=> this.quantity;
        
        public EggOrder Clone()
        {
            EggOrder clone = new EggOrder(this.quantity);
            clone.quality = this.quality;
            return clone;
        }

        public int? GetQuality()
        {
            //TODO: Everytime when you call this method it should return the same value per the instance of the EggOrder
            if (this.quality == -1)
            {
                if (NumEggOrder % 2 == 0)
                {
                    this.quality = null;
                }
                else
                {
                    Random rand = new Random();
                    this.quality = rand.Next(101);
                }
            }
            
            return this.quality;
        }

        public void Crack()
        {
            if (this.quality < 25)
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
