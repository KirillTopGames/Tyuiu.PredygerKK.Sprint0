using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PredygerKK.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Additions(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Mnozh(int a, int b)
        {
            return a * b;
        }

        public static int Dele(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0}, на ноль делить нельзя!", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
