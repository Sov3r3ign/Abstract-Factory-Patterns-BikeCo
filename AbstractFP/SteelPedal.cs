using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class SteelPedal:IPedal
    {
        public void AddPedals()
        {
            Console.WriteLine("Steel pedals have been added.");
        }
    }
}
