using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interface_Example_02
{
    class TypeB
    {
        public int Current { get; set; }

        public void getNext()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
