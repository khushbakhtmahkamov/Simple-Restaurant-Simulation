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
            //TODO: Ин метод public аст ва аз берун хар вактеки чег мезанед, хархел кимматро бармагардонад. Аммо бояд барои як инстанси EggOrder доим якхел кимматро баргардонад, наинки хархел. Барои хамин бехтар мешуд хамин коди генерацияи сифатро ба конструктор нависед.
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
