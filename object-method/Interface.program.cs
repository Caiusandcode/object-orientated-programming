using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinta
{
    class Interface
    {
        

        static void Main(string)[] args)
        {

            ITuote Läppäri = new ITuote("Läppäri", 400, 5);
            Läppäri.Getproduct();
            Läppäri.Totalvalue();
            
            Asiakas Masa = new Asiakas("Masa"4000);
            Masa.Getcustomer();
            Masa.Countbonus();

            Console.ReadKey();


    }
}
