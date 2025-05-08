using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFP
{
    interface ICarPartsFactory
    {
        //Abstract Factory Interface
        IFrame createF();
        IWheel createW();
        IHandle createH();
        IBrake createB();
        IPedal createP();
        ISeat createS();
        
    }
}
