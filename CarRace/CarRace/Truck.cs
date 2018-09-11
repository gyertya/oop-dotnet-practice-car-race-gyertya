using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Truck : Vehicle
    {
        /// <summary>
        /// <para>Truck drivers are boring. They call all their trucks a random number between 0 and 1000.</para>
        /// </summary>
        public string Name { get; set; }

        public int BreakdownTurnsLeft { get; set; }

        public Truck()
        {
            NormalSpeed = 100;
            Name = Race.rnd.Next(0, 1000).ToString();
        }
    }
}
