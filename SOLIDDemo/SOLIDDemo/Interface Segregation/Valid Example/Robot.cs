namespace SOLIDDemo.Interface_Segregation.Valid_Example
{
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working...");
        }
    }
}