using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Flowers;
using FlowerShop.Menu;



namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //new flower
            Astra Astra1 = new Astra("Astra", 3.00);
            Astra1.DisplayFlower();


            Rose Rose1 = new Rose("Rose", 3.00, 30);
            Rose Rose2 = new Rose("Rose", 3.00);
            Rose1.DisplayFlower();


            FlowerSet FlowerSet1 = new FlowerSet();
            FlowerSet1.AddFlowerToFlowerCollection(Astra1);
            FlowerSet1.AddFlowerToFlowerCollection(Rose1);

            FlowerSet1.DisplayFlowerNamesAndPriceAndQuantity();
            FlowerSet1.DeleteFlowerFromFlowerCollection(Rose1);
            FlowerSet1.DisplayTotalPrice();
            Console.WriteLine("___________");
            FlowerSet1.DisplayFlowerNamesAndPriceAndQuantity();
            FlowerSet1.DisplayTotalPrice();
            FlowerSet1.DisplayTotalPrice(20);
            ShowMainMenu();




            //do not delete, useful line
            Console.ReadLine();
             
        }
    }
}
