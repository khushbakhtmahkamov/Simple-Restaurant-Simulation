namespace SimpleRestaurantSimulation
{
    abstract class CookedFood : IMenuItem
    {
        public int quantity;
        public CookedFood(int quantity) : base()
        {
            this.quantity = quantity;
        }

        public int GetQuantity() => this.quantity;

        public abstract void Obtain();

        public abstract void Serve();

        public abstract void Cook();

        public abstract void Prepare();
    }
}
