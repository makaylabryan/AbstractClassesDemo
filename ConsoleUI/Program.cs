using System;
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
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /* DONE DONE DONE
             * Create an abstract class called Vehicle   ---DONE
             * The vehicle class shall have three string properties Year, Make, and Model  ---DONE
             * Set the defaults to something generic in the Vehicle class   ---DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation   ---DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.   ---DONE
             */

            /* DONE DONE DONE DONE
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle   ---DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle   ---DONE
             * Provide the implementations for the abstract methods   ---DONE
             * Only in the Motorcycle class will you override the virtual drive method ---DONE
            */

            // Create a list of Vehicle called vehicles  ---DONE
            List<Vehicle> vehicles = new List<Vehicle>();

            /* DONE
             * Create 4 instances: 1 Car, 1 Motorcycle     ---DONE
             * and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes   ---DONE
             * 
             * Set the properties with object initializer syntax   ---DONE
             */
            Car myFirstCar = new Car()
            {
                HasTrunk = true,
                Make = "Pontiac",
                Model = "Grand Am",
                Year = "1994",
            };

            Motorcycle hisFirstMotorcycle = new Motorcycle()
            {
                HasSideCart = false,
                Make = "Harley Davidson",
                Model = "Nightster",
                Year = "2014",
            };

            Vehicle truck = new Car()
            {
                HasTrunk = false,
                Make = "Ford",
                Model = "F-150",
                Year = "2022",
            };

            Vehicle suv = new Car() { HasTrunk = true, Make = "Hyundai", Model = "Santa Fe", Year = "2015" };

            vehicles.Add(myFirstCar);
            vehicles.Add(truck);
            vehicles.Add(suv);
            vehicles.Add(hisFirstMotorcycle);
            /*
             * Add the 4 vehicles to the list   ---DONE
             * Using a foreach loop iterate over each of the properties   ---DONE
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine("");
            }

            // Call each of the drive methods for one car and one motorcycle  ---DONE
            myFirstCar.DriveAbstract();
            Console.WriteLine();
            myFirstCar.DriveVirtual();
            Console.WriteLine();

            hisFirstMotorcycle.DriveVirtual();
            Console.WriteLine();
            hisFirstMotorcycle.DriveAbstract();
            Console.WriteLine();
            #endregion            
            Console.ReadLine();
        }
    }
}
