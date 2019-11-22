using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Flowers
{
    class Violet : Flower
    {
        public static readonly string ClassName = "Violet";
        public Violet(string flowername, double price=4) : base(flowername, price) {}
    }
}
