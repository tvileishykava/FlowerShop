using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Interfaces
{
    interface IFlowerSet
    {
        void DisplayTotalPrice();
        //void DisplayTotalPrice(double pack);
        void AddFlowerToFlowerCollection(string className, int count, string flowername, int flowerlength);
        void AddFlowerToFlowerCollection(string className, int count, string flowername);
        void DeleteFlowerFromFlowerCollection(string flower, int count, int flowerlength);
        void DeleteFlowerFromFlowerCollection(string flower, int count);
        void RemoveAllFlowersFromFlowerCollection();

        //works now for flower collection, names with indexes
        void DisplayFlowerNamesAndPriceAndQuantity();
        void SortFlowersInFlowerSetByPrice();
        void FindFlowerinFlowerSetByPrice(double minprice, double maxprice);
    }
}
