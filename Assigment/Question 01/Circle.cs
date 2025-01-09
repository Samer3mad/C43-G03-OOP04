using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Question_01
{
    internal class Circle : ICircle
    {
        double rad;

        public Circle(double radius)
        {
            rad = radius;
        }

        public double Area
        {
            get { return 3.14 * rad * rad; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Circle= {Area}");
        }
    }
}
