namespace SOLIDDemo.Liskov_Substitution.Valid_Example
{
    using System;

    public class AdminDataFile : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    
            Console.WriteLine($"File {filePath} has been read"); 
        }

        public void WriteFile(string filePath)
        {
            // Write File logic    
            Console.WriteLine($"File {filePath} has been written"); 
        }
    }
}
