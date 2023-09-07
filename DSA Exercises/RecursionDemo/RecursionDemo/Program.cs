namespace RecursionDemo
{
    public class Program
    {
        private static void Main()
        {
            // FindMaxValueRecursion
            List<int> myList = new List<int> { 4, 64, 234, 300, 32 };
            int max = FindMaxValueRecursion(myList);
            Console.WriteLine(max);
        }

        private static int FindMaxValueRecursion(List<int> myList)
        {
            if (!myList.Any()) // If list is empty
            {
                return -1;
            }

            if (myList.Count == 1) // If list contains only 1 element
            {
                return myList[0];
            }

            int possibleMax = myList[0];

            List<int> restOfList = myList.Skip(1).ToList();

            int maxInRest = FindMaxValueRecursion(restOfList);

            return Math.Max(possibleMax, maxInRest);
        }
    }
}