using System;

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
            System.Threading.Thread.Sleep(1000);
        }

        private void DiscardShell()
        {

        }
        
        public void Dispose()
        {           
            if (!this.disposed)
            {
                this.DiscardShell();
            }
            this.disposed = true;           
        }

        public override void Obtain()
        {
        }

        public override void Serve()
        {
        }

        public override void Prepare()
        {
            try
            {
                this.Obtain();
                this.Crack();
            }
            catch
            {
            }
            this.Cook();
        }
    }
}
