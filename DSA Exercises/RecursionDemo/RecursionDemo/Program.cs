namespace RecursionDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> myList = new List<int> { 1, 4, 64, 234, 63, 34, 6, 31, 300, 96, 9, 32 };

            int max = FindMaxValueRecursion(myList);
            Console.WriteLine(max);
        }

        private static int FindMaxValueRecursion(List<int> myList)
        {
            if (myList.Count == 0)
                return -1;

            if (myList.Count == 1)
                return myList[0];

            int possibleMax1 = myList[0];

            var restOfList = myList.Skip(1).ToList();
            int maxInRest = FindMaxValueRecursion(restOfList);

            if (possibleMax1 > maxInRest)
            {
                return possibleMax1;
            }

            return maxInRest;
        }
    }
}