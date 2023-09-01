namespace SOLIDDemo.Liskov_Substitution.Invalid_Example
{
    public class AccessDataFile
    {
        public string FilePath { get; set; }

        public virtual void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"Base File {FilePath} has been read");
        }

        public virtual void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"Base File {FilePath} has been written");
        }
    }
}