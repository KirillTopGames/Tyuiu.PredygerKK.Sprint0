using Tyuiu.PredygerKK.Sprint0.Task7.V0.Lib;
namespace Tyuiu.PredygerKK.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysVoid()
        {
            int[] nums1 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] nums2 = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            int[] nums3 = {3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };

            int[] res = DataService.AddArray(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}