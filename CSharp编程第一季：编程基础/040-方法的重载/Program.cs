namespace _040_方法的重载
{
    class Program
    {
        static int MaxValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static double MaxValue(double[] arr)
        {
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 45, 12, 57, 34, 534, 542, 5323, 324 };
            int result1 = MaxValue(arr1);
            System.Console.WriteLine(result1);

            double[] arr2 = new double[] { 45, 12, 57, 34, 534, 542, 5323, 32453.23333 };
            double result2 = MaxValue(arr2);
            System.Console.WriteLine(result2);

            System.Console.ReadKey();
        }
    }
}
