namespace SOLIDDemo
{
    using Single_Responsibility;
    using Open_Closed;
    using Liskov_Substitution.Valid_Example;
    using Interface_Segregation.Valid_Example;
    using Dependency_Inversion.Valid_Example;

    public class Program
    {
        private static void Main(string[] args)
        {
            // SR (Single Responsibility Principle)

            Library library = new Library();
            library.AddBook(new Book("Title1", "Author1"));

            Book? searchedBook = library.FindBookByTitle("Title1");

            if (searchedBook != null)
            {
                Console.WriteLine($"{searchedBook}: {searchedBook.Title} - {searchedBook.Author}");
            }

            // OC (Open-Closed Principle)

            File file = new File("TextFile123", 500, 25);
            Music music = new Music("Artist1", "Album1", 100, 45);

            Progress progress1 = new Progress(file);
            Progress progress2 = new Progress(music);

            Console.WriteLine($"{progress1} : {progress1.CurrentPercent()}");
            Console.WriteLine($"{progress2} : {progress2.CurrentPercent()}");

            // LS (Liskov Substitution Principle)

            IFileReader reader = new AdminDataFile();
            reader.ReadFile("exampleFilePath1");

            IFileWriter writer = new AdminDataFile();
            writer.WriteFile("exampleFilePath1");

            IFileReader reader2 = new RegularDataFile();
            reader2.ReadFile("exampleFilePath2");

            // IS (Interface Segregation Principle)

            Human human = new Human();
            human.Work();
            human.Eat();
            human.Sleep();

            Robot robot = new Robot();
            robot.Work();

            // DI (Dependency Inversion Principle)

            Worker worker = new Worker();
            Manager manager1 = new Manager(worker);
            manager1.Manage();

            HighPerformer highPerformerEmployee = new HighPerformer();
            Manager manager2 = new Manager(highPerformerEmployee);
            manager2.Manage();
        }
    }
}