namespace BasicExercises
{
    using System;

    public class DisposableResource : IDisposable
    {
        public void DoSomething()
        {
            Console.WriteLine("DisposableResource is doing something.");
        }

        public void Dispose()
        {
            // Perform cleanup operations here
            Console.WriteLine("DisposableResource is being disposed.");
        }
    }
}
