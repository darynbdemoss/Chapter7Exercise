using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTest
    {
        [TestMethod]
        public void TestInheritingBaseConstructor()
        {
            SmartPhone test_smartphone = new SmartPhone(true, true, 16, "Dell", 70);

            Assert.AreEqual(true, test_smartphone.Power);
            Assert.AreEqual(true, test_smartphone.Use);
            Assert.AreEqual(16, test_smartphone.Memory);
            Assert.AreEqual(70, test_smartphone.NumberOfSongs);

        }

        [TestMethod]
        public void IllegalDownloadTest()
        {
            SmartPhone test_smartphone = new SmartPhone(true, true, 16, "Dell", 800);


            test_smartphone.IllegalDownload();
            Assert.AreEqual(801, test_smartphone.NumberOfSongs);
        }

    }
}
