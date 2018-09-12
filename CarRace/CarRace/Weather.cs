using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Weather
    {
        /// <summary>
        /// 30% chance of rain.
        /// </summary>
        public static bool isRaining { get; private set; }

        public static void SetRaining()
        {
                isRaining = (Race.rnd.Next(0,100) > 30) ? false : true; //TODO implement this method to every lap, not only race!
        }

    }
}
