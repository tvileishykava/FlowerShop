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
        protected string flowername;
        public double price;
        public int quantity;
        public string Flowername
        {
            get { return flowername; }
            set { flowername = value; }
        }
        //constructor
        public Flower(string flowername, double price, int quantity)
        {
            this.flowername = flowername; this.price = price; this.quantity = quantity;
        }
        
        //methods
        public virtual void DisplayFlower()
        {
            Console.WriteLine(Flowername + ": " + price + " BYN per item");
        }
        //other methods

    }
}
