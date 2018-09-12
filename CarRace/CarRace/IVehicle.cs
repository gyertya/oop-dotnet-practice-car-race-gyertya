using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    interface IVehicle
    {
        void StateToString();

        void MoveForAnHour(Race race);

        int DistanceTravelled { get; }

        string Name { get; }
    }
}
