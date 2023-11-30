﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle virtual drive method.");
        }
    }
}
