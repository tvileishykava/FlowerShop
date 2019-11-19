using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Menu
{
    class Menu
    {
        public void ShowMainMenu()
        {
        Console.WriteLine("To add flower - click on 1");
        int sign = Convert.ToChar(Console.ReadLine());
        switch (sign)
        {
             case '1':
             Console.WriteLine("addition");
             break;
            }
        }
}
}