using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolovovLopushok;

namespace UnitTestingLopushok
{
    [TestClass]
    public class DataBaseTest
    {
        [TestMethod]
        public void DataBaseConnectionOpen_ReturnedTrue()
        {
            using (DataBase db = new DataBase())
            {
                Assert.IsTrue(db.IsConnected);
            }
        }

        [TestMethod]
        public void DataBaseConnectionClose_ReturnedTrue()
        {
            using (DataBase db = new DataBase())
            {
                db.Dispose();
                Assert.IsFalse(db.IsConnected);
            }
        }

        [TestMethod]
        public void DataBaseSelectPageData_RetrnedTrue()
        {
            Assert.IsTrue(new MainForm().SelectPageData());
        }

        public void DataBaseUpdateData_ReturnedTrue()
        {
            Assert.IsTrue(new MainForm().UpdateData());
        }
    }
}
