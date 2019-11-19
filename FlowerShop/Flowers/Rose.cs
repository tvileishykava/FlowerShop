using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Flowers
{
    class Rose : Flower
    { 
        public Rose(string flowername, double price, int flowerlength=25) : base(flowername, price)
        {
            flowerlength_ = flowerlength;
        }
        //what for is it?
        public int flowerlength_;
        //method
        public override void DisplayFlower()
        {
            //base.DisplayFlower();
            Console.WriteLine(Flowername + " " + flowerlength_  + "sm : " + price + " BYN per item" );
        }
    }
}
