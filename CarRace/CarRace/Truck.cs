using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Truck : Vehicle, IVehicle
    {
        public int BreakdownTurnsLeft { get; set; } //TODO implement it somewhere!

        public Truck()
        {
            NormalSpeed = 100;
            Name = Race.rnd.Next(0, 1000).ToString();
            Type = "Truck";
        }

        public void MoveForAnHour(Race race)
        {
            if (BreakdownTurnsLeft == 0)
            {
                DistanceTravelled += NormalSpeed;
            } else
            {
                BreakdownTurnsLeft--; //TODO implement breakdown!
            }
        }
    }
}
