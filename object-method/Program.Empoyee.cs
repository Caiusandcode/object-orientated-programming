using System;

namespace TaskEmployee
{
    class program
    {
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Masa", 25, "Boss", 7500);
            employees[1] = new Employee("Ann", 10, "Advisor", 4600);
            employees[2] = new Employee("Emilia", 46, "Developer",4400 );

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeInfo();
            }

            Console.WriteLine($"{employees[0].CompareSalary(employees[1])}");
            Console.WriteLine($"{employees[1].CompareSalary(employees[2])}");


            Console.ReadKey();
        }
    }
}
