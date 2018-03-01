using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinta
{
    class Asiakas
    {
        public string Name;
        public double Goods;


        public Asiakas(string name, double goods)
        {
            Name = name;
            Goods = goods;

        }
        public void PrintInfos()
        {
            Console.WriteLine($"{Name}, {Goods}\n");
        }
        public override string ToString()
        {
            return $"{Name}, {Goods} \n";
        }
        public void Getcustomer()
        {
            Console.WriteLine("Asiakkaan nimi on?\n");
            string Nameofcustomer = Console.ReadLine().ToUpper();

            if (Nameofcustomer.Equals(Name.ToUpper()))
                PrintInfos();
            else
                Console.WriteLine($"Nimeä {Nameofcustomer}ei löydy\n");
        }

        public void Countbonus()
        {
            double Bonus;
            if (Goods < 1000)

            {
                Bonus = Goods * 0.02;
                Console.WriteLine($"2 %, bonus on {Bonus}\n");
            }
            else if (Goods >= 1000 && Goods < 2000)
            {
                Bonus = Goods * 0.03;
                Console.WriteLine($"3 %, bonus on {Bonus}\n");
            }
            else
            {
                Bonus = Goods * 0.05;
                Console.WriteLine($"5 %, bonus on {Bonus}\n");

            }
        }

    }
}    
    