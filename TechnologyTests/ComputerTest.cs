using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void TestInheritsId()
        {
            Computer test_computer = new Computer(true, true, 16, "Dell");
            Assert.AreEqual(1, test_computer.Id);

            Computer test_computer2 = new Computer(true, true, 32, "Well");
            Assert.AreEqual(2, test_computer2.Id);
        }

        [TestMethod]
        public void TestSleep()
        {
            Computer test_computer = new Computer(true, false, 16, "Well");

            test_computer.Sleep();
            Assert.IsTrue(test_computer.Sleep());
        }
    }
}
