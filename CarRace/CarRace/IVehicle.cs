using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    interface IVehicle
    {//TODO Someone said, interfaces have to be short... is it short?
        void StateToString();

        void MoveForAnHour(Race race);

        int DistanceTravelled { get; }

        string Name { get; } //TODO this is funny :) interface can contain property

        string Type { get; }
    }
}
