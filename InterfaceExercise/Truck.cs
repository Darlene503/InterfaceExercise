using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface Truck : Ivehicle, Icompany
    {

        public class Truck
        {





            public double EngineSize { get; set; } = 7;
            public string Make { get; set; } = "Ford";
            public string Model { get; set; } = "F150";
            public int SeatCount { get; set; } = 4;
            public string CompanyName { get; set; } = "Ford";
            public string Motto { get; set; } = "Like a Rock";
            public bool ChangeGears { get; set; }
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



                if (ChangeGears == true)
                {
                    Console.WriteLine($"{GetType().Name}now driving forward. . .");
                    ChangeGears = false;
                }
                else
                {
                    Console.WriteLine("Can't reverse until we change gears");

                }

            }
            public void Park()
            {


                if (ChangeGears == true)
                {
                    Console.WriteLine($"{GetType().Name} is now in park. . .");
                    ChangeGears = false;
                }
                else
                {
                    Console.WriteLine("Can't park until we change gears. . .");
                }


            }
            public void ChangedGears(bool isChanged)
            {

                ChangeGears = isChanged;
            }  

        }
    }
          
}

















           