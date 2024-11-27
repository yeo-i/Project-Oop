using System;
using System.Collections.Generic;
namespace Project_Oop
{
    class Book
    {
        public Book() { }     //     *
        public Book( string title ,string author) { }
    }
    class Library_catalogue
    {
        public string title;
        public string author;
        Book B= new Book();     //       *
        public Library_catalogue(string Etitle , string eauthor)   //       * 
        {
            Etitle = title;
            eauthor = author;
        }
        public void search()
        {
            if (title =="k")    //     *
                title =author;


        }
        public bool check() 
        { 
            if (title == null)     //        *
            return true;
            else
                return false;
           
        }
       
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //      SEARCH     *           //     *
            Console.WriteLine("enter the title of book you looking for: ");
            string searchT=Console.ReadLine();

            Console.WriteLine("enter the author name of book you looking for: ");
            string searchA = Console.ReadLine();
            Library_catalogue library=new Library_catalogue(searchT,searchA);


            //      ADD BOOK   *
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
