using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PredygerKK.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static Object AddArray(int[] nums)
        {
            var total = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            return total;
        }

        public static Object MinusArray(int[] nums)
        {
            var total = 0;
            int index = 0;

            while (index < nums.Length)
            {
                total -= nums[index];
                index++;
            }
            return total;
        }
        public static Object MnozhArray(int[] nums)
        {
            var total = 1;
            int index = 0;
            do
            {
                total *= nums[index];
                index++;
            }
            while (index < nums.Length);

            return total;
        }
    }
}
