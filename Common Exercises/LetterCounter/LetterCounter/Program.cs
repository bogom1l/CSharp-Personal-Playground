namespace LetterCounter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string sentence = "технология за транслация на адреси";
            string sentence = "tehnologiq za translaciq na adresi";
            Console.WriteLine("all letters = " + sentence.Length);

            Dictionary<char, int> uniqueSymbols = new Dictionary<char, int>();

            foreach (var c in sentence)
            {
                if (uniqueSymbols.ContainsKey(c))
                {
                    uniqueSymbols[c]++;
                }
                else
                {
                    uniqueSymbols[c] = 1;
                }
            }

            Console.WriteLine($"unique symbols = {uniqueSymbols.Keys.Count}");

            foreach (var uniqueSymbol in uniqueSymbols)
            {
                Console.WriteLine($"{uniqueSymbol.Key} - {uniqueSymbol.Value}");
            }

            Console.WriteLine("---------------------------------");

            var sortedSymbols = uniqueSymbols.OrderByDescending(pair => pair.Value);

            foreach (var uniqueSymbol in sortedSymbols)
            {
                Console.WriteLine($"{uniqueSymbol.Key} - {uniqueSymbol.Value}");
            }
        }
    }
}