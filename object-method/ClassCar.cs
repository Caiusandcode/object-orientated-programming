using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        public string Brand;
        public double Speed;

        // Constructor

        public Car()
        {
            Brand = "Undefined";
            Speed = 0;

        }

        public Car(string brand, int speed)
        {

            Brand = brand;
            Speed = speed;
        }

        //Methods 



        public void AskData()
        {
            Console.WriteLine("Please enter the name of a car.");
            Brand = Console.ReadLine();
            Console.WriteLine("Please enter the speed of a car.");
            Speed = double.Parse(Console.ReadLine());           
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Malli: {Brand}\n" +
                $"Nopeus: {Speed}");
        }

        public void Accelerate()
        {
            Console.WriteLine("Please give a new speed");
            double newspeed = double.Parse(Console.ReadLine());
            Speed = Speed + newspeed;
            Console.WriteLine("Kiihdytetään");
        }


        public void Brake()
        {
            Speed = Speed * 0.9;
            Console.WriteLine("Jarrutetaan");
        }

    }
}

