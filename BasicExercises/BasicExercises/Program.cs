namespace BasicExercises
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // OutExample();
            // ParamsExample();
        }

        private static void OutExample()
        {
            Console.Write("Enter an integer: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var parsedValue))
            {
                Console.WriteLine($"Parsed value: {parsedValue}");
            }
            else
            {
                Console.WriteLine($"Invalid input. -> {parsedValue}");
            }
        }

        private static void ParamsExample()
        {
            var result1 = Sum(1, 2, 3, 4, 5);
            var result2 = Sum(10, 20);
            var result3 = Sum(100, 200, 300, 1, 1, 1, 1);

            Console.WriteLine($"Result 1: {result1}");
            Console.WriteLine($"Result 2: {result2}");
            Console.WriteLine($"Result 3: {result3}");
        }

        private static int Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum;
        }
    }
}