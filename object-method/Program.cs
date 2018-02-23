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
            newCar.ShowCar2();

            Car car2 = new Car("BMW",150);
            car2.ShowCarInfo();
            car2.Accelerate();
          
            car2.ShowCarInfo();
            car2.Brake();
            car2.ShowCar2();


            Car car3 = new Car();
            car3.AskData();
            car3.ShowCarInfo();
            car3.Accelerate();
            car3.ShowCarInfo();
            car3.Brake();
            car3.ShowCar2();


            Console.ReadKey();
        }
    }
}
