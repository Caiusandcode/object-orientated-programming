using System;

namespace TaskBook
{
    class Book
    {
        public string Title;
        private readonly string _author;
        private int _id;
        public double _price;

        // Consructor
        public Book()
        {
            Title = "Undefined";
            _author = "Undefined";
            _id = 0;
            _price = 0;
        }

        public Book(string title, string author, int id, double price)
        {
            Title = title;
            _author = author;
            _id = id;
            _price = price;
        }

        public string CompareBook(Book book)
        {
            if (_price > book._price)
                return $"Kirja {Title} on kalliimpi kuin {book.Title} kirja.";
            else
                return string.Format("Kirja {0} on kallimpi kuin {1} kirja.", book.Title, Title);
        }

        // Methods
        public override string ToString()
        {
            var result = $"Kirjan nimi:\t{Title}\n";
            return result;

         }


    }
}



