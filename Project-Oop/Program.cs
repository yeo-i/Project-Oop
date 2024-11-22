using System;
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

        public void search() { }
        public bool check() { return true; }
        public Book add() { return new Book(title, author); }
        public Library_catalogue() { }
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
