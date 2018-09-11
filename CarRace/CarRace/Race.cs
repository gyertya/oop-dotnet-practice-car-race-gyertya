using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Race
    {
        public List<Car> Cars { get; set; }
        public List<Motorcycle> Motorcycles { get; set; }
        public List<Truck> Trucks { get; set; }

        public static Random rnd = new Random();

        public bool IsThereABrokenTruck { get; set; }

        /// <summary>
        /// creates 10 cars, 10 trucks and 10 motorcycles.
        /// </summary>
        private void CreateVehicles()
        {
            Cars = new List<Car>();
            Motorcycles = new List<Motorcycle>();
            Trucks = new List<Truck>();

            for (int i = 0; i < 10; i++)
            {
                Cars.Add(new Car());
                Motorcycles.Add(new Motorcycle());
                Trucks.Add(new Truck());
            }

        }

        /// <summary>
        /// simulates the race by
        /// - calling moveForAnHour() on every vehicle 50 times
        /// - setting whether its raining
        /// </summary>
        private void SimulateRace()
        {
            for (int lap = 0; lap < 50; lap++)
            {
                foreach (var car in Cars)
                {
                    car.MoveForAnHour(this);
                }
                foreach (var motorcycle in Motorcycles)
                {
                    motorcycle.MoveForAnHour(this);
                }
                foreach (var truck in Trucks)
                {
                    truck.MoveForAnHour(this);
                }
            }

        }

        /// <summary>
        /// prints each vehicle's name, distance traveled ant type.
        /// </summary>
        private void PrintRaceResult()
        {
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            //UGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLYUGLY
            int bestDistance = -1;
            Car bestCar = Cars[0];

            foreach (var car in Cars)
            {
                car.StateToString();
                if (car.DistanceTravelled>bestDistance)
                {
                    bestCar = car;
                }
            }

            bestDistance = -1;
            Motorcycle bestMotorcycle = Motorcycles[0];

            foreach (var motorcycle in Motorcycles)
            {
                motorcycle.StateToString();
                if (motorcycle.DistanceTravelled>bestDistance)
                {
                    bestMotorcycle = motorcycle;
                }
            }

            bestDistance = -1;
            Truck bestTruck = Trucks[0];
            foreach (var truck in Trucks)
            {
                truck.StateToString();
                if (truck.DistanceTravelled>bestDistance)
                {
                    bestTruck = truck;
                }
            }

            Console.WriteLine();
            Console.WriteLine("And the winers are:");
            bestCar.StateToString();
            bestMotorcycle.StateToString();
            bestTruck.StateToString();
        }

        static void Main(string[] args)
        {
            Weather.SetRaining();

            var race = new Race();
            Car.GetAvailableCarNames();
            race.CreateVehicles();

            race.SimulateRace();

            race.PrintRaceResult();
        }
    }
}
