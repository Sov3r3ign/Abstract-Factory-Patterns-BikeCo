using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class AluminiumBrake:IBrake
    {
        public void AddBrakes()
        {
            Console.WriteLine("Aluminium brakes have been added!.");
        }
    }
}
