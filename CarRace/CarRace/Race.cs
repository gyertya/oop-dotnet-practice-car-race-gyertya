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
                
            }

        }

        /// <summary>
        /// prints each vehicle's name, distance traveled ant type.
        /// </summary>
        private void PrintRaceResult()
        {

        }

        static void Main(string[] args)
        {
            Weather.SetRaining();

            var race = new Race();
            Car.GetAvailableCarNames();
            race.CreateVehicles();

        }
    }
}
