using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Built_In_Interfaces
{
    internal class Department : ICloneable
    {
        public int code { get; set; }

        public string? Title { get; set; }

        public object Clone()
        {
            return new Department()
            {
                code = this.code,
                Title = this.Title
            };
        }
    }
}
