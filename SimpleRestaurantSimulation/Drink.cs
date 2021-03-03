namespace SimpleRestaurantSimulation
{
    abstract class Drink : IMenuItem
    {
        public abstract void Obtain();

        public abstract  void Serve();
    }
}
