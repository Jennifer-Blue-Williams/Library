using System;
using System.Collections.Generic;
// Create another file called LibraryManager.cs and create another class in it called LibraryManager. 
namespace Library
// Add a constructor method to your LibraryManager class that takes a string parameter that will represent the library's name.
{
    public class LibraryManager
    {
        // Get method returns the value of the variable name while Set method assigns a value to the name variable.
        public LibraryManager(string name)
        {
            Name = name;
        }
        public string Name { get; }

        // Phase12 - Create a private field in the LibraryManager class called _books. Its type will be List<Book> , and you can set it equal to an empty List<Book>
        private List<Book> _books = new List<Book>();
        // Lines 9-12 showed squiggly lines until the get; set; was added
        // Phase13 - Write a method for the LibraryManager class that displays the books in an instance of LibraryManager using the same format as #6 and #8
        public void displayLibraryBooks()
        {
            foreach (Book libraryBook in _books)
                Console.WriteLine($"{libraryBook.Title}, by {libraryBook.Author} ");
        }
        // Phase14 - Write a method to add a book to an instance of LibraryManagers _books field, it should take a parameter of type Book
        public void addLibraryBook(Book book)
        {
            _books.Add(book);
        }
    }
}
