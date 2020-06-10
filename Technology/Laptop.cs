using System;

namespace Technology
{
    class Laptop : Computer
    {
        public double ScreenSize { get; set; } 

        public Laptop(int ram, int storage, bool hasKeyboard, double screenSize) : base(ram, storage, hasKeyboard)

        {
            ScreenSize = screenSize;

        }
        public string LargeScreen()
        {
            if (ScreenSize > 15)
            {
                return "Large screen laptop";
            }
            else
            {
                return "Screen is within specifications";
            }

        }
        }
    }

