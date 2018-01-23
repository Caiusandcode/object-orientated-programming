using System;


namespace Taskbooknew

{

    class Book
    {
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constructor
        public Book()
        {
            Title = "Undefined";
            Author = "Undefined";
            Id = 0;
            Price = 0;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;
        }

        public string CompareBook(Book kirja)
        {
            if (Price > kirja.Price)
                return $"{Title} kirja on kalliimpi kuin {kirja.Title} kirja. \n";

            return $"{kirja.Title} kirja on kalliimpi kuin {Title} kirja. \n";

        }

        public bool IsExpensier(Book kirja)
        {
            return (Price > kirja.Price);
        }

     
        
    
        
        // Methods
        public override string ToString()
        {
            var result = $"Kirjan nimi:\t{Title}\n" +
                         $"Kirjoittaja:\t{Author}\n" +
                         $"Id:\t\t{Id}\n" +
                         $"Kappalehinta:\t{Price} \n";

            return result;
        }
        
    }

}

