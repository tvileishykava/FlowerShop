using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FlowerShop.MenuNamespace
{
    public interface IMenu
    {
        void ShowMainMenu();
        void DisplayAvailableFlowers();
    }
    class Menu : IMenu
    {
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