using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class LapTopTest
    {
        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            Laptop test_laptop = new Laptop(true, true, 16, "Dell", 70);

            Assert.AreEqual(true, test_laptop.Power);
            Assert.AreEqual(true, test_laptop.Use);
            Assert.AreEqual(16, test_laptop.Memory);
            Assert.AreEqual(70, test_laptop.Weight);

        }

        [TestMethod]
        public void TestIsAThickBoy()
        {
            Laptop test_laptop = new Laptop(true, true, 16, "Dell", 70);
            Assert.IsTrue(test_laptop.IsAThickBoy());

            test_laptop.Weight = 60;
            Assert.IsTrue(test_laptop.IsAThickBoy());
        }
        
    }
}
