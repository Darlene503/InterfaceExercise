using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public  class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "VW";
        public string Model { get; set; } = "Golf";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "VolksWagon";
        public string Motto { get; set; } = "Think Small";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
        Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing . . .");
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
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged; 
        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }


}   

        

          