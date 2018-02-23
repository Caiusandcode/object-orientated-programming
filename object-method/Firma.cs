using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFirma
{
    class Firma
    {
        //Fields, attributes
        public string Name;
        public string Adress;
        public string Phone;
        public double Outcome;
        public double Outgoings;


        //Constructor
       

        public Firma(string name, string adress, string phone, int outcome, int outgoings)
        {
            Name = name;
            Adress = adress;
            Phone = phone;
            Outcome = outcome;
            Outgoings =  outgoings;

        }

        public Firma()
        {
            Name = "TakuuAuto";
            Adress = "Kivitie 37 00700 Malmi, Helsinki";
            Phone = "0200 770 990";
            Outcome = 530400;
            Outgoings = 256000;
        }

        // Copy constructor.
        public Firma(Firma firma)
        {
            Name = firma.Name;
            Adress = firma.Adress;
            Phone = firma.Phone;
            Outcome = firma.Outcome;
            Outgoings = firma.Outgoings;
        }

        //Methods

        public void ProfitOfCompany()
        {
            double profit = ((double)(Outcome - Outgoings) / (double)Outgoings);
            Console.WriteLine($"Yrityksen {Name} voittoprosentti on: {profit * 100}%");

            if (profit <= 1)
            {
                Console.WriteLine($"Yrityksellä {Name} menee kehnosti.\n");
            }
            else if (profit > 1 && profit < 3)
            {
                Console.WriteLine($"Yrityksellä {Name} menee tyydyttävästi.\n");
            }
            else if (profit >= 3)
            {
                Console.WriteLine($"Yrityksellä {Name} menee hyvin.\n");
            }
        }

        public void Print()
        {
            Console.WriteLine($"--------------------------------\n" +
            $"Firman nimi:\t\t{Name}\n" +
            $"Osoite:\t\t{Adress}\n" +
            $"Puhelin:\t\t{Phone}\n" +
            $"Tulot:\t\t{Outcome}\n" +
            $"Menot:\t\t{Outgoings}\n" +
            
            $"===========================================\n");


           
            
        }
    }
}

