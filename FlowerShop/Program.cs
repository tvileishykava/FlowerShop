﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Flowers;
using FlowerShop.MenuNamespace;



namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {


            //Rose Rose1 = new Rose("Rose", 3.00, 30);
            //Rose Rose2 = new Rose("Rose", 3.00);
            //Rose1.DisplayFlower();

            //FlowerSet FlowerSet1 = new FlowerSet();
            //FlowerSet1.AddFlowerToFlowerCollection("Astra", 3, "Astra", 3.00);
            //FlowerSet1.AddFlowerToFlowerCollection("Rose", 2, "Rose", 5.00, 30);
            //FlowerSet1.SortFlowersInFlowerSetBySmth();

            //Menu menu = new Menu();
            //menu.DisplayAvailableFlowers();

            /*FlowerSet1.DeleteFlowerFromFlowerCollection("Astra", 1);


            FlowerSet1.DisplayTotalPrice();


            FlowerSet1.DisplayTotalPrice(20);
            FlowerSet1.FindFlowerinFlowerSetByPrice(0, 3.5);


            Console.WriteLine("___________");
            FlowerSet1.RemoveAllFlowersFromFlowerCollection();
            FlowerSet1.DisplayFlowerNamesAndPriceAndQuantity();
            FlowerSet1.DisplayTotalPrice();
            FlowerSet1.DisplayTotalPrice(20);*/
            Menu menu = new Menu();
            menu.ShowMainMenu();
            //flSet.DisplayFlowerNamesAndPriceAndQuantity();




            //do not delete, useful line
            Console.ReadLine();
             
        }
    }
}
