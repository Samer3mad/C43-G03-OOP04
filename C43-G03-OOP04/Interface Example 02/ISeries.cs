using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interface_Example_02
{
    internal interface ISeries
    {
        public int Current { get; set; }

        public void getNext();

        public void Reset();
    }
}
