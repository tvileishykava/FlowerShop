﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Interfaces
{
    interface IFlower
    {
        void DisplayFlower();
        Flower Clone();
    }
}
