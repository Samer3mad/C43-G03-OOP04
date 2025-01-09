using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Interface_Example_01
{
    //Dev 1
    internal class ITypes
    {
        //Public Access Modifier is a default access modifier inside the interface

        //Private Access Modifier is not allowed for the signature only [Propertye, Method]

        //What i can write inside the interface?
        //1. Signature for property
        public int MyProperty { get; set; }

        //2. Signature for method

        public void MyMethod();

        //3. Default implemented method [C# 8.0 NEW Faeture]
        public void Print()
        {
            Console.WriteLine("Default Implemented Method");
        }

        ///4. Static Members
        /// //4.1 Fildes
        /// //4.2 Properties
        /// 4.3 Methods
        /// //Events
    }
}
