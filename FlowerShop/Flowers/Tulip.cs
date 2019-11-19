using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Flowers
{
    class Tulip : Flower
    {
        public static readonly string ClassName = "Tulip";
        public Tulip(string flowername, double price) : base(flowername, price) {}
    }
}
