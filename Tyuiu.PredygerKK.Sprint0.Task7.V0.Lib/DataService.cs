namespace Tyuiu.PredygerKK.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AddArray(int[] NumOne, int[] NumTwo)
        {
            int[] ResArray = new int[15];
            for (var i = 0; i < ResArray.Length; i++)
            {
                ResArray[i] = NumOne[i] + NumTwo[i];
            }
            return ResArray;
        }
    }
}
