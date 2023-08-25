namespace CollectionsDemo
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            Demo2();
        }

        public static void Demo1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // IEnumerable<T> usage
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // ICollection<T> usage
            numbers.Add(6);
            numbers.Remove(3);

            // IList<T> usage
            Console.WriteLine(numbers[2]);

            // IReadOnlyList<T> usage
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }

        public static void Demo2()
        {
            //IList
            IList<int> ints1 = new List<int>();
            ints1.Insert(0, 5);
            ints1.RemoveAt(0);
            ints1.Add(1);
            ints1[0] = 4;
            Console.WriteLine(ints1[0]);

            //ICollection
            ICollection<int> ints2 = new List<int>();
            ints2.Remove(1);

            //IEnumerable
            IEnumerable<int> ints3 = new List<int>();
            foreach (int n in ints3)
            {
                Console.WriteLine(n);
            }

            //IReadOnlyCollection
            IReadOnlyCollection<int> ints4 = new HashSet<int>(ints1);
            Console.WriteLine(ints4.Count);


            //List
            List<int> ints5 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Console.WriteLine("ints5.Capacity = " + ints5.Capacity);

            //Collection
            Collection<int> ints6 = new Collection<int>() { 4, 5, 6, 7 };
            ints6.RemoveAt(0);
        }

    }
}