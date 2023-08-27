namespace SOLIDDemo
{
    using Single_Responsibility;

    public class Program
    {
        static void Main(string[] args)
        {
            // SR (Single Responsibility Principle)
            Library library = new Library();
            library.AddBook(new Book("Title1", "Author1"));
            Book? searchedBook = library.FindBookByTitle("Title1");
            if (searchedBook != null)
            {
                Console.WriteLine($"{searchedBook.Title} - {searchedBook.Author}");
            }

            // OC (Open-Closed Principle)



            // LS (Liskov Substitution Principle)



            // IS (Interface Segregation Principle)



            // DI (Dependency Inversion Principle)



        }
    }
}