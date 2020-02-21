using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuiltIn.SystemQuality.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExampleTest()
        {
            var expected = 2;
            var actual = 2;

            Assert.AreEqual (expected,actual);
        }
    }
}
