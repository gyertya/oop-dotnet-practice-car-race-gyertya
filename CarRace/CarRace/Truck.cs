using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Truck : Vehicle
    {
        public int BreakdownTurnsLeft { get; set; }

        public Truck()
        {
            NormalSpeed = 100;
            Name = Race.rnd.Next(0, 1000).ToString();
        }

        public void MoveForAnHour(Race race)
        {
            if (BreakdownTurnsLeft == 0)
            {
                DistanceTravelled += NormalSpeed;
            } else
            {
                BreakdownTurnsLeft--;
            }
        }
    }
}
