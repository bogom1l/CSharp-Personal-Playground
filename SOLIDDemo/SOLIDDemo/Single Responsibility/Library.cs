namespace SOLIDDemo.Single_Responsibility
{
    using System.Collections.Generic;

    public class Library
    {
        private IList<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public Book? FindBookByTitle(string title)
        {
            return this.books.FirstOrDefault(b => b.Title == title);
        }
    }
}
