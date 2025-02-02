﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{



    public class Suv : IVehicle, ICompany
    {



        public double EngineSize { get; set; } = 5;
        public string Make { get; set; } = "BMW";
        public string Model { get; set; } = "x1";
        public int SeatCount { get; set; } = 8;
        public string CompanyName { get; set; } = "BMW";
        public string Motto { get; set; } = "The ultimate driving machine";
        public bool HasChangedGears { get; set; } 
        public bool HasFourWheelDrive { get; set; } = true;


        public void Drive()

        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . .");


            }
            else
            {


                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . .");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");

            }
        }


        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears. . .");
            }

        }
        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }    

    
}
