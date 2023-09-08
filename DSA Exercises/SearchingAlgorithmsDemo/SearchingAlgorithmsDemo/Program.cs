namespace SearchingAlgorithmsDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 5, 9, 13, 8, 24, 99 };
            PrintArray(array);

            // int result = LinearSearch(array, 8);
            int result = BinarySearch(array, 13);

            Console.WriteLine(result == -1 ? $"Element not found -> {result}" : $"Element found at index -> {result}");
        }

        private static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }

        private static int LinearSearch(int[] array, int searchedElement)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedElement)
                {
                    return i;
                }
            }

            return -1;
        }

        // neshto ne e nared mai tuk, pri poveche elementi w masiwa? notsure.
        public static int BinarySearch(int[] array, int searchedElement)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == searchedElement)
                {
                    return middle;
                }

                if (array[middle] < searchedElement)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}