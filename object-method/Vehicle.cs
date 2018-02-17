using System;

namespace Vechile
{
    class Vehicle
    {

        protected string Type;
        private string _brand;
        protected int Year;
        protected double Price;

        public Vehicle(string type, string brand, int year, double price)
        {
            Type = type;
            _brand = brand;
            Year = year;
            Price = price;
        }

       

        public virtual string PrintInformation()
        {
            return $"Type:\t{Type}\n" +
                   $"Brand:\t{_brand}\n" +
                   $"Year:\t{Year}\n" +
                   $"Price:\t{Price}\n";
                  

        }
        public override string ToString()
        {
            return PrintInformation();
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        
    }

}