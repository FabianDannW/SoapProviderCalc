using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServicen;


namespace Testerunit
{
    [TestClass]
    public class UnitTest1
    {
        Service1 unitTest = new Service1();

        [TestMethod]
        public void AddResult()
        {

            unitTest.Add(2, 3);
            Assert.AreEqual(5, unitTest.Result);
        }
        [TestMethod]
        public void SubstractResult()
        {

            unitTest.Subtract(2, 3);
            Assert.AreEqual(-1, unitTest.Result);
        }
        [TestMethod]
        public void MultiplyResult()
        {

            unitTest.Multiply(2, 3);
            Assert.AreEqual(6, unitTest.Result);
        }
        [TestMethod]
        public void DivideResult()
        {

            unitTest.Divide(10, 2);
            Assert.AreEqual(5, unitTest.Result);
        }
        [TestMethod]
        public void UnderligResult()
        {

            unitTest.Underligt(10, 2);
            Assert.AreEqual(500, unitTest.Result);
        }
    }
}
