namespace OutRefExamples
{
    public class Program
    {
        public static void Main()
        {
            int a = 10;
            Console.WriteLine(a);

            for (int i = 0; i < 10; i++)
            {
                RefIncrement(ref a);
            }

            InitializeNumberInMethod(out int b);

            InitializeMultipleNumbersInMethod(out int c, out int d);

            RefIncrement(ref c);

            InitializeStringInMethod(out string text);
        }

        private static void RefIncrement(ref int number)
        {
            number += 5;
            Console.WriteLine(number);
        }

        private static void InitializeNumberInMethod(out int number)
        {
            number = 99;
            Console.WriteLine(number);
            Console.WriteLine("---");
        }

        private static void InitializeMultipleNumbersInMethod(out int c, out int d)
        {
            c = 404;
            d = 505;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("---");
        }

        private static void InitializeStringInMethod(out string text)
        {
            text = "NewText";
            Console.WriteLine(text);
            Console.WriteLine("---");
        }
    }
}