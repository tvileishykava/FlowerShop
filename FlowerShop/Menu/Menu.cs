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
            Console.WriteLine("To add flower - click on 1" +
                "\n2" +
                ""
                );
            string sign = Console.ReadLine();
            switch (sign)
            {
                 case "1":
                 Console.WriteLine("addition");
                 //FlowerSet1.AddFlowerToFlowerCollection("Rose", 3, "Rose", 3.00, 30);
                 break;
            }
        }
        public void DisplayAvailableFlowers()
        {
            String[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "FlowerShop.Flowers");
            for (int i = 0; i < typelist.Length; i++)
            {
                Console.WriteLine(typelist[i]);
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
