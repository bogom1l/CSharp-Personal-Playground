namespace Cinema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Cinema
    {
        private static List<string> names;
        private static string[] positions;
        private static bool[] locked;
        private static List<string> people;

        public static void Main()
        {
            people = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] seats = new string[people.Count];
            bool[] locked = new bool[people.Count];

            string end;
            while ((end = Console.ReadLine()) != "generate")
            {
                string[] input = end.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                people.Remove(input[0]);
                seats[int.Parse(input[1]) - 1] = input[0];
                locked[int.Parse(input[1]) - 1] = true;
            }

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= people.Count())
            {
                Print();
                return;
            }

            Permute(index + 1);

            for (int i = index + 1; i < people.Count(); i++)
            {
                Swap(index, i);
                Permute(index + 1);
                Swap(index, i);
            }
        }

        private static void Print()
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < positions.Length; i++)
            {
                if (locked[i])
                {
                    sb.Append($"{positions[i]} ");
                }
                else
                {
                    sb.Append($"{names[index++]} ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private static void Swap(int first, int second)
        {
            (names[first], names[second]) = (names[second], names[first]);
        }
    }
}