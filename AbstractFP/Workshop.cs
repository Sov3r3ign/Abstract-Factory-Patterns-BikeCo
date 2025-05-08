using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class Workshop
    {
        private readonly ICarPartsFactory _fac;

        public Workshop(ICarPartsFactory factory)
        {
            _fac = factory;
        }

        public void BuildCar()
        {
            IFrame frame = _fac.createF(); 
            frame.createFrame();
            IWheel wheels = _fac.createW(); 
            wheels.AddWheel();
            IHandle handles = _fac.createH(); 
            handles.AddHandle();
            IBrake brakes = _fac.createB(); 
            brakes.AddBrakes();
            IPedal pedals = _fac.createP(); 
            pedals.AddPedals();
            ISeat seat = _fac.createS(); 
            seat.AddSeat();

            Console.WriteLine("Bicycle assembly complete.");
        }
    }
}
