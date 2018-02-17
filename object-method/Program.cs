using System;

namespace Vechile
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Car Vehicle1 = new Car("auto", "audi", 2018, 40000, 2.0, "a6", 4 );
            Console.WriteLine($"{Vehicle1.PrintInformation()}");
            Car Vehicle2 = new Car("maasturi", "bmw", 2015,35000, 4.5, "alfa", 4 );

            Console.WriteLine($"{Vehicle2.PrintInformation()}");

            Lorry kuorma = new Lorry("Kuorma auto", "ford", 2014, 50000, 6000, 0.4 );
            Console.WriteLine($"{kuorma.PrintInformation()}");


           Vehicle ajopeli = new Vehicle("auto", "rändöm", 2050, 4500);
           Console.WriteLine(ajopeli.ToString());

            Console.ReadKey();

        }
    }
}
