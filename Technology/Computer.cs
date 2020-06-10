using System;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public int Ram { get; set; }
        public int Storage { get; set; }
        public readonly bool hasKeyboard;

        public Computer(int ram, int storage, bool hasKeyboard)
        {
            Ram = ram;
            Storage = storage;
            this.hasKeyboard = hasKeyboard;
        }

        public void IncreaseRam(int size)
        {
            Ram += size;
        }

        public void IncreaseStorage(int size)
        {
            Storage += size;
        }
    }
}

        //public string ItemLocation { get; set; }
        //public string Brand { get; set; }
        //public int StorageCapacity { get; set; }

        //public Program(string itemLocation, int ramMemory, int storageCapacity)
        //{
        //    ItemLocation = itemLocation;
        //    RamMemory = ramMemory;
        //    StorageCapacity = storageCapacity;
        //}
   
