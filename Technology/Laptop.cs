using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Technology
{
    class Laptop
    {
        public int ScreenSize { get; set; } 

        public Laptop(int screenSize)
        {
            ScreenSize = screenSize;

        }
        public static int ChangeLaptop(int screenSizeToUpdate)
        {
            if (screenSizeToUpdate == screenSize)
            {
                Console.WriteLine("The laptop located in" + ItemLocation + "needs an update"); 
            }
        }
    }
}
