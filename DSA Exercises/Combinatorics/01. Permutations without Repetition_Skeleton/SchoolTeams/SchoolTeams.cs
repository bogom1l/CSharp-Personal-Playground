namespace _05._School_Teams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SchoolTeams
    {
        private static void Main(string[] args)
        {
            string[] girls = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] boys = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string[] girlCombinations = new string[3];
            string[] boyCombinations = new string[2];

            List<string[]> girlsComb = new List<string[]>();
            List<string[]> boysComb = new List<string[]>();

            Combination(0, 0, girlCombinations, girls, girlsComb);
            Combination(0, 0, boyCombinations, boys, boysComb);

            foreach (string[] item in girlsComb)
            {
                foreach (string[] element in boysComb)
                {
                    Console.WriteLine($"{string.Join(", ", item)}, {string.Join(", ", element)}");
                }
            }

            void Combination(int index, int start, string[] combination, string[] collection, List<string[]> combs)
            {
                if (index >= combination.Length)
                {
                    combs.Add(combination.ToArray());
                    return;
                }

                for (int i = start; i < collection.Length; i++)
                {
                    combination[index] = collection[i];
                    Combination(index + 1, i + 1, combination, collection, combs);
                }
            }
        }
    }
}