using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class EggOrder:Order
    {
       // private int quantity;
        public static int NumEggOrder = 0;
        private int? quality=-1;

        public EggOrder(int quantity):base(quantity)
        {
            //this.quantity = quantity;
            NumEggOrder++;
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

        //public int GetQuantity()=> this.quantity;
        
        public EggOrder Clone()
        {
            EggOrder clone = new EggOrder(this.quantity);
            clone.quality = this.quality;
            return clone;
        }

        public int? GetQuality()=> this.quality;
     

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
