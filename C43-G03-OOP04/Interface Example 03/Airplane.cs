using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interface_Example_03
{
    internal class Airplane : Vichale, IMoveable, IFlyable
    {
        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlane is move forward in ground");
        }


        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane is move forward in air");
        }

        void IMoveable.Backward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }


        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
