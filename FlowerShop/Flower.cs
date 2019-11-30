using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Interfaces;

namespace FlowerShop
    {
    //class
    public abstract class Flower : IFlower
    {
        protected string flowername;
        protected double price;
        public double Price
        {
            get { return price; }
        }
        public string Flowername
        {
            get { return flowername; }
            set { flowername = value; }
        }
        //constructor
        public Flower(string flowername)
        {
            this.Flowername = flowername;
        }

        //methods
        public virtual void DisplayFlower()
        {
            Console.WriteLine(Flowername + ": " + price + " BYN per item");
        }

        public Flower Clone()
        {
            return (Flower)this.MemberwiseClone();
        }
    }
}
