namespace BasicExercises
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // OutExample();
            // ParamsExample();

            UsingExample();
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

        private static void UsingExample()
        {
            // Example 1: Using with a single object
            using (DisposableResource resource = new DisposableResource())
            {
                resource.DoSomething();
            } // The Dispose method of DisposableResource is automatically called here

            // Example 2: Using with multiple objects
            using (DisposableResource resource1 = new DisposableResource())
            using (DisposableResource resource2 = new DisposableResource())
            {
                resource1.DoSomething();
                resource2.DoSomething();
            } // Dispose methods of resource1 and resource2 are automatically called here

            // Example 3: Using with FileStream
            string filePath = "example.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, using statement!");
                fileStream.Write(data, 0, data.Length);
            } // The file stream is automatically closed here

        }
    }
}