namespace SOLIDDemo.Interface_Segregation.Valid_Example
{
    public class Human : IWorker, ISleeper, IEater
    {
        public void Eat()
        {
            Console.WriteLine("Human is eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Human is sleeping...");
        }

        public void Work()
        {
            Console.WriteLine("Human is working...");
        }
    }
}