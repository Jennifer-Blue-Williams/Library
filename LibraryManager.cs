using System;
using System.Collections.Generic;
// Create another file called LibraryManager.cs and create another class in it called LibraryManager. 
namespace Library
// Add a constructor method to your LibraryManager class that takes a string parameter that will represent the library's name.
{
    public class LibraryManager
    {
        public LibraryManager(string name)
        {
            Name = name;
        }

        // Phase12 - Create a private field in the LibraryManager class called _books. Its type will be List<Book> , and you can set it equal to an empty List<Book>
        private List<Book> _books = new List<Book>();

        public string Name
        { get; set; }
        // Lines 9-12 showed squiggly lines until the get; set; was added
    }
}
