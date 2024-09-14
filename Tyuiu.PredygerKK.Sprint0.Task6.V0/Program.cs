using Tyuiu.PredygerKK.Sprint0.Task6.V0.Lib;
namespace Tyuiu.PredygerKK.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NumsArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AddArray(NumsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.MinusArray(NumsArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MnozhArray(NumsArray));
        }
    }
}
