using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingSample;

namespace UnitTestingSampleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            //arrange
            int expected = 42;
            int x = 38;
            int y = 4;
            Calculations calcs = new();

            //act
            int result = calcs.Addition(x, y);

            //assert
            Assert.IsTrue(expected == result);

        }
    }
}
