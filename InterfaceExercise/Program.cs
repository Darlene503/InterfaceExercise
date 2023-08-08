using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car();

            var Truck = new Truck();

            var Suv = new Suv();

            var Ivehicles = new List<Ivehicle>() { Car, Truck, Suv };

            foreach (var vehicle in Ivehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();

            }


        }


    }

}
