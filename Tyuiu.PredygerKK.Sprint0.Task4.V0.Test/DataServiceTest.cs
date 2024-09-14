using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PredygerKK.Sprint0.Task4.V0.Lib;

namespace Tyuiu.PredygerKK.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Additions(5, 5));
        }

        [TestMethod]
        public void CheckedMinusValid()
        {
            Assert.AreEqual(0, DataService.Minus(5, 5));
        }

        [TestMethod]
        public void CheckedMnozhValid()
        {
            Assert.AreEqual(25, DataService.Mnozh(5, 5));
        }

        [TestMethod]
        public void CheckeddeleValid()
        {
            Assert.AreEqual(1, DataService.Dele(5, 5));
        }
    }
        
}
