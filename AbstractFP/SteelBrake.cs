using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class SteelBrake:IBrake
    {
        public void AddBrakes()
        {
            Console.WriteLine("Steel brakes have been added!.");
        }
    }
}
