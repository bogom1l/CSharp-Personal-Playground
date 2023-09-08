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
            // InsertionSort(array);
            // QuickSort(array);
            MergeSort(array);

            Console.WriteLine("\nAfter sorting:");
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
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
        } // O(n^2)

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

        private static void QuickSort(int[] array) // O(nlogn)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }

            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((0, array.Length - 1));

            while (stack.Count > 0)
            {
                (int low, int high) = stack.Pop();

                int pivotIndex = Partition(array, low, high);

                if (pivotIndex - 1 > low)
                {
                    stack.Push((low, pivotIndex - 1));
                }

                if (pivotIndex + 1 < high)
                {
                    stack.Push((pivotIndex + 1, high));
                }
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]); // Swap in .NET 7
                }
            }

            (array[i + 1], array[high]) = (array[high], array[i + 1]); // Swap in .NET 7
            return i + 1;
        }

        private static void MergeSort(int[] array) // O(nlogn)
        {
            int length = array.Length;
            if (length < 2)
                return;

            int mid = length / 2;
            int[] left = new int[mid];
            int[] right = new int[length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            for (int i = mid; i < length; i++)
            {
                right[i - mid] = array[i];
            }

            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int i = 0, j = 0, k = 0;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < leftLength)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
    }
}