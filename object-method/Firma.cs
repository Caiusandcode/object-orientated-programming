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
        public double Income;


        //Constructor
        //public Firma()
        //{
        //    Name = "unknown";
        //    Adress = "unknown";
        //    Phone = 0;
        //    Outcome = 0;
        //    Income = 0;

        //}

        public Firma(string name, string adress, string phone, int outcome, int income)
        {
            Name = name;
            Adress = adress;
            Phone = phone;
            Outcome = outcome;
            Income = income;

        }
        public Firma()
        {
            Name = "TakuuAuto";
            Adress = "Kivitie 37 00700 Malmi, Helsinki";
            Phone = "0200 770 990";
            Outcome = 530400;
            Income = 681500;
        }

        // Copy constructor.
        public Firma(Firma previousFirma)
        {
            Name = previousFirma.Name;
            Adress = previousFirma.Adress;
            Phone = previousFirma.Phone;
            Outcome = previousFirma.Outcome;
            Income = previousFirma.Income;
        }

        //Methods

        public void ProfitOfCompany()
        {
            double profit = (Income - Outcome) / Outcome * 100;

            if (profit <= 100)
                Console.WriteLine($"Firmalla {Name} menee kehnosti.");
            else if (profit > 100 && profit <= 200)
                Console.WriteLine($"Firmalla {Name} menee tyydyttävästi");
            else
                Console.WriteLine($"Firmalla {Name} menee hyvin");
        }

        public override string ToString()
        {
            string result = $"------------------------\n" +
                 $"Firman nimi:\t{Name}\n" +
                 $"Osoite:\t{Adress}\n" +
                 $"Puhelin:\t\t{Phone}\n" +
                 $"Menot:\t{Outcome}\n" +
                 $"Tulot:\t{Income}\n" +
                 $"======================\n";


            return result;
        }
    }
}

