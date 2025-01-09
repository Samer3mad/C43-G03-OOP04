using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Built_In_Interfaces
{
    internal class Employee : ICloneable, IComparable
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public Department? Dep { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                ID = this.ID,
                Name = this.Name,
                Salary = this.Salary,
                Dep = (Department?)this.Dep?.Clone()
            };
        }

        public int CompareTo(object? obj)
        {
            Employee? other = (Employee?)obj; //Explicit Casting
                                              // Unsafe Casting
                                              //if (other is null)
                                              //    return 1;

            //if (this.Salary > other.Salary)
            //    return 1;

            //else if (this.Salary < other.Salary)
            //    return -1;
            //return 0;
            return /*-*/ this.Salary.CompareTo(other?.Salary);
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Salary: {Salary:c}";
        }
    }
}
