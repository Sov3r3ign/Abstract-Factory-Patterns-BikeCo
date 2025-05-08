using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    class AluminiumPartsFactory:ICarPartsFactory
    {
        public IFrame createF()
        {
            return new AluminiumFrame();
        }
        public IWheel createW()
        {
            return new AluminiumWheel();
        }
        public IHandle createH()
        {
            return new AluminiumHandle();
        }
        public IBrake createB()
        {
            return new AluminiumBrake();
        }
        public IPedal createP()
        {
            return new AluminiumPedals();
        }
        public ISeat createS()
        {
            return new AluminiumSeat();
        }
    }
}
