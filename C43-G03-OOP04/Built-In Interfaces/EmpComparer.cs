using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Built_In_Interfaces
{
    internal class EmpComparer
    {
        class EmpComparer : IComparer
        {
            public int Compare(object? x, object? y)
            {
                Employee? empx = (Employee?)x;

                Employee? empy = (Employee?)y;

                return /*-*/ empx?.ID.CompareTo(empy?.ID) ?? (empy is null ? 0 : -1);
            }
        }
}
