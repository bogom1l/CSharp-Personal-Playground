namespace SOLIDDemo.Liskov_Substitution.Valid_Example
{
    public class RegularDataFile : IFileReader
    {
        public void ReadFile(string filePath)    
        {    
            // Read File logic    
            Console.WriteLine($"File {filePath} has been read");    
        } 
    }
}
