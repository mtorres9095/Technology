using System;
using System.Collections.Generic;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
        public string ItemLocation { get; set; }
        public int RamMemory { get; set; }
        public int StorageCapacity { get; set; }

        public Program(string itemLocation, int ramMemory, int storageCapacity)
            {
            ItemLocation = itemLocation;
            RamMemory = ramMemory;
            StorageCapacity = storageCapacity;
            }
        }
            Program firstItem = new Program("Office #234", 24, 512);
        public readonly PrintItemLocation()
        {
        Program firstItem = new Program("Office #234", 24, 512);
        Console.WriteLine("The item you're looking for is located at:"+ ItemLocation);
        }

      
    }
}
