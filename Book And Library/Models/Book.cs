using System;

namespace Book_And_Library.Models
{
    public class Book
    {
        private static int _id;
        private int _pageCount;

        public int BookId { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Code { 
            get;
            private set;
        }
        public int PageCount
        {
            get => _pageCount;
            set
            {
                if (value > 0)
                {
                    _pageCount = value;
                }
            }
        }

        static Book()
        {
            _id = 0;
        }

        private Book()
        {
            BookId = ++_id;
        }

        public Book(string name, string authorName, int pageCount):this()
        {
            Name = name.Trim();
            AuthorName = authorName.Trim();
            PageCount = pageCount;
            Code = name.Trim()[..2].ToUpper() + _id;
        }

        public void PrintBook()
        {
            Console.WriteLine($"\n Book id: {BookId.ToString()}\n Book name: {Name}\n Author name: {AuthorName}\n Page count: {PageCount.ToString()}\n Book code: {Code}\n");
        }
    }
}