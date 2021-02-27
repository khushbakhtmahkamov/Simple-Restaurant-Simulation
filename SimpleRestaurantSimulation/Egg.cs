using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Egg : CookedFood, IDisposable
    {
        private int? quality = -1;
        private bool disposed = false;
        public Egg(int quantity) : base(quantity)
        {
            Random rand = new Random();
            this.quality = rand.Next(101);
        }


        public void Crack()
        {
            if (this.quality < 25)
            {
                throw new ArgumentOutOfRangeException("Bad quality");
            }
        }

        public override void Cook()
        {

        }

        public void DiscardShell()
        {

        }

        //TODO: When this Dispose method will be run?
        public void Dispose()
        {
            if (!this.disposed)
            {
                this.DiscardShell();
            }
            this.disposed = true;
            GC.SuppressFinalize(this);
        }

        ~Egg()
        {
            this.Dispose();
        }
    }
}
