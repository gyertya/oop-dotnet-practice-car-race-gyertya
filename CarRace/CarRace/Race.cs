using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Race
    {
        public List<IVehicle> Cars { get; set; }
        public List<IVehicle> Motorcycles { get; set; }
        public List<IVehicle> Trucks { get; set; }
        private List<List<IVehicle>> Vehicles { get; set; }  //It's a good practice?

        private const int numberOfVehiclesInEveryType = 10;
        public static Random rnd = new Random();

        public bool IsThereABrokenTruck { get; set; }

        /// <summary>
        /// creates 10 cars, 10 trucks and 10 motorcycles.
        /// </summary>
        private void CreateVehicles()
        {
            Cars = new List<IVehicle>();
            Motorcycles = new List<IVehicle>();
            Trucks = new List<IVehicle>();
            Vehicles = new List<List<IVehicle>>();

            for (int i = 0; i < numberOfVehiclesInEveryType; i++)
            {
                Cars.Add(new Car());
                Motorcycles.Add(new Motorcycle());
                Trucks.Add(new Truck());
            }

            Vehicles.Add(Cars);
            Vehicles.Add(Motorcycles);
            Vehicles.Add(Trucks);
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
                for (int vehicle = 0; vehicle < numberOfVehiclesInEveryType; vehicle++)
                {
                    Cars[vehicle].MoveForAnHour(this);
                    Motorcycles[vehicle].MoveForAnHour(this);
                    Trucks[vehicle].MoveForAnHour(this);
                }

            }
        }

        /// <summary>
        /// prints each vehicle's name, distance traveled ant type.
        /// </summary>
        private void PrintRaceResult()
        {
            int bestDistance = -1;
            List<IVehicle> bestVehicles = new List<IVehicle>();
            foreach (var vehicleType in Vehicles)
            {
                bestVehicles.Add(vehicleType[0]);
                foreach (var vehicle in vehicleType)
                {
                    vehicle.StateToString();
                    if (bestVehicles[bestVehicles.Count - 1].DistanceTravelled > bestDistance)
                    {
                        bestVehicles[bestVehicles.Count - 1] = vehicle;
                    }
                    bestDistance = -1;
                }
            }

            PrintWinners(bestVehicles);
        }

        private static void PrintWinners(List<IVehicle> bestVehicles)
        {
            Console.WriteLine();
            Console.WriteLine("And the winers are:");
            
            foreach (var bestVehicle in bestVehicles)
            {
                Console.WriteLine($"In category {bestVehicle.Type}, the winner is:");
                Console.WriteLine($"\t {bestVehicle.Name}, distance travelled: {bestVehicle.DistanceTravelled}");
            }
        }

        static void Main(string[] args)
        {
            Weather.SetRaining();

            var race = new Race();

            Car.GetAvailableCarNames(); //HOW Can I make it automaticall?

            race.CreateVehicles();

            race.SimulateRace();

            race.PrintRaceResult();
        }
    }
}
