using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        [TestMethod]
        public void TestIneritingBaseConstructor()
        {
            SmartPhone test_smartphone = new SmartPhone(2, 3, true, 800);

            Assert.AreEqual(2, test_smartphone.Ram);
            Assert.AreEqual(3, test_smartphone.Storage);
            Assert.AreEqual(true, test_smartphone.hasKeyboard);
            Assert.AreEqual(800, test_smartphone.NumberOfSelfies);

            Assert.IsNotNull(test_smartphone.Id);
        }

        [TestMethod]
        public void TestTakingSelfies()
        {
            SmartPhone test_smartphone = new SmartPhone(2, 3, true, 800);

            test_smartphone.TakeSelfie();

            Assert.AreEqual(801, test_smartphone.NumberOfSelfies);
        }
    }
}
