﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface Ivehicle
    {
        public class  Ivehicle
        {

        }


        public double EngineSize { get; set; }
        public string Make  { get; set; }
        public string Model { get; set; }
        public   int   SeatCount { get; set; }
        public bool ChangedGears { get; set; }


        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
        
        
    }
}
