using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 654;
            int result = ConsoleApp1.Program.Example(a);
            Assert.AreEqual(result);
        }
    }
}
