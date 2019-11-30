using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Flowers
{
    class Tulip : Flower
    {
        public Tulip(string flowername) : base(flowername)
        {
            price = 3;
        }
    }
}
