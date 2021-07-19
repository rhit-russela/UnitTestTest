using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void testWillPass()
        {
            Assert.AreEqual(100, 100, 0.001, "100 = 100");
        }

        [TestMethod]
        public void testWillFail()
        {
         
            Assert.AreEqual(100, 50, 0.001, "50 = 100");
        }
    }
}
