namespace SOLIDDemo.Interface_Segregation.Invalid_Example
{
    public class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Working...");
        }
    }
}