namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4};

            try
            {
                Console.WriteLine(arr[10]);
            }
            finally
            {
                Console.WriteLine("asd");
            }
        }
    }

    enum Color
    {
        Red,
        Green = 0,
        Blue = 0
    }
}