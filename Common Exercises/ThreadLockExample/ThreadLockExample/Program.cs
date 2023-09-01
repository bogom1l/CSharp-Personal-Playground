namespace ThreadTaskExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(() =>
            {
                CountUp();
            });

            Thread thread2 = new Thread(() =>
            {
                CountDown();
            });

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is complete!");
            Console.ReadKey();
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Timer #1: {i} seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Timer #1 is complete!");
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #2: {i} seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Timer #2 is complete!");
        }

        private static int SumNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
/*
   Task task = new Task(() =>
   {
       Console.WriteLine("Running task in separate thread...");
       int result = SumNumbers(1, 2);
       Console.WriteLine("Result of addition: " + result);
   });

   task.Start();

   Console.WriteLine("Main thread is done");
   Console.ReadLine();
*/