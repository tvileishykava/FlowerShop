using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Flowers;

namespace FlowerShop
{
    //interface
    public interface IFlowerSet
    {
        double GetTotalPrice();
        double GetTotalPrice(double pack);
        void AddFlowerToFlowerCollection(Flower flower);
        void DeleteFlowerFromFlowerCollection(Flower flower);
        string[] GetFlowerNamesAndQuantity();
    }
    //class
    class FlowerSet : IFlowerSet
    {
        public List<Flower> FlowerCollection;

        public double GetTotalPrice()
        {
            double result = 0;
            foreach (Flower i in FlowerCollection)
            {
                result = result + i.price;
            }
            return result;
        }
        //? with pack
        public double GetTotalPrice(double pack)
        {
            double result = 0;
            foreach (Flower i in FlowerCollection)
            {
                result = result + i.price;
            }
            return result + pack;
        }
    }
}
