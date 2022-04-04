using Book_And_Library.Models;

namespace Book_And_Library
{
    internal static class Program
    {
        private static void Main()
        {
            Library library = new Library();
            Book book1 = new Book("C# Programing","Yusif Guluzade",100);
            Book book2 = new Book("Html,Css","Farid Mammadov",200);
            Book book3 = new Book("Javascript","Adil Valizada",90);
            Book book4 = new Book("Javascript","Adil Valizada",90);
            
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            // foreach (var book in library.FindAllBooksByName("javascript"))
            // {
            //     book.PrintBook();
            // }
            
            // library.RemoveAllBooksByNme("javascript");
            // library.PrintAllBooks();

            // foreach (var book in library.SearchBooks("C# Programing"))
            // {
            //     book.PrintBook();
            // }
            
            // foreach (var book in library.FindAllBooksByPageCountRange(400,100))
            // {
            //     book.PrintBook();
            // }
            
            library.RemoveBookByCode("JA4");
            library.PrintAllBooks();
        }
    }
}