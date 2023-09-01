namespace SOLIDDemo.Interface_Segregation.Invalid_Example
{
    public class Human : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }

        public void Work()
        {
            Console.WriteLine("Working...");
        }
    }
}