﻿using System;

namespace SimpleRestaurantSimulation
{
    class Chicken : CookedFood
    {
        public Chicken(int quantity) : base(quantity)
        {

        }
        
        public void CutUp()
        {

        }

        public override void Cook()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public override void Obtain()
        {
        }

        public override void Serve()
        {
        }

        public override void Prepare()
        {
            this.Obtain();
            this.CutUp();
            this.Cook();
        }
    }
}
