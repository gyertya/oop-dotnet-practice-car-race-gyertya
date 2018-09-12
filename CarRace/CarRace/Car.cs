using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Car : Vehicle, IVehicle
    {
        public Car()
        {
            Name = availableCarNames[Race.rnd.Next(availableCarNames.Count)];
            NormalSpeed = Race.rnd.Next(80, 110);
        }

        private static List<string> availableCarNames;

        public static void GetAvailableCarNames()
        {
            availableCarNames = new List<string>();
            using (StreamReader str = new StreamReader("CarNames.txt"))
            {
                string line;
                while ((line = str.ReadLine()) != null)
                {
                    availableCarNames.Add(line);
                }
            }
        }

        public void MoveForAnHour(Race race)
        {
            this.DistanceTravelled += NormalSpeed;
        }

    }
}
