﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Flowers
{
    class Violet : Flower
    {
        public Violet(string flowername, double price, int quantity) : base(flowername, price, quantity) { maxCount = 10; }
    }
}
