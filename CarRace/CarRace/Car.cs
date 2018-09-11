using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Car : Vehicle
    {
        /// <summary>
        /// <para>Tha car's name : a list from the words here: http://www.fantasynamegenerators.com/car-names.php and pick 2 randomly for each instance.</para>
        /// </summary>
        public string Name { get; set; }

        public Car()
        {
            Name = carNames[Race.rnd.Next(carNames.Count)];
            NormalSpeed = Race.rnd.Next(80, 110);
        }

        private static List<string> carNames;

        public static void GetAvailableCarNames()
        {
            carNames = new List<string>();
            using (StreamReader str = new StreamReader("CarNames.txt"))
            {
                string line;
                while ((line = str.ReadLine()) != null)
                {
                    carNames.Add(line);
                }
            }
        }

        public void MoveForAnHour(Race race)
        {

        }

    }
}
