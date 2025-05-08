using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class SteelPartsFactory:ICarPartsFactory
    {
        public IFrame createF()
        {
            return new SteelFrame();
        }
        public IWheel createW()
        {
            return new SteelWheel();
        }
        public IHandle createH()
        {
            return new SteelHandle();
        }
        public IBrake createB()
        {
            return new SteelBrake();
        }
        public IPedal createP()
        {
            return new SteelPedal();
        }
        public ISeat createS()
        {
            return new SteelSeat();
        }
    }
}
