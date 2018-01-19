﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        //Muuttujat
        public string Name;
        public int Id;
        public string Position;
        public double Salary;

        //Konstruktorit
        public Employee()
        {
            Name = "Joe";
            Id = 10;
            Position = "Worker";
            Salary = 20000;
        }

        public Employee(string name, int id, string position, double salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }
        
        //Metodit
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"ID:\t\t{Id}\n" +
                $"Titteli:\t{Position}\n" +
                $"Nimi:\t\t{Name}\n" +
                $"Palkka:\t\t{Salary}\n" +
                $"----------------------");
        }

    }
}
