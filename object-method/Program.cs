using System;

namespace Task_lippu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer data...");

            Console.Write("Enter name  :  ");

            var name = Console.ReadLine();
            var ticket = new Ticket(name);

            int age = -1;
            while (age < 0)
            {

                Console.Write("Enter age");
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Invalid age!");
                    age = -1;
                }
                else
                {

                    ticket.Age = age;
                }
            }

            ticket.IsMtkmember = YesNo("Is customer a member of MTK");
            ticket.IsConscript = YesNo("Is customer a conscript");
            ticket.IsStudent = YesNo("Is customer a student");

            Console.WriteLine($"Price for {ticket.Name} is {ticket.Whatprice():F2}");
            Console.ReadKey();
        }

       

        private static bool YesNo(string prompt)
        {
            while (true)
            {
                Console.Write("{0} (Y/N) : ", prompt);
                char c = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (c == 'Y')
                {
                    return true;
                }
                if (c == 'N')
                {
                    return false;
                }
                Console.WriteLine("Please answer Y or N!");
            }
        }
    }
}   

