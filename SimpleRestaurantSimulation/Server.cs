using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRestaurantSimulation
{
    class Server
    {
        Cook cook = new Cook();
        public Server()
        {

        }

        public void Receive(int numberChicken,int numberEgg,typeDrinkList typeDrink)
        {

        }

        public void Send()
        {
            cook.Submit(1);
        }

        public void Serve()
        {

        }
    }
}
