using System;

namespace TaskFirma
{
    class Program
    {
        static void Main(string[] args)
        {

            Firma company = new Firma("Kartonkitehdas", "Tikkapolku 4, Vantaa", "020 0688 433", 1200400, 870000);
            company.Print();
            company.ProfitOfCompany();

            Firma company2 = new Firma();
            company2.Print();
            company2.ProfitOfCompany();

            Firma company3 = new Firma(company2);
            company3.Print();
            company3.ProfitOfCompany();




            Firma company4 = new Firma("Tekniikan ihme", "Onnelantie 8 Espoo", "020 572 042", 2260500, 1056021);
            company4.Print();
            company4.ProfitOfCompany();




            Console.ReadKey();
        }
    }
}
