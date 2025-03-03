internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(average(arr));
    }
    public static int average(int[] arr)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            count++;
            sum += arr[i];
        }

        return sum / count;
    }
}