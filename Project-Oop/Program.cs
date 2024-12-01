using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
namespace Project_Oop
{
    class Book
    {
        public string title;
        public string author;
        public Book(string T, string A) 
        {
           title = T; author = A;
        }
    }
    class Library_catalogue
    {
        public string Title;
        public string Author;
        public Book Book { get; set; }
        public List<Book> books = new List<Book>();
        
        public Book search( string searchitem)
        {
            return books.Find(book => book.title.Contains(searchitem) || book.author.Contains(searchitem));
        }
        public bool check(string title , string author)
        {
            return books.Exists(book => book.title == title && book.author == author);

        }

        public void addBook()
        {
            //      ADD BOOK     *
           

            Console.Write("Do you want add a new book?");
            bool n = bool.Parse(Console.ReadLine());

            while (n == true)
            {
                Console.Write(" Enter the title of book: ");
                string title = Console.ReadLine();

                Console.WriteLine(" Who's the author of the book? ");
                string author = Console.ReadLine();

                Book book = new Book(title, author);
                books.Add(book);

                Console.Write("Do you want continue and add another book? ");
                String A1 = Console.ReadLine();
                if (A1 != "yes")
                    break;
                else
                    continue;
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {

                Library_catalogue library = new Library_catalogue();
                library.addBook();


              //      SEARCH     *                //        CHECK    *
                Console.WriteLine("enter the title of book you looking for: ");
                string searchT = Console.ReadLine();
                Console.WriteLine("enter the author name of book you looking for: ");
                string searchA = Console.ReadLine();

                library.search(searchT);
                library.check(searchT,searchA);
                


            }
        }
    }

