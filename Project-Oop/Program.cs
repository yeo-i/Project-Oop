using System;
using System.Collections.Generic;
namespace Project_Oop
{
    class Book
    {
        public string title;
        public string author;
        public Book( string title ,string author)
        {
            this.title = title;
            this.author = author;
        }
    }
    class Library_catalogue
    {
        public string title;
        public string author;

        public void search()
        {

        }
        public bool check() 
        { 
            return true;
        }
        public Library_catalogue() { }
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
           Library_catalogue LC= new Library_catalogue();
            List<Book> books= new List<Book>();

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
                String n1 = Console.ReadLine();
                if (n1 != "yes")
                    break;
                else
                    continue;
            }
        }
    }
}
