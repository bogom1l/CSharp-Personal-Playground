namespace SortingAndSearchingAlgosDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] array = { 5, 9, 1, 24, 99, 13, 6, 8, 7, 10, 88, 63 };

            Console.WriteLine("Before sorting:");
            PrintArray(array);

            // SelectionSort(array);
            // BubbleSort(array);
            InsertionSort(array);

            Console.WriteLine("\nAfter sorting:");
            PrintArray(array);
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }

        private static void BubbleSort(int[] array) // O(n^2)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]); // Swap in .NET 7
                        isSwapped = true;
                    }
                }

                if (isSwapped == false)
                {
                    break;
                }
            }
        }

        private static void SelectionSort(int[] array) // O(n^2)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int smallestVal = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }

                (array[i], array[smallestVal]) = (array[smallestVal], array[i]); // Swap in .NET 7
            }
        }

        private static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}