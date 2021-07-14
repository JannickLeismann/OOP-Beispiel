using System;

namespace OOP_Beispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car = new Car()
            {
                Acceleration = 100,
                DoorCount = 5,
                BreakSpeed = 50,
                Speed = 200
            };

            car.LogInformation();
            car.Move();

            Plane plane = new Plane()
            {
                Acceleration = 500,
                DoorCount = 10,
                BreakSpeed = 200,
                Speed = 600,
                HasJetDrive = true
            };

            plane.LogInformation();
            plane.Move();

            Motorcycle motorcycle = new Motorcycle()
            {
                Acceleration = 250,
                DoorCount = 0,
                BreakSpeed = 25,
                Speed = 350
            };

            motorcycle.LogInformation();
            motorcycle.Move();
        }
    }
}
