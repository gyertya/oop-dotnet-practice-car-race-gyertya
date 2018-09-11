using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Motorcycle : Vehicle
    {
        /// <summary>
        /// <para>The motorcycle's names are called "Motorcycle 1", "Motorcycle 2", "Motorcycle 3",... Unique.</para>
        /// </summary>
        public string Name { get; set; }

        public Motorcycle()
        {
            NormalSpeed = (Weather.isRaining) ? 100 - Race.rnd.Next(5,50) : 100;
        }
    }
}
