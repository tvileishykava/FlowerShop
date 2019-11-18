using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Flowers;
using FlowerShop;

namespace FlowerShop1
{
    //interface
    public interface IFlowerSet
    {
        double GetTotalPrice();
        double GetTotalPrice(double pack);
        //void CreateCollection(List<Flower> MyFlowerset);
        void AddFlowerToFlowerCollection(Flower flower);
        //void DeleteFlowerFromFlowerCollection(Flower flower);
        //string[] GetFlowerNamesAndQuantity();
    }
    //constructor
    //public FlowerSet()
    //{
        //List<Flower> FlowerC= new <Flower>FlowerC(3);
    //}

    //class
    class FlowerSet : IFlowerSet
    {
        public List<Flower> FlowerCollection;

        //whithout pack
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
        public void AddFlowerToFlowerCollection(Flower flower)
        {
            //List<Flower> FlowerCollection = new List<Flower>();
            FlowerCollection.Add(flower);
        }
        //public List<Flower> CreateCollection(List<Flower> MyFlowerset)
        //{
        //return new List<Flower>();
        //}
        //}
    }
}
