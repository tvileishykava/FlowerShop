using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.MenuNamespace
{
    public interface IMenu
    {
        void ShowMainMenu();
    }
    class Menu
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
             break;
            }
        }
}
}