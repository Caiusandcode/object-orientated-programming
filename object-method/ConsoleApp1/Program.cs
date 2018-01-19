using System;
using System.Text;


namespace TaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("C#","Masa",123,22.90);
            Book book3 = new Book("Java", "Jim", 3456, 30.90);

            Console.WriteLine (book1.ToString());
            Console.WriteLine(book2.ToString());
            Console.WriteLine(book3.ToString());
            Console.ReadKey();


        
        }
            
}
}
      