using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PredygerKK.Sprint0.Task6.V0.Lib;

namespace Tyuiu.PredygerKK.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChechAdditionArrayValid()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AddArray(nums);
            Assert.AreEqual(15, res);
        }

        public void ChechMinusArrayValid()
        {
             var nums = new int[] { 1, 2, 3, 4, 5 };
             var res = DataService.MinusArray(nums);
             Assert.AreEqual(-15, res);
        }
        public void ChechMnozhArrayValid()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MnozhArray(nums);
            Assert.AreEqual(120, res);
        } 
    }
}
