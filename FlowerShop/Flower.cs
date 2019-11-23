using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
    {
    //interface
    public interface IFlower
    {
        void DisplayFlower();
     
    }
    //class
    public abstract class Flower : IFlower
    {
        private static int flowerID = 0;
        protected string flowername;
        protected double price;
        public double Price
        {
            get { return price; }
        }
        public string Flowername
        {
            get { return flowername; }
            set { flowername = value + flowerID; }
        }
        //constructor
        public Flower(string flowername)
        {
            flowerID++;
            this.Flowername = flowername;
        }
        
        //methods
        public virtual void DisplayFlower()
        {
            Console.WriteLine(Flowername + ": " + price + " BYN per item");
        }
        //other methods

    }
}
