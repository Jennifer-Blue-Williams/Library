using System;
using System.Collections.Generic;

namespace Library
// The Book class should have Title, Author, PublishDate, and Genre properties.
{
    public class Book
    {
        public Book(string title, string author, DateTime publishDate, string genre)
        {
            Title = title;
            Author = author;
            PublishDate = publishDate;
            Genre = genre;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
    }
}