using System;
using System.Collections.Generic;
using FlowerShop.Flowers;
using System.Runtime.Serialization;
using System.Linq;
using FlowerShop.Interfaces;


namespace FlowerShop
{
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
        /* with pack
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
        }*/
        public void AddFlowerToFlowerCollection(Flower flower, int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.FlowerCollection.Add(flower.Clone());
            }
        }
        public void DeleteFlowerFromFlowerCollection(string className, int count, int flowerlength)
        {
            CheckFlowersInCollection();
            List<Flower> toRemove = new List<Flower>();
            foreach (Flower i in FlowerCollection)
            {
                bool isCountLowerThanAllowed = toRemove.Count < count;
                bool isRose = i.GetType().Name == typeof(Rose).Name;

                if (isRose && (i as Rose).flowerlength_ == flowerlength && isCountLowerThanAllowed)
                {
                    toRemove.Add(i);
                }
            }

            foreach (Flower i in toRemove)
            {
                FlowerCollection.Remove(i);
            }
            Console.WriteLine("\tReporting:  " + toRemove.Count + " flower/flowers deleted");
        }
        public void DeleteFlowerFromFlowerCollection(string className, int count)
        {
            CheckFlowersInCollection();
            List<Flower> toRemove = new List<Flower>();
            foreach (Flower i in FlowerCollection)
            {
                bool isCorrectName = i.GetType().Name == className;
                bool isCountLowerThanAllowed = toRemove.Count < count;

                if (isCorrectName && isCountLowerThanAllowed)
                {
                    toRemove.Add(i);
                }
            }

            foreach (Flower i in toRemove)
            {
                FlowerCollection.Remove(i);
            }
            Console.WriteLine("\tReporting:  " + toRemove.Count + " flower/flowers deleted");
        }
        public void RemoveAllFlowersFromFlowerCollection()
        {
            if (CheckFlowersInCollection())
            {
                this.FlowerCollection.Clear();
                Console.WriteLine("All flowers removed from the Flower Set");
            }
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
