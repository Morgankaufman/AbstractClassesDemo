﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var car1 = new Car()
            {
                Year = "2001",
                Make = "Infiniti",
                Model = "G20",
                HasTrunk = true,

            };

            var motorcycle1 = new Motorcycle()
            {
                Year = "1978",
                Make = "Honda",
                Model = "CB550",
                HasSideCart = true
            };

            Vehicle vehicle1 = new Car()
            {
                Year = "2012",
                Make = "Chevy",
                Model = "Traverse",
                
            };

            Vehicle vehicle2 = new Motorcycle()
            {
                Year = "2023",
                Make = "Harley-Davidson",
                Model = "Softail",
                
            };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }


            /*
             * DONE: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties: Year, Make, and Model
             * DONE Set the defaults of the properties to something generic in the Vehicle class
             * DONE Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * DONE Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE Provide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE Create a list of Vehicle called vehicles

            /*
             * DONE Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * DONE Set the properties values with object initializer syntax
             */

            /*
             * DONE Add the 4 vehicles to the list
             * DONE Using a foreach loop iterate through the list and display each of the properties
             */

            // DONE Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
