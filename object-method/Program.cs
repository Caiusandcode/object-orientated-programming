using System;
using Literature;
namespace Taskbooknew
{
    class Program
    {
        static void Main(string[] args)
        {


           // Book.ChangeCategory("Draama");
            Console.WriteLine("Book luokan testeri!\n");
            Console.WriteLine($"Kategoria nyt:\n {Book.Category}\n");        
            Book.ChangeCategory("Rakentaminen");
            Console.WriteLine($"Kategoria nyt:\n {Book.Category}\n");

            Book book1 = new Book("Häräntappo ase", "Anna-Leena Härkönen", "Otava", 10, "Draama");
            Book book2 = new Book("Rooman sota", "Kaarlo Eerik", "Euroopan kirjapaino", 25, "Sota");
            Book book3 = new Book("Rakettitiede", "Olavi Kiiski", "WSOY", 42.00, "Tietokirjallisuus");
            Book book4 = new Book("LVI Asennus kotikonstein", "Tuula", "25", 12.00, "Rakentaminen");
            Book book5 = new Book("Aku Ankka", "Don Rosa", "Helsinki Magazines", 30.00, "Sarjakuvat");

            
            book2.GetBook("Rooman sota");
           
            book5.GetBook("Aku Ankka");
            book5.GetBook("Seikkailu kirja");
            

            Console.WriteLine("Kirjakauppamme top 5 Kirjailijat\n");
            Console.WriteLine(book1.Author);
            Console.WriteLine(book2.Author);
            Console.WriteLine(book3.Author);
            Console.WriteLine(book4.Author);
            Console.WriteLine(book5.Author);
           

            Author author1 = new Author("Anna-Leena Härkönen", "15.3.1962", book1);
            author1.PrintData();

            Author author2 = new Author("Kaarlo Eerik", "11.2.1704", book2);
            author2.PrintData();

            Author author3 = new Author("Olavi Kiiski", "12.1.1992", book3);
            author3.PrintData();

            Author author4 = new Author("Heikki ", "19.10.1989", book4);
            author4.PrintData();

            Author author5 = new Author("Don Rosa", "9.2.1952", book5);
            author5.PrintData();

         

            Console.ReadKey();
        }


       // public static Book[] GreateData(Book[] books)
       // {
         //   books[0] = new Book("Häräntappo ase", "Anna-Leena Härkönen", "Otava", 10, "Draama");
           // books[1] = new Book("Rooman sota", "Kaarlo Eerik", "Euroopan kirjapaino", 25, "Sota");
           // books[2] = new Book("Rakettitiede", "Olavi Kiiski", "WSOY", 42.00, "Tietokirjallisuus");
           // books[3] = new Book("LVI Asennus kotikonstein", "Heikki", "25", 12.00, "Rakentaminen");
        //    books[4] = new Book("Aku Ankka", "Don Rosa", "Helsinki Magazines", 30, "Huumori");

          //  return books;
          
            
          
        
    }
}
    

