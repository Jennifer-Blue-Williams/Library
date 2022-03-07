using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        public static void Main(string[] args)
        // In the main method, create an instance of the Book class, and save its value as a variable
        {
            List<Book> BookList = new List<Book>();
            // Phase7 - Create some more books (Below) and store them in a List
            // var book#1,2,3,4 only creates new instances of books, it does not add them to the list
            var book1 = new Book("C# for Dummies", "Josh Barton", new DateTime(2022, 3, 05), "Educational");
            var book2 = new Book("Oh, the Places You'll Go", "Dr. Seuss", new DateTime(1990, 1, 22), "Childrens");
            var book3 = new Book("The Shining", "Stephen King", new DateTime(1977, 1, 28), "Horror");
            var book4 = new Book("Diabetic Dessert Cookbook ", "Anna Bright", new DateTime(2011, 10, 11), "Food&Beverage");
            // Below, we use the .Add method to add them to the list
            BookList.Add(book1);
            BookList.Add(book2);
            BookList.Add(book3);
            BookList.Add(book4);


            // Phase6(Step 15 says to delete this. Leaving it for future reference) - using your instance of Book, print out its Title and Author to the Console in the format<Title>, by<Author>
            // Console.WriteLine($"The {book1.Genre} book, {book1.Title}, by {book1.Author}, was published on {book1.PublishDate}. ");
            // Phase8(Step 15 says to delete this. Leaving it for future reference) - Iterate over BookList, and print the title / author to the Console in the loop in the same format as in 6.!!!!!The lower case book is a TACO!!!!
            // foreach (Book book in BookList)
            // {
            //     Console.WriteLine($"{book.Title} by {book.Author}");
            // }
        }
    }
}

