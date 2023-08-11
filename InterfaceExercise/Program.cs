using System;
using System.Collections.Generic;

namespace InterfaceExercise;

    class Program
    {
    static void Main(string[] args)
    {
        var car = new Car();

        var truck =  new Truck();

        var suv = new Suv();

        var IVehicles = new List<IVehicle>() { car, truck, suv };
               
            foreach (var vehicle in IVehicles)
            {
            vehicle.Drive();
            vehicle.ChangeGears(true);
            vehicle.Reverse();
            }
        }


    }



