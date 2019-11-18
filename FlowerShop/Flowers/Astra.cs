using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Flowers
{

    class Astra : Flower
    {
        public Astra(string flowername, double price, int quantity) : base(flowername, price, quantity) { maxCount = 10; }
        
    }
}
