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
        void DisplayTotalPrice();
        //rework
        void DisplayTotalPrice(double pack);
        //rework
        void AddFlowerToFlowerCollection(Flower flower);
        void DeleteFlowerFromFlowerCollection(Flower flower);
        void DisplayFlowerNamesAndPriceAndQuantity();
        //void Sort(); - 
        //Flower FindByName(string name);
    }
        //class
    class FlowerSet : IFlowerSet
    {
        public List<Flower> FlowerCollection;
        
        //constructor
        public FlowerSet()
        {
            this.FlowerCollection = new List<Flower>();
        }

        //whithout pack
        public void DisplayTotalPrice()
        {
            double result = 0;
            foreach (Flower i in this.FlowerCollection)
            {
                result = result + i.price;
            }
            Console.WriteLine("FlowerSet price: " + result);
        }
        //? with pack
        public void DisplayTotalPrice(double pack)
        {
            double result = 0;
            foreach (Flower i in this.FlowerCollection)
            {
                result = result + i.price;
            }
            double resultwithpack = result + pack;
            Console.WriteLine("FlowerSet price with pack: " + resultwithpack);
        }
        public void AddFlowerToFlowerCollection(Flower flower)
        {
            this.FlowerCollection.Add(flower);
        }
        public void DeleteFlowerFromFlowerCollection(Flower flower)
        {
            this.FlowerCollection.Remove(flower);
        }

        public void DisplayFlowerNamesAndPriceAndQuantity()
        {
            foreach (Flower i in this.FlowerCollection)
            {
                string info = "";
                if (i.GetType() == typeof(Rose))
                {
                    info = "| " + i.Flowername + " | " + (i as Rose).flowerlength_ + " sm " + "| price: " + i.price + " BYN" + " | " ;
                }
                else
                {
                    info = "| " + i.Flowername + " | price: " + i.price + " BYN" + " | ";
                } 
                Console.WriteLine(info);
            }
            
        }


    }
}
