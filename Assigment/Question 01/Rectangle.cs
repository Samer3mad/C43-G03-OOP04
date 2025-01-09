using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Question_01
{
    internal class Rectangle
    {
        double width;
        double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area
        {
            get { return width * height; }
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Rectangle= {Area}");
        }
    }
}
