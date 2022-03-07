using System;
using System.Collections.Generic;

namespace Library
// The Book class should have Title, Author, PublishDate, and Genre properties.
{
    public class Book
    {
        // A constructor (lines 10-16) is a method whose name is the same as the name of its type.Its method signature includes only an optional access modifier (public or private), the method name and its parameter list; it does not include a return type.
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