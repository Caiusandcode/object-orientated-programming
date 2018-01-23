using System;

namespace Taskbooknew
{
    class Program
    {
        
            
        static void Main(string[] args)
        { 
            Book newBook = new Book();
            
            Book book2 = new Book();
            book2.Price = 15.50;
            book2.Author = "Kiiskinen";
            book2.Title = "Rakennuskirja";
            book2.Id = 4000;

            Book book3 = new Book("LVI Asennus", "Heikki", 25, 11.00);
            Book book4 = new Book("Raketti tiede", "Olavi Kiiski", 3, 40.00);
            Console.WriteLine(book2.ToString());
            Console.WriteLine(book3.ToString());
            Console.WriteLine(book4.ToString());
            Console.WriteLine(book2.CompareBook(book4));
            
            
            
            Console.ReadKey();

        }
        
    }
}
    

