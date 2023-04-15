using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SolovovLopushok;

namespace UnitTestingLopushok
{
    [TestClass]
    public class MainFormTest
    {
        MainForm mf = new MainForm();
        
        [TestMethod]
        public void ShowUpdateForm_ReturnedTrue()
        {
            Assert.IsTrue(mf.ShowUpdateForm());
        }

        [TestMethod]
        public void ShowAddForm_ReturnedTrue()
        {
            Assert.IsTrue(mf.ShowAddForm());
        }

        [TestMethod]
        public void DeleteData_ReturnedTrue()
        {
            Assert.IsTrue(mf.DeleteData());
        }

        [TestMethod]
        public void BackPage_ReturnedTrue()
        {
            Assert.IsTrue(mf.BackPage());
        }

        [TestMethod]
        public void GoPage_ReturnedTrue()
        {
            Assert.IsTrue(mf.GoPage());
        }
    }
}
