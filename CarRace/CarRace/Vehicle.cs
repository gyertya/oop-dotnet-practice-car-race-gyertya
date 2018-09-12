using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    abstract class Vehicle
    {//how important a documentation comment? It is good? How can I hide all in one click (collapse?)?
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

        /// <summary>
        /// <para>Tha car's name : a list from the words here: http://www.fantasynamegenerators.com/car-names.php and pick 2 randomly for each instance.</para>
        /// </summary>
        public string Name { get; set; }

        public string Type { get; set; } // It's a good practice? I store vehicles in a List<IVechicle> (in race)... so I don't know it's type when announcement the results

        public void StateToString()
        {
            Console.WriteLine($"{Name}'s total distance: {DistanceTravelled}");
        }
    }
}
