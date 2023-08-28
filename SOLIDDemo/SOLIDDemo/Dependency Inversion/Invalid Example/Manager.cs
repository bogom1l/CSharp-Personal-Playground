namespace SOLIDDemo.Dependency_Inversion.Invalid_Example
{
    public class Manager
    {
        public void Manage()
        {
            Worker worker = new Worker();
            worker.Work();
        }
    }
}