namespace SOLIDDemo.Dependency_Inversion.Valid_Example
{
    public class Manager
    {
        //Vseki Manager si ima edin rabotnik, i moje da mu zapovqdva da raboti s method-a Manage()

        private readonly IWorker _worker;

        public Manager(IWorker worker)
        {
            this._worker = worker ?? throw new ArgumentNullException(nameof(worker));
        }

        public void Manage()
        {
            this._worker.Work();
        }

        public void GiveSalary()
        {
            //logic
            Console.WriteLine("Manager giving salary to the worker...");
        }
    }
}
