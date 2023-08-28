namespace SOLIDDemo.Liskov_Substitution.Invalid_Example
{
    public class RegularDataFileUser : AccessDataFile
    {
        //Assuming Regular User can only read file, and cannot modify them

        public override void ReadFile()
        {
            // Read File logic  
            Console.WriteLine($"File {FilePath} has been read");
        }

        //!
        //------Does not follow the “Liskov Substitution Principle”--------
        public override void WriteFile()
        {
            throw new NotImplementedException();
        }
    }
}