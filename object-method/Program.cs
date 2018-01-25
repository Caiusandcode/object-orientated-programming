using System;

namespace TaskFirma
{
    class Program
    {
        static void Main(string[] args)
        {

            Firma[] companies = new Firma[3];

            companies[0] = new Firma("Kartonkitehdas", "Tikkapolku 4, Vantaa", "020 0688 433", 1200400, 870000);
            companies[1] = new Firma("Konsultti firma", "Hiihtotie 2 Tampere", "020 0500 600", 250100, 440600);
            companies[2] = new Firma("Tekniikan ihme", "Onnelantie 8 Espoo", "020 572 042", 2260500, 10560210);

            

            for(int i=0;i<companies.Length;i++)
            {
                Console.WriteLine(companies[i].ToString());
                companies[i].ProfitOfCompany();
                
            }

            





            Console.ReadKey();
        }
    }
}
