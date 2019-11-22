using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*        

    void AddFlowerToFlowerCollection(string className, int count, string flowername, double price, int flowerlength);
     void FindFlowerinFlowerSetByPrice(double minprice, double maxprice);
                        void SortFlowersInFlowerSetByPrice();



      void DeleteFlowerFromFlowerCollection(string flower, int count);
        void RemoveAllFlowersFromFlowerCollection();

    void DisplayTotalPrice();
        void DisplayTotalPrice(double pack);

              */

namespace FlowerShop.MenuNamespace
{
    public interface IMenu
    {
        void ShowMainMenu();
        void DisplayAvailableFlowers();

    }
    class Menu : IMenu
    {
        private FlowerSet flSet;
        //constructor
        public Menu()
        {
            this.flSet = new FlowerSet();
        }

        public void ShowMainMenu()
        {
            Console.WriteLine(
               "\n\t FlowerSet Creation Main Menu" +
               "\n\n\t To see list of available flowers - click on button 1" +
               "\n\t To add flower/flowers to Flowerset - click on button 2" +
               "\n\t To review your FlowerSet - click on button 3" +
               "\n\t To find flower in FlowerSet by price - click on button 4" +
               "\n\t To sort your FlowerSet by price - click on button 5" +
               "\n\t To delete flower/flowers from FlowerSet - click on button 6" +
               "\n\t To remove All flowers from FlowerSet - click on button 7" +
               "\n\t To review total price of the FlowerSet - click on button 8" +
               "\n\t To add pack and review total price of the FlowerSet - click on button 9" +
               ""
                );
            string sign = Console.ReadLine();
            switch (sign)
            {
                 case "1":
                    DisplayAvailableFlowers();
                 break;
         
                case "2":
                    Console.WriteLine("Enter flower name:");
                    string fn = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("How many flowers to add:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (fn == "Rose")
                    {
                        Console.WriteLine("Rose of what size do you want to add (10, 20, 30, 40, 50 are available):");
                        int l = Convert.ToInt32(Console.ReadLine());
                        flSet.AddFlowerToFlowerCollection(fn, c, fn, l);
                    }
                    Console.WriteLine("\tReporting:  " + c + " flower/flowers added");
                    break;

                case "3":
                    flSet.DisplayFlowerNamesAndPriceAndQuantity();
                    break;

                case "4":
                    flSet.FindFlowerinFlowerSetByPrice();
                    break;
            }
        }
        public void DisplayAvailableFlowers()
        {
            Console.WriteLine("\tToday are available\n");
            String[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "FlowerShop.Flowers");
            for (int i = 0; i < typelist.Length; i++)
            {
                Console.WriteLine("\t" + typelist[i]);
            }
        }
        private String[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .Select(t => { return t.Name; })
                      .ToArray();
        }
    }
}
