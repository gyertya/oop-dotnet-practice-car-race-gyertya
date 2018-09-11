# oop-dotnet-practice-car-race-gyertya
some kind of copy from a java assignment

* Car race
Your taks will be to simulate a race.  You will need to create 10
cars, 10 trucks, 10 motorcycles, and race them for 50 hours.  After
simulating the race print the results.

As a guideline here are the classes you will need to create and some
of their functions/properties.  Note that this is just a skeleton, feel
free to add more methods/variables.  But you must implement the ones
described here!

#+BEGIN_SRC java
  Race
   createVehicles() // creates 10 cars, 10 trucks and 10 motorcycles.
   simulateRace() // simulates the race by
                  // - calling moveForAnHour() on every vehicle 50 times
                  // - setting whether its raining
   printRaceResults() // prints each vehicle's name, distance traveled ant type.
   boolean isThereABrokenTruck() //
   static main(String[]) // The entry point of our program.

  Weather
   static setRaining() // 30% chance of rain.
   static boolean isRaining() // is it raining currently.

  Car
   normalSpeed // the normal speed of the car. Set to a random number in the constructor between 80-110km/h.
   name // Make a list from the words here: http://www.fantasynamegenerators.com/car-names.php and pick 2 randomly for each instance.
   distanceTraveled // holds the current distance traveled.
   moveForAnHour(Race race) // The vehicle travels for an hour. It increases the distance traveled. Call this from the main class only!
                            // If there is a broken down Truck on the track, then limit the max speed of vehicles to 75 km/h.

  Motorcycle // speed is 100km/h. If it rains, travels with 5-50km/h slower (randomly).
   static nameNumber // The number of the instance created. Used for its name.
   name // Are called "Motorcycle 1", "Motorcycle 2", "Motorcycle 3",... Unique.
   distanceTraveled
   moveForAnHour(Race race)

  Truck // speed: 100km/h. 5% chance of breaking down for 2 hours.
   // Truck drivers are boring. They call all their trucks a random number between 0 and 1000.
   breakdownTurnsLeft // holds how long its still broken down.
   distanceTraveled
   moveForAnHour(Race race)
#+END_SRC
* Hints
- Have you noticed that Car, Motorcycle and Truck share some similarities?
  Use inheritance to abstract away common parts.
- Use the built-in Random class to generate random numbers.
  Implement a util class around it, if you find it useful.
