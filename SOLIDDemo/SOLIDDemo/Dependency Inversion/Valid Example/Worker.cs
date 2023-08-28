namespace SOLIDDemo.Dependency_Inversion.Valid_Example
{
    public class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Worker is working...");
        }
    }
}