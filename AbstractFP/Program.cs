using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to CarCo Workshop!");
            Console.Write("Choose material for your car parts (Steel/Aluminium): ");
            string material = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine();

            ICarPartsFactory factory;

            if (material == "steel")
            {
                factory = new SteelPartsFactory();
            }
            else
                if (material == "aluminium")
            {
                factory = new AluminiumPartsFactory();
            }
            else
            {
                Console.WriteLine("Invalid Material.");
                return;
            }

            Workshop ws = new Workshop(factory);
            ws.BuildCar();

            Console.ReadLine();
        }
    }
}
