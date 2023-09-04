namespace LeetCodeExc
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // 58. Length of Last Word
            // Console.WriteLine(LengthOfLastWord("Hello World"));
            // Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
            // Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));

            // 121. Best Time to Buy and Sell Stock
            Console.WriteLine(MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));
            Console.WriteLine(MaxProfit(new[] { 7, 6, 4, 3, 1 }));
            Console.WriteLine(MaxProfit(new[] { 2, 4, 1 }));
            Console.WriteLine(MaxProfit(new[] { 1, 5, 3, 6, 4 }));
        }

        private static int LengthOfLastWord(string str)
        {
            int lastWordLength = 0;
            int lastWordLastLetterIndex = str.Length - 1;

            while (lastWordLastLetterIndex >= 0)
            {
                if (str[lastWordLastLetterIndex] == 32) // == ' '
                {
                    lastWordLastLetterIndex--;
                }
                else
                {
                    break;
                }
            }

            while (lastWordLastLetterIndex >= 0)
            {
                if (str[lastWordLastLetterIndex] == 32) // == ' '
                {
                    break;
                }

                lastWordLength++;
                lastWordLastLetterIndex--;
            }

            return lastWordLength;

            //return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
        }

        private static int MaxProfit(int[] prices)
        {
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int biggestProfit = 0;

            foreach (var currentNumber in prices)
            {
                minNumber = Math.Min(minNumber, currentNumber);
                maxNumber = Math.Max(maxNumber, currentNumber);

                int currentProfit = currentNumber - minNumber;
                biggestProfit = Math.Max(currentProfit, biggestProfit);
            }

            return biggestProfit;
        }
    }
}