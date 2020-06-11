using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public double Weight { get; set; }

        public Laptop(int ram, int storage, bool hasKeyboard, double weight) : base(ram, storage, hasKeyboard)
        {
            Weight = weight;
        }

        public bool IsHeavy()
        {
            if(Weight > 5.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
