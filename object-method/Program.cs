using System;

namespace TaskCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.AskData();
            newCar.ShowCarInfo();
            newCar.Accelerate();
            newCar.ShowCarInfo();
            newCar.Brake();
            newCar.ShowCarInfo();

            Car car2 = new Car("BMW",150);
            car2.ShowCarInfo();
            car2.Accelerate();
            car2.ShowCarInfo();
            car2.Brake();
            car2.ShowCarInfo();


            Car car3 = new Car("Skoda", 80);
            car3.ShowCarInfo();
            car3.Accelerate();
            car3.ShowCarInfo();
            car3.Brake();
            car3.ShowCarInfo();


            Console.ReadKey();
        }
    }
}
