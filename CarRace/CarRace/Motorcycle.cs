using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Motorcycle : Vehicle
    {
        private static int nameCount { get; set; } = 1;

        public Motorcycle()
        {
            NormalSpeed = (Weather.isRaining) ? 100 - Race.rnd.Next(5, 50) : 100;
            Name = "Motorcycle " + nameCount.ToString();
            nameCount++;
        }

        public void MoveForAnHour(Race race)
        {
            DistanceTravelled += NormalSpeed;
        }
    }
}
