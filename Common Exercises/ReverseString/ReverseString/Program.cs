namespace ReverseString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello World"));
        }

        private static string ReverseString(string str)
        {
            string reversedString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }

            return reversedString;
        }
    }
}