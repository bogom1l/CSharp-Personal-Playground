namespace SOLIDDemo.Liskov_Substitution.Invalid_Example
{
    public class AdminDataFileUser : AccessDataFile
    {
        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"File {FilePath} has been read");
        }

        public override void WriteFile()
        {
            //Write File Logic  
            Console.WriteLine($"File {FilePath} has been written");
        }
    }
}