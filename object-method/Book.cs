using System;


namespace Taskbooknew

{

    class Book
    {
        private  string _title;
        private readonly string _author;
        private string _publisher;
        private double _price;
        private static string _category;
        //Constructor
        public Book()
        {
            Title = "undefined";
            _author = "undefined";
            Publisher = "undefined";
            Price = 0;
            _category = "undefined";
        }

        public Book(string title, string author, string publisher, double price, string category)
        {
            Title = title;
            _author = author;
            Publisher = publisher;
            Price = price;
            _category = category;

        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        public string Author
        {
            get { return _author; }
            set { Author = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value; 
                if (value > 30 )
                    _price = value * 0.9;
            }
        }
        public static string Category
        {
            get { return _category; }
          //  set { _category = value;  }
           
        }

        public void GetBook(string title)
        {
            if (Title == title)
            {
                Console.WriteLine($"Kirja löytyi!\n" +
                                  $"Kirjan nimi:\t{Title}\n" +
                                  $"Kirjailija:\t{Author}\n" +
                                  $"Julkaisija:\t{Publisher}\n" +
                                  $"Kappalehinta:\t{Price}  \n" +
                                  $"Kategoria:\t{_category}\n" +
                                  $"----------------------------\n");
            }
            else
            {
                Console.WriteLine($"Kirjaa ei löytynyt.\n" +
                                  $"-----------------------\n");
            }

        }
        public static void ChangeCategory(string category)
        {
            _category = category;
        }


        // Methods
        public override string ToString()
        {
            return ($"Kirjan nimi:\t{Title}\n" +                    
                     $"Julkaisija:\t{Publisher}\n" +
                     $"Kappalehinta:\t{Price} \n" +
                     $"Kategoria:\t{Category}\n" +
                     $"____________________________\n");
        }
        
    }

}

