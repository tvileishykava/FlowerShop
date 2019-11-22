using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*        
        DisplayAvailableFlowers

    void AddFlowerToFlowerCollection(string className, int count, string flowername, double price, int flowerlength);

        void DisplayFlowerNamesAndPriceAndQuantity();
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
            Console.WriteLine("\tTo see list of flowers - click on button 1" +
               "\n\tTo add flower/flowers to Flowerset - click on button 2" +
                ""
                );
            string sign = Console.ReadLine();
            switch (sign)
            {
                 case "1":
                    DisplayAvailableFlowers();
                 break;
            }
            switch (sign)
            {
                case "2":
                    flSet.DisplayFlowerNamesAndPriceAndQuantity();
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
