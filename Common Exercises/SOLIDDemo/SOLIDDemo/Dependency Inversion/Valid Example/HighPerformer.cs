namespace SOLIDDemo.Dependency_Inversion.Valid_Example
{
    public class HighPerformer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("High performer is working...");
        }
    }
}