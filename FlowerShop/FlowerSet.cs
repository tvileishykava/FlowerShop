using System;
using System.Collections.Generic;
using FlowerShop.Flowers;
using System.Runtime.Serialization;

namespace FlowerShop
{
    //interface
    public interface IFlowerSet
    {
        void DisplayTotalPrice();
        void DisplayTotalPrice(double pack);
        void AddFlowerToFlowerCollection(string className, int count, string flowername, double price, int flowerlength);
        void DeleteFlowerFromFlowerCollection(string flower, int count);
        void RemoveAllFlowersFromFlowerCollection();

        //works now for flower collection, names with indexes
        void DisplayFlowerNamesAndPriceAndQuantity();
        //void SortFlowersInFlowerSetBySmth(); 
        //Flower FindFlowerinFlowerSetByName(string flowername);
        
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
                double resultwithpack = result + pack;

            }
            try
            {
                double resultwithpack = result + pack;

                if (resultwithpack == pack)
                {
                    throw new Exception("No flowers to pack.");
                }
                Console.WriteLine("FlowerSet price with pack: " + resultwithpack);

            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            //Console.ReadLine();
        }
        public void AddFlowerToFlowerCollection(string className, int count, string flowername, double price, int flowerlength = 25)
        {
            Flower fl;

            for (int i = 0; i < count; i++)
            {
                switch (className)
                {
                    case "Astra":
                        fl = new Astra(flowername, price);
                        break;
                    case "Rose":
                        fl = new Rose(flowername, price, flowerlength);
                        break;
                    case "Tulip":
                        fl = new Tulip(flowername, price);
                        break;
                    case "Violet":
                        fl = new Violet(flowername, price);
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

    [Serializable]
    internal class Exeption : Exception
    {
        public Exeption()
        {
        }

        public Exeption(string message) : base(message)
        {
        }

        public Exeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Exeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
