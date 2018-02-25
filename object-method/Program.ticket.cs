using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket();
            ticket1.customerquestions();

            ticket1.ThePrice(ticket1);

            Console.ReadKey();
            Ticket ticket2 = new Ticket();
            ticket2.customerquestions();

            ticket2.ThePrice(ticket2);

            Ticket ticket3 = new Ticket();
            ticket3.customerquestions();

            ticket3.ThePrice(ticket3);

            Console.ReadKey();
        }
    }
}
