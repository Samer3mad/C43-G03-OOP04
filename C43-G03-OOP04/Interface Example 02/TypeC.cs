using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interface_Example_02
{
    class TypeC
    {
        public int Current { get; set; }

        public void getNext()
        {
            Current += 4;
        }


        public void Reset()
        {
            Current = 0;
        }
    }
}
