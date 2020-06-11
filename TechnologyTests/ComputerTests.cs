using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void TestInheritsId()
        {
            Computer test_computer = new Computer(4, 16, true);
            Assert.AreEqual(1, test_computer.Id);

            Computer test_computer2 = new Computer(8, 32, true);
            Assert.AreEqual(2, test_computer2.Id);
        }

        [TestMethod]
        public void TestIncreasingRam()
        {
            Computer test_computer = new Computer(4, 16, true);
            Assert.AreEqual(4, test_computer.Ram);

            test_computer.IncreaseRam(4);
            Assert.AreEqual(8, test_computer.Ram);
        }

        [TestMethod]
        public void TestIncreasingStorage()
        {
            Computer test_computer = new Computer(4, 16, true);
            Assert.AreEqual(16, test_computer.Storage);

            test_computer.IncreaseStorage(16);
            Assert.AreEqual(32, test_computer.Storage);
        }
    }
}
