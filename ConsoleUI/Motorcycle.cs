using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This {Make} is in drive.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {Make} is in virtual drive");
        }
        public bool HasSideCart { get; set; }
    }
}
