using System;
using System.Collections.Generic;

namespace Book_And_Library.Models
{
    public class Library
    {
        private readonly List<Book> _books;

        public List<Book> Books { get => _books;}

        public Library()
        {
            _books = new List<Book>();
        }
        
        public void AddBook(Book book)
        {
            if (book is null) throw new ArgumentNullException();
            _books.Add(book);
        }

        public List<Book> FindAllBooksByName(string name)
        {
            if (name is null) throw new ArgumentNullException();
            var books = _books.FindAll(book => book.Name.ToLower() == name.ToLower().Trim());
            if (books.Count == 0) throw new Exception("\n No results found\n");
            return books;
        }

        public void RemoveAllBooksByNme(string name)
        {
            if (name is null) throw new ArgumentNullException();
            var removeCount = _books.RemoveAll(book => book.Name.ToLower() == name.ToLower().Trim());
            if (removeCount == 0) throw new Exception("\n No results found\n");
        }

        public List<Book> SearchBooks(string value)
        {
            if (value is null) throw new ArgumentNullException();
            value = value.Trim().ToLower();
            var books = _books.FindAll(book =>
                book.Name.ToLower() == value || book.AuthorName.ToLower() == value ||
                book.PageCount.ToString() == value);
            if (books.Count == 0) throw new Exception("\n No results found\n");
            return books;
        }

        public List<Book> FindAllBooksByPageCountRange(int? maxRange,int? minRange = 0)
        {
            if (maxRange is null || minRange is null) throw new ArgumentNullException();
            if (maxRange < minRange) throw new ArgumentOutOfRangeException();
            
                var books = _books.FindAll(book => minRange <= book.PageCount && book.PageCount <= maxRange);
            if (books.Count == 0) throw new Exception("\n No results found\n");
            return books;
        }

        public void RemoveBookByCode(string bookCode)
        {
            if (bookCode is null) throw new ArgumentNullException();
            var book = _books.Find(b => string.Equals(b.Code, bookCode, StringComparison.CurrentCultureIgnoreCase));
            if (book is null) throw new NullReferenceException("\n No results found\n");
            _books.Remove(book);
        }

        public void PrintAllBooks()
        {
            foreach (var book in _books)
            {
                Console.WriteLine($"\n Book id: {book.BookId.ToString()}\n Book name: {book.Name}\n Author name: {book.AuthorName}\n Book code: {book.Code}\n");
            }
        }


    }
}