using System;
using System.Collections.Generic;
using FlowerShop.Flowers;
using System.Runtime.Serialization;
using System.Linq;


namespace FlowerShop
{
    //interface
    public interface IFlowerSet
    {
        void DisplayTotalPrice();
        void DisplayTotalPrice(double pack);
        void AddFlowerToFlowerCollection(string className, int count, string flowername, int flowerlength);
        void DeleteFlowerFromFlowerCollection(string flower, int count);
        void RemoveAllFlowersFromFlowerCollection();

        //works now for flower collection, names with indexes
        void DisplayFlowerNamesAndPriceAndQuantity();
        void SortFlowersInFlowerSetByPrice();
        void FindFlowerinFlowerSetByPrice(double minprice, double maxprice);
        
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
                result = result + i.Price;
            }

            CheckFlowersInCollection();
            Console.WriteLine("FlowerSet price: " + result);
        }
        //? with pack
        public void DisplayTotalPrice(double pack)
        {
            double result = 0;
            foreach (Flower i in this.FlowerCollection)
            {
                result = result + i.Price;
                //double resultwithpack = result + pack;

            }
            try
            {
                double resultwithpack = result + pack;

                if (resultwithpack == pack)
                {
                    throw new Exception("Notice! No flowers to pack.");
                }
                Console.WriteLine("FlowerSet price with pack: " + resultwithpack);

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        public void AddFlowerToFlowerCollection(string className, int count, string flowername, int flowerlength = 25)
        {
            Flower fl;

            for (int i = 0; i < count; i++)
            {
                switch (className)
                {
                    case "Astra":
                        fl = new Astra(flowername);
                        break;
                    case "Rose":
                        fl = new Rose(flowername, flowerlength);
                        break;
                    case "Tulip":
                        fl = new Tulip(flowername);
                        break;
                    case "Violet":
                        fl = new Violet(flowername);
                        break;
                    default:
                        throw new Exception("Flower type not found.");
                }

                this.FlowerCollection.Add(fl);
            }
        }
        public void DeleteFlowerFromFlowerCollection(string className, int count)
        {
            List<Flower> toRemove = new List<Flower>();

            foreach (Flower i in FlowerCollection)
            {
                if (i.GetType().Name == className && toRemove.Count < count)
                {
                    toRemove.Add(i);
                }
            }

            foreach (Flower i in toRemove)
            {
                FlowerCollection.Remove(i);
            }
        }
        public void RemoveAllFlowersFromFlowerCollection()
        {
            this.FlowerCollection.Clear();

        }
        public void DisplayFlowerNamesAndPriceAndQuantity()
        {
            foreach (Flower i in this.FlowerCollection)
            {
                string info = "";
                if (i.GetType() == typeof(Rose))
                {
                    info = "| " + i.Flowername + " | " + (i as Rose).flowerlength_ + " sm " + "| price: " + i.Price + " BYN" + " | ";
                }
                else
                {
                    info = "| " + i.Flowername + " | price: " + i.Price + " BYN" + " | ";
                }
                Console.WriteLine(info);
            }
            CheckFlowersInCollection();
        }
        public void SortFlowersInFlowerSetByPrice()
        {
            FlowerCollection.OrderBy(i => i.Price);
            CheckFlowersInCollection();
            foreach (Flower i in FlowerCollection)
            {
                Console.WriteLine("Sorted by price: " + i.Flowername + " price: " + i.Price);
            }
        }
        public void FindFlowerinFlowerSetByPrice(double minprice, double maxprice)
        {
            try
            {
                CheckFlowersInCollection();
                List<Flower> ByPrice = FlowerCollection.FindAll(i => minprice <= i.Price && i.Price <= maxprice);

                if (ByPrice.Count == 0)
                {
                    throw new Exception("Notice! No flowers match this parameters!");
                }

                foreach (Flower i in ByPrice)
                {
                    Console.WriteLine("Flowers in price range: " + minprice + " - " + maxprice + " : " + i.Flowername + " " + i.Price + "BYN");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        public bool CheckFlowersInCollection()
        {
            try
            {
                if (FlowerCollection.Count == 0)
                {
                    throw new Exception("Notice! No Flowers added to FlowerSet!");
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return false;
            }
        }
    }
}
