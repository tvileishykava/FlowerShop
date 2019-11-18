using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Flowers;



namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //new flower
            Astra Astra1 = new Astra("Astra", 3.00, 10);
            Astra1.DisplayFlower();


            Rose Rose1 = new Rose("Rose", 3.00, 10, 30);
            Rose1.DisplayFlower();



            List<string> FlowerColl= new List<string>();
  //          Astra1.AddFlowerToFlowerCollection();
            //FlowerCollection.Add(Astra1);
            //FlowerCollection.Add(Rose1);
            //foreach (Flower i in ss)
            //{
            //Console.WriteLine(i);

            //}
            //do not delete, useful line
            Console.ReadLine();
             
        }
    }
}
