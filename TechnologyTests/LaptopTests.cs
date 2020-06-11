using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {
       [TestMethod]
       public void TestInheritingBaseConstructor()
       {
            Laptop test_laptop = new Laptop(2, 4, true, 7.0);

            Assert.AreEqual(2, test_laptop.Ram);
            Assert.AreEqual(4, test_laptop.Storage);
            Assert.AreEqual(true, test_laptop.hasKeyboard);
            Assert.AreEqual(7, test_laptop.Weight);

            Assert.IsNotNull(test_laptop.Id);
       }

       [TestMethod]
       public void TestIsHeavy()
       {
            Laptop test_laptop = new Laptop(2, 4, true, 7.0);
            Assert.IsTrue(test_laptop.IsHeavy());

            test_laptop.Weight = 1.5;
            Assert.IsFalse(test_laptop.IsHeavy());
        }
    }
}
