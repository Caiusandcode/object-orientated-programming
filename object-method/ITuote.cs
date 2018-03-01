using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinta
{
    class ITuote
    {
        // muuttuja
        public string Name;
        public double Unit_price;
        public int Number;
        


        // konstruktori
        public ITuote(string name, double unit_price, int number)
        {
            Name = name;
            Unit_price = unit_price;
            Number = number;
            

        }
        // metodi

        public void Getproduct()
        {
            Console.Write("Anna tuotteen nimi!!!");
            String Whatname = Console.ReadLine().ToUpper();

            if (Whatname.Equals(Name.ToUpper()))
                PrintInfos();
            else
                Console.WriteLine($"Tuote {Whatname} on hävinnyt. ");
        }

        public string Totalvalue()

        {
            
            double Total = Unit_price * Number;
            return $"Kokonaisarvo on {Total}";

        }

        public void PrintInfos()
        {
            Console.WriteLine($"{Name}, {Unit_price}, {Number}\n");

        }

        public override string ToString()
        {
            return $"{Name}, {Unit_price},{Number}\n";
        }
    }
}
