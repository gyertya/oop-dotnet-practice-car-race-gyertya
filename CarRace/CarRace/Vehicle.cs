using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    abstract class Vehicle
    {
        /// <summary>
        /// <para>the normal speed of the car is a random number in the constructor between 80-110km/h.</para>
        /// <para>Motorcycle speed is 100km/h. If it rains, travels with 5-50km/h slower (randomly).</para>
        /// <para>Truck speed: 100km/h. 5% chance of breaking down for 2 hours.</para>
        /// </summary>
        public int NormalSpeed { get; set; }

        /// <summary>
        /// holds the current distance traveled.
        /// </summary>
        public int DistanceTravelled { get; set; } = 0;

    }
}
