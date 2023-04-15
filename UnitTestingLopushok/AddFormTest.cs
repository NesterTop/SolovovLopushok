using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolovovLopushok;

namespace UnitTestingLopushok
{
    [TestClass]
    public class AddFormTest
    {
        FormAdd fa = new FormAdd();

        [TestMethod]
        public void InsertData_ReturnedTrue()
        {
            Assert.IsTrue(fa.InsertData());
        }
    }
}
