namespace DSA_Intro
{
    public class Program //TODO: Ctrl + Alt + '
    {
        private static void Main(string[] args)
        {
            SortedSet<int> mySortedSet = new();

            Random random = new();

            for (var i = 0; i < 10; i++)
            {
                mySortedSet.Add(random.Next(1, 99));
            }

            foreach (var i in mySortedSet)
            {
                Console.Write(i + " ");
            }
        }
    }
}