using System;

namespace TaskEmployee
{
    class program {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee();
            Employee worker2 = new Employee("Masa", 2, "BigBoss", 100000);
            worker1.PrintEmployeeInfo();
            worker2.PrintEmployeeInfo();

            

            Console.ReadKey();
        }
    }
}
