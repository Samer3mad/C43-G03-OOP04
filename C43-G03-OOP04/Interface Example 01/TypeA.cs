using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interface_Example_01
{
    internal class TypeA
    {
        private int MyAttribute;
        public int MyProperty
        {
            get { return MyAttribute; }
            set { MyAttribute = value; }
        }


        public void MyMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
}
