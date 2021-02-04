using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class EggOrder : Order
    {
        
        private int? quality = -1;

        public EggOrder(int quantity) : base(quantity)
        {

            Random rand = new Random();
            this.quality = rand.Next(101);

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

        public override void Cook()
        {

        }

    }
}
