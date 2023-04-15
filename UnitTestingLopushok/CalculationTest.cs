using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestingLopushok
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void GetQuantityForProduct_ReturnedTrue()
        {
            Calculation calculation = new Calculation();
            Assert.IsTrue(calculation.CheckGetQuantity(1,2,3,5,2));
        }
    }
}
