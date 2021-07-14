using System;
using System.Collections.Generic;

namespace OOP_Beispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car()
            {
                Acceleration = 100,
                DoorCount = 5,
                BreakSpeed = 50,
                Speed = 200
            };     

            Plane plane = new Plane()
            {
                Acceleration = 500,
                DoorCount = 10,
                BreakSpeed = 200,
                Speed = 600,
                HasJetDrive = true
            };        

            Motorcycle motorcycle = new Motorcycle()
            {
                Acceleration = 250,
                DoorCount = 0,
                BreakSpeed = 25,
                Speed = 350
            };

            Helicopter heli = new Helicopter()
            {
                Acceleration = 250,
                DoorCount = 0,
                BreakSpeed = 25,
                Speed = 350
            };

            vehicles.Add(car);
            vehicles.Add(plane);
            vehicles.Add(motorcycle);
            vehicles.Add(heli);

            Console.WriteLine("Welches Fahrzeug möchtest du fahren?");
            var userInput = Console.ReadLine();
           
            foreach(Vehicle vehicle in vehicles)
            {
                if(vehicle.GetType().Name == userInput)
                {
                    Console.WriteLine("Fahrzeug gefunden: " + userInput);

                    vehicle.LogInformation();

                    if(userInput == nameof(Car))
                    {
                        Car myCar = vehicle as Car;
                        myCar.Move();
                    } else if( userInput == nameof(Plane))
                    {
                        Plane myPlane = vehicle as Plane;
                        myPlane.Move();
                        myPlane.Landing();
                    } else if(userInput == nameof(Motorcycle))
                    {
                        Motorcycle myBike = vehicle as Motorcycle;
                        myBike.Move();
                    }
                    else if (userInput == nameof(Helicopter))
                    {
                        Helicopter myHeli = vehicle as Helicopter;
                        myHeli.Move();
                        myHeli.Landing();
                    }
                    else
                    {
                        Console.WriteLine("Dieses Fahrzeug steht nicht bereit.");
                    }

                    break;
                }
            }
            
           
        }
    }
}
