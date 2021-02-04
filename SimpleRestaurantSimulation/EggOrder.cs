using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class EggOrder : Order
    {
        // private int quantity;
        public static int NumEggOrder = 0;//TODO: remove
        private int? quality = -1;

        public EggOrder(int quantity) : base(quantity)
        {

            Random rand = new Random();
            this.quality = rand.Next(101);

        }

        //public int GetQuantity()=> this.quantity;
        //TODO: We don't need this method anymore. You can remove this.
        public EggOrder Clone()
        {
            EggOrder clone = new EggOrder(this.quantity);
            clone.quality = this.quality;
            return clone;
        }

        public int? GetQuality() => this.quality;


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

    }
}
