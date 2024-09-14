using System;
using Tyuiu.PredygerKK.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PredygerKK.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = "+DataService.Additions(1, 5));
            Console.WriteLine("A - B = " + DataService.Minus(1000, 7));
            Console.WriteLine("A * B = " + DataService.Mnozh(625000, 2));
            Console.WriteLine("A / B = " + DataService.Dele(5, 0));
        }
    }
}
